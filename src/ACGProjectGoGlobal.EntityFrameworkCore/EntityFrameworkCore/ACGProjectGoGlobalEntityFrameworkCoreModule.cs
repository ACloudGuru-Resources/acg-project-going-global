using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace ACGProjectGoGlobal.EntityFrameworkCore
{
    [DependsOn(
        typeof(ACGProjectGoGlobalCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class ACGProjectGoGlobalEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ACGProjectGoGlobalEntityFrameworkCoreModule).GetAssembly());
        }
    }
}