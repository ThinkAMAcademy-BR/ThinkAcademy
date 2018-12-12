using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ThinkAM.ThinkAcademy.Authorization;
using ThinkAM.ThinkAcademy.Authorization.Roles;
using ThinkAM.ThinkAcademy.Authorization.Users;
using ThinkAM.ThinkAcademy.Editions;
using ThinkAM.ThinkAcademy.MultiTenancy;

namespace ThinkAM.ThinkAcademy.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
