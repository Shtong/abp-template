namespace Abp.Starter.Web.Pages
{
    using Abp.Application.Features;
    using Abp.Authorization;
    using Abp.Configuration;
    using Abp.Localization;
    using Abp.Runtime.Session;
    using Microsoft.AspNetCore.Mvc.Razor.Internal;
    using Microsoft.AspNetCore.Mvc.RazorPages;

    /// <summary>
    /// Base type for all typed views in the application
    /// </summary>
    /// <typeparam name="TModel"></typeparam>
    public abstract class AbpStarter_Cn_PageModelBase : PageModel
    {
        /// <summary>
        /// Contains the current session information used by ABP
        /// </summary>
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        /// <summary>
        /// Reference to the localization manager.
        /// </summary>
        [RazorInject]
        public ILocalizationManager LocalizationManager { get; set; }

        /// <summary>
        /// Reference to the setting manager.
        /// </summary>
        [RazorInject]
        public ISettingManager SettingManager { get; set; }

        /// <summary>
        /// Reference to the permission checker.
        /// </summary>
        [RazorInject]
        public IPermissionChecker PermissionChecker { get; set; }

        /// <summary>
        /// Reference to the feature checker.
        /// </summary>
        [RazorInject]
        public IFeatureChecker FeatureChecker { get; set; }
    }
}
