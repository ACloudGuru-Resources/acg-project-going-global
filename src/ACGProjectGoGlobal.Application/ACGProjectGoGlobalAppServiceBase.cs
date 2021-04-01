using Abp.Application.Services;

namespace ACGProjectGoGlobal
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ACGProjectGoGlobalAppServiceBase : ApplicationService
    {
        protected ACGProjectGoGlobalAppServiceBase()
        {
            LocalizationSourceName = ACGProjectGoGlobalConsts.LocalizationSourceName;
        }
    }
}