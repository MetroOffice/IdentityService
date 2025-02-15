﻿using MetroOffice.IdentityService.Application.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace MetroOffice.IdentityService.HttpApi.Client
{
    [DependsOn(
        typeof(IdentityServiceApplicationContractsModule),
        typeof(AbpAccountHttpApiClientModule),
        typeof(AbpIdentityHttpApiClientModule)
    )]
    public class IdentityServiceHttpApiClientModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(IdentityServiceApplicationContractsModule).Assembly,
                IdentityServiceRemoteServiceConsts.RemoteServiceName
            );
        }
    }
}
