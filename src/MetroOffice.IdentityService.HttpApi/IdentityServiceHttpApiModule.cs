using MetroOffice.IdentityService.Application.Contracts;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace MetroOffice.IdentityService.HttpApi
{
    [DependsOn(
        typeof(IdentityServiceApplicationContractsModule),
        typeof(AbpAccountHttpApiModule),
        typeof(AbpIdentityHttpApiModule)
    )]
    public class IdentityServiceHttpApiModule : AbpModule
    {
    }
}