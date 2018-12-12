using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAM.ThinkAcademy.Authorization;

namespace ThinkAM.ThinkAcademy
{
    [DependsOn(
        typeof(ThinkAcademyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ThinkAcademyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ThinkAcademyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ThinkAcademyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
