using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ACGProjectGoGlobal.Web.Startup;
namespace ACGProjectGoGlobal.Web.Tests
{
    [DependsOn(
        typeof(ACGProjectGoGlobalWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class ACGProjectGoGlobalWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ACGProjectGoGlobalWebTestModule).GetAssembly());
        }
    }
}