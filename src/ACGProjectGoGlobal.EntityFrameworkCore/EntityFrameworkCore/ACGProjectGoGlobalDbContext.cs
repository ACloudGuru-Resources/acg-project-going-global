using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ACGProjectGoGlobal.EntityFrameworkCore
{
    public class ACGProjectGoGlobalDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public ACGProjectGoGlobalDbContext(DbContextOptions<ACGProjectGoGlobalDbContext> options) 
            : base(options)
        {

        }
    }
}
