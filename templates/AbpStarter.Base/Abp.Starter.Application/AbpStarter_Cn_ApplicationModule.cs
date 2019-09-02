namespace Abp.Starter.Application
{
    using Abp.AutoMapper;
    using Abp.Modules;
    using Abp.Starter.Core;
    using System.Reflection;

    /// <summary>
    /// Defines the ABP module for the Application library
    /// </summary>
    [DependsOn(
        typeof(AbpStarterCoreModule),
        typeof(AbpAutoMapperModule))]
    public class AbpStarter_Cn_ApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            Assembly executingAssembly = GetType().Assembly;

            // Registers the standard ABP services
            IocManager.RegisterAssemblyByConvention(executingAssembly);

            // Registers the AutoMapper profile. If you need to manually configure a
            // mapping, create a class inheriting from AutoMapper.Profile and it will
            // be automatically loaded.
            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                cfg => cfg.AddMaps(executingAssembly)
            );
        }
    }
}
