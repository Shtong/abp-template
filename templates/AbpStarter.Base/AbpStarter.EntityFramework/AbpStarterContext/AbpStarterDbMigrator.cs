namespace AbpStarter.EntityFramework.AbpStarterContext
{
    using Abp.Domain.Uow;
    using Abp.EntityFrameworkCore;
    using Abp.MultiTenancy;
    using Abp.Zero.EntityFrameworkCore;

    /// <summary>
    /// This is a helper class used to apply migrations on the database targeted by <see cref="AbpStarterDbContext"/>.
    /// </summary>
    public class AbpStarterDbMigrator : AbpZeroDbMigrator<AbpStarterDbContext>
    {
        /// <summary>
        /// Creates a new instance of <see cref="AbpStarterDbMigrator"/>
        /// </summary>
        /// <param name="unitOfWorkManager"></param>
        /// <param name="connectionStringResolver"></param>
        /// <param name="dbContextResolver"></param>
        public AbpStarterDbMigrator(
            IUnitOfWorkManager unitOfWorkManager, 
            IDbPerTenantConnectionStringResolver connectionStringResolver, 
            IDbContextResolver dbContextResolver) 
            : base(unitOfWorkManager, connectionStringResolver, dbContextResolver)
        {
        }
    }
}
