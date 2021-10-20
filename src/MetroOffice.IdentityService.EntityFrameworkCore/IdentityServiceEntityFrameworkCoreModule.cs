﻿using MetroOffice.IdentityService.Domain;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.SqlServer;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MetroOffice.IdentityService.EntityFrameworkCore
{
    [DependsOn(
        typeof(IdentityServiceDomainModule),
        typeof(AbpEntityFrameworkCoreSqlServerModule),
        typeof(AbpIdentityEntityFrameworkCoreModule),
        typeof(AbpIdentityServerEntityFrameworkCoreModule)
    )]
    public class IdentityServiceEntityFrameworkCoreModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            IdentityServiceEfCoreEntityExtensionMappings.Configure();
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<IdentityServiceDbContext>(options =>
            {
                options.ReplaceDbContext<IIdentityDbContext>();
                options.ReplaceDbContext<IIdentityServerDbContext>();

                options.AddDefaultRepositories(includeAllEntities: true);
            });

            Configure<AbpDbContextOptions>(options =>
            {
                options.Configure<IdentityServiceDbContext>(c =>
                {
                    c.UseSqlServer(b => { b.MigrationsHistoryTable("__IdentityService_Migrations"); });
                });
            });
        }
    }
}