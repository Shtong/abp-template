namespace Abp.Starter.Web.Startup
{
    using Abp.Application.Navigation;
    using Abp.Localization;
    using Microsoft.Extensions.Localization;
    using System;

    public class AbpStarter_Cn_NavigationProvider : NavigationProvider
    {
        public static readonly string LocalizationSource = "NavigationProvider";

        public static readonly string IndexPageName = "Index";

        public IStringLocalizer<AbpStarter_Cn_NavigationProvider> StringLocalizer { get; set; }

        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu.AddItem(new MenuItemDefinition(
                IndexPageName,
                L("Index")
            ));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, LocalizationSource);
        }
    }
}
