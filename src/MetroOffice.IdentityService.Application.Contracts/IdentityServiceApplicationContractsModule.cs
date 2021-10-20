using MetroOffice.IdentityService.Domain.Shared;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace MetroOffice.IdentityService.Application.Contracts
{
    [DependsOn(
        typeof(IdentityServiceDomainSharedModule),
        typeof(AbpAccountApplicationContractsModule),
        typeof(AbpIdentityApplicationContractsModule)
    )]
    public class IdentityServiceApplicationContractsModule : AbpModule
    {
    }
}
