using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAM.ThinkAcademy.Configuration;
using ThinkAM.ThinkAcademy.EntityFrameworkCore;
using ThinkAM.ThinkAcademy.Migrator.DependencyInjection;

namespace ThinkAM.ThinkAcademy.Migrator
{
    [DependsOn(typeof(ThinkAcademyEntityFrameworkModule))]
    public class ThinkAcademyMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ThinkAcademyMigratorModule(ThinkAcademyEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ThinkAcademyMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ThinkAcademyConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThinkAcademyMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
