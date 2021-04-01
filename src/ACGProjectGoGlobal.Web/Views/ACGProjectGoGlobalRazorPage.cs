using Abp.AspNetCore.Mvc.Views;

namespace ACGProjectGoGlobal.Web.Views
{
    public abstract class ACGProjectGoGlobalRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected ACGProjectGoGlobalRazorPage()
        {
            LocalizationSourceName = ACGProjectGoGlobalConsts.LocalizationSourceName;
        }
    }
}
