using Abp.Application.Navigation;
using Abp.Localization;

namespace ACGProjectGoGlobal.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class ACGProjectGoGlobalNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: ""
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: ""
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, ACGProjectGoGlobalConsts.LocalizationSourceName);
        }
    }
}
