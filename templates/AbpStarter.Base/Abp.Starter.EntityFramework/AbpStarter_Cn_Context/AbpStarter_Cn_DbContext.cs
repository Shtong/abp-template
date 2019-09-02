namespace Abp.Starter.EntityFramework.AbpStarter_Cn_Context
{
    using Abp.Zero.EntityFrameworkCore;
    using Abp.Starter.Core.Authentication;
    using Abp.Starter.Core.MultiTenancy;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// This is an EF Contextfor the main database of the application
    /// </summary>
    public class AbpStarter_Cn_DbContext : AbpZeroDbContext<Tenant, Role, User, AbpStarter_Cn_DbContext>
    {
        /// <summary>
        /// Creates a new instance of <see cref="AbpStarter_Cn_DbContext"/>.
        /// </summary>
        /// <param name="options">The context creation options</param>
        public AbpStarter_Cn_DbContext(DbContextOptions<AbpStarter_Cn_DbContext> options)
            : base(options)
        {
        }

        // Define here one DbSet for each entity you create in the Core library
    }
}
