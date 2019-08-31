namespace AbpStarter.EntityFramework
{
    using Abp.Modules;
    using AbpStarter.Core;
    using Abp.Zero.EntityFrameworkCore;
    using Abp.EntityFrameworkCore.Configuration;
    using AbpStarter.EntityFramework.AbpStarterContext;
    using Microsoft.EntityFrameworkCore;

    [DependsOn(
        typeof(AbpStarterCoreModule),
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class AbpStarterEntityFrameworkModule : AbpModule
    {
        /// <summary>
        /// If <see langword="true"/>, then this module will not register the 
        /// database contexts on startup. This can 
        /// </summary>
        public bool SkipContextRegistration { get; set; }

        /// <inheritdoc />
        public override void PreInitialize()
        {
            if(!SkipContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<AbpStarterDbContext>(options =>
                {
                    // TODO: Edit this part (remove both UseSqlServer) if you don't use SQL Server as your database engine
                    if (options.ExistingConnection != null)
                    {
                        options.DbContextOptions.UseSqlServer(options.ExistingConnection);
                    }
                    else
                    {
                        options.DbContextOptions.UseSqlServer(options.ConnectionString);
                    }
                });
            }
        }

        /// <inheritdoc />
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(GetType().Assembly);
        }
    }
}
