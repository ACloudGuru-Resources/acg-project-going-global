using System.Collections.Generic;
using System.Threading.Tasks;
using ACGProjectGoGlobal.Web.Models;

namespace ACGProjectGoGlobal.Web.Services
{
    public interface ICosmosDbService
    {
        Task<IEnumerable<User>> GetItemsAsync(string query);
        Task<User> GetItemAsync(string id);
        Task AddItemAsync(User item);
        Task UpdateItemAsync(string id, User item);
        Task DeleteItemAsync(string id);
    }
}
