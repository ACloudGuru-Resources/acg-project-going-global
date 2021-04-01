using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ACGProjectGoGlobal
{
    [DependsOn(
        typeof(ACGProjectGoGlobalCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ACGProjectGoGlobalApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ACGProjectGoGlobalApplicationModule).GetAssembly());
        }
    }
}