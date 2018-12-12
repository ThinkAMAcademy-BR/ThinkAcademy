using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ThinkAM.ThinkAcademy.Configuration;

namespace ThinkAM.ThinkAcademy.Web.Host.Startup
{
    [DependsOn(
       typeof(ThinkAcademyWebCoreModule))]
    public class ThinkAcademyWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ThinkAcademyWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ThinkAcademyWebHostModule).GetAssembly());
        }
    }
}
