using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ThinkAM.ThinkAcademy.EntityFrameworkCore
{
    public static class ThinkAcademyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ThinkAcademyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ThinkAcademyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
