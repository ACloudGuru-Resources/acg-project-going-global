using ACGProjectGoGlobal.Configuration;
using ACGProjectGoGlobal.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ACGProjectGoGlobal.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class ACGProjectGoGlobalDbContextFactory : IDesignTimeDbContextFactory<ACGProjectGoGlobalDbContext>
    {
        public ACGProjectGoGlobalDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ACGProjectGoGlobalDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(ACGProjectGoGlobalConsts.ConnectionStringName)
            );

            return new ACGProjectGoGlobalDbContext(builder.Options);
        }
    }
}