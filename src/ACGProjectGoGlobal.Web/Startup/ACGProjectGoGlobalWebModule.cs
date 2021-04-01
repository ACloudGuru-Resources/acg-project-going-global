using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ACGProjectGoGlobal.Configuration;
using ACGProjectGoGlobal.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace ACGProjectGoGlobal.Web.Startup
{
    [DependsOn(
        typeof(ACGProjectGoGlobalApplicationModule), 
        typeof(ACGProjectGoGlobalEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class ACGProjectGoGlobalWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ACGProjectGoGlobalWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(ACGProjectGoGlobalConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<ACGProjectGoGlobalNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(ACGProjectGoGlobalApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ACGProjectGoGlobalWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ACGProjectGoGlobalWebModule).Assembly);
        }
    }
}