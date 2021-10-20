﻿using MetroOffice.IdentityService.Application.Contracts;
using MetroOffice.IdentityService.Domain;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace MetroOffice.IdentityService.Application
{
    [DependsOn(
        typeof(IdentityServiceDomainModule),
        typeof(IdentityServiceApplicationContractsModule),
        typeof(AbpAccountApplicationModule),
        typeof(AbpIdentityApplicationModule)
        )]
    public class IdentityServiceApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<IdentityServiceApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<IdentityServiceApplicationModule>(validate: true);
            });
        }
    }
}
