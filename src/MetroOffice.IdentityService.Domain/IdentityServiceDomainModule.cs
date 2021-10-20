using Volo.Abp.Identity;
using Volo.Abp.IdentityServer;
using Volo.Abp.Modularity;

namespace MetroOffice.IdentityService.Domain
{
    [DependsOn(
        typeof(IdentityServiceDomainSharedModule),
        typeof(AbpIdentityDomainModule),
        typeof(AbpIdentityServerDomainModule)
    )]
    public class IdentityServiceDomainModule : AbpModule
    {
    }
}
