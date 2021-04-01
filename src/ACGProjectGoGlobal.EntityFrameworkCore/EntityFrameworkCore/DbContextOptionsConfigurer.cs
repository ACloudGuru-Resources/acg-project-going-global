using Microsoft.EntityFrameworkCore;

namespace ACGProjectGoGlobal.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<ACGProjectGoGlobalDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for ACGProjectGoGlobalDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
