namespace Abp.Starter.Web.Startup
{
    using Abp.AspNetCore;
    using Abp.Configuration.Startup;
    using Abp.Localization.Dictionaries;
    using Abp.Localization.Dictionaries.Xml;
    using Abp.Modules;
    using Abp.Starter.Application;
    using Abp.Starter.EntityFramework;
    using System.Reflection;

    [DependsOn(
        typeof(AbpStarter_Cn_ApplicationModule), 
        typeof(AbpStarter_Cn_EntityFrameworkModule),
        typeof(AbpAspNetCoreModule)
    )]
    public class AbpStarter_Cn_WebModule : AbpModule
    {
        public override void PreInitialize()
        {
            // Configure the navigation menu
            Configuration.Navigation.Providers.Add<AbpStarter_Cn_NavigationProvider>();

            RegisterLocalizationSources(Configuration.Localization.Sources);
        }

        private void RegisterLocalizationSources(ILocalizationSourceList localizationSources)
        {
            Assembly currentAssembly = GetType().Assembly;

            localizationSources.Add(new DictionaryBasedLocalizationSource(
                AbpStarter_Cn_NavigationProvider.LocalizationSource,
                new XmlEmbeddedFileLocalizationDictionaryProvider(
                    currentAssembly,
                    "Apb.Startup.Web.Localization.Startup.NavigationProvider"
                )
            ));
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(GetType().Assembly);
        }
    }
}
