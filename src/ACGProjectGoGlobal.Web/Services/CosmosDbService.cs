using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos;
using Container = Microsoft.Azure.Cosmos.Container;
using User = ACGProjectGoGlobal.Web.Models.User;

namespace ACGProjectGoGlobal.Web.Services
{
    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddItemAsync(User user)
        {
            await this._container.CreateItemAsync<User>(user, new PartitionKey(user.id.ToString()));
        }

        public async Task DeleteItemAsync(string id)
        {
            await this._container.DeleteItemAsync<User>(id, new PartitionKey(id));
        }

        public async Task<User> GetItemAsync(string id)
        {
            try
            {
                ItemResponse<User> response = await this._container.ReadItemAsync<User>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<IEnumerable<User>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<User>(new QueryDefinition(queryString));
            List<User> results = new List<User>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateItemAsync(string id, User User)
        {
            await this._container.UpsertItemAsync<User>(User, new PartitionKey(id));
        }
    }
}