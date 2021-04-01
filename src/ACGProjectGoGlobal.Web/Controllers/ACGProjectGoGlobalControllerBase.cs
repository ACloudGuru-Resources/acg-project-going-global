using Abp.AspNetCore.Mvc.Controllers;

namespace ACGProjectGoGlobal.Web.Controllers
{
    public abstract class ACGProjectGoGlobalControllerBase: AbpController
    {
        protected ACGProjectGoGlobalControllerBase()
        {
            LocalizationSourceName = ACGProjectGoGlobalConsts.LocalizationSourceName;
        }
    }
}