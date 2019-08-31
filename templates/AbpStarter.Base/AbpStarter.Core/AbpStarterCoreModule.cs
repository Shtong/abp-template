namespace AbpStarter.Core
{
    using Abp.Modules;
    using Abp.Zero;
    using Abp.Zero.Configuration;
    using AbpStarter.Core.Authentication;
    using AbpStarter.Core.MultiTenancy;

    /// <summary>
    /// Defines the ABP module for the Core library
    /// </summary>
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class AbpStarterCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            // Add actions from anonymous users in the audit log
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Configures authentication
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
        }
    }
}
