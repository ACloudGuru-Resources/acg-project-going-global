using Abp.Modules;
using Abp.Reflection.Extensions;
using ACGProjectGoGlobal.Localization;

namespace ACGProjectGoGlobal
{
    public class ACGProjectGoGlobalCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            ACGProjectGoGlobalLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ACGProjectGoGlobalCoreModule).GetAssembly());
        }
    }
}