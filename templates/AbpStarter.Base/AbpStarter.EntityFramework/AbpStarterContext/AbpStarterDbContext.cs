namespace AbpStarter.EntityFramework.AbpStarterContext
{
    using Abp.Zero.EntityFrameworkCore;
    using AbpStarter.Core.Authentication;
    using AbpStarter.Core.MultiTenancy;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// This is an EF Contextfor the main database of the application
    /// </summary>
    public class AbpStarterDbContext : AbpZeroDbContext<Tenant, Role, User, AbpStarterDbContext>
    {
        /// <summary>
        /// Creates a new instance of <see cref="AbpStarterDbContext"/>.
        /// </summary>
        /// <param name="options">The context creation options</param>
        public AbpStarterDbContext(DbContextOptions<AbpStarterDbContext> options)
            : base(options)
        {
        }

        // Define here one DbSet for each entity you create in the Core library
    }
}
