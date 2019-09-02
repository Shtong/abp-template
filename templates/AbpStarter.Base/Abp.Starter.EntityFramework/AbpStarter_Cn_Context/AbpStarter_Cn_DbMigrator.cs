namespace Abp.Starter.EntityFramework.AbpStarter_Cn_Context
{
    using Abp.Domain.Uow;
    using Abp.EntityFrameworkCore;
    using Abp.MultiTenancy;
    using Abp.Zero.EntityFrameworkCore;

    /// <summary>
    /// This is a helper class used to apply migrations on the database targeted by <see cref="AbpStarter_Cn_DbContext"/>.
    /// </summary>
    public class AbpStarter_Cn_DbMigrator : AbpZeroDbMigrator<AbpStarter_Cn_DbContext>
    {
        /// <summary>
        /// Creates a new instance of <see cref="AbpStarter_Cn_DbMigrator"/>
        /// </summary>
        /// <param name="unitOfWorkManager"></param>
        /// <param name="connectionStringResolver"></param>
        /// <param name="dbContextResolver"></param>
        public AbpStarter_Cn_DbMigrator(
            IUnitOfWorkManager unitOfWorkManager, 
            IDbPerTenantConnectionStringResolver connectionStringResolver, 
            IDbContextResolver dbContextResolver) 
            : base(unitOfWorkManager, connectionStringResolver, dbContextResolver)
        {
        }
    }
}
