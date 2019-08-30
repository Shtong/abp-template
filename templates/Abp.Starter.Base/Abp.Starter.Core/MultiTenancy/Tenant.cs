namespace AbpStarter.Core.MultiTenancy
{
    using Abp.MultiTenancy;
    using AbpStarter.Core.Authentication;

    /// <summary>
    /// Represents a tenant registered in the system
    /// </summary>
    /// <remarks>
    /// For more informations about tenants, see the reference documentation :
    /// https://aspnetboilerplate.com/Pages/Documents/Multi-Tenancy
    /// </remarks>
    public class Tenant : AbpTenant<User>
    {
        /// <summary>
        /// Creates a new empty instance of <see cref="Tenant"/>.
        /// </summary>
        public Tenant()
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="Tenant"/>.
        /// </summary>
        /// <param name="tenancyName">The unique name of the new tenant</param>
        /// <param name="name">Display name of the new tenant</param>
        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
