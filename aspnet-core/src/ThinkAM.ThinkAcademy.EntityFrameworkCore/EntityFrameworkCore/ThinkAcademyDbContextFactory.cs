using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ThinkAM.ThinkAcademy.Configuration;
using ThinkAM.ThinkAcademy.Web;

namespace ThinkAM.ThinkAcademy.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ThinkAcademyDbContextFactory : IDesignTimeDbContextFactory<ThinkAcademyDbContext>
    {
        public ThinkAcademyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ThinkAcademyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ThinkAcademyDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ThinkAcademyConsts.ConnectionStringName));

            return new ThinkAcademyDbContext(builder.Options);
        }
    }
}
