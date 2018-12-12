using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ThinkAM.ThinkAcademy.Authorization.Roles;
using ThinkAM.ThinkAcademy.Authorization.Users;
using ThinkAM.ThinkAcademy.MultiTenancy;

namespace ThinkAM.ThinkAcademy.EntityFrameworkCore
{
    public class ThinkAcademyDbContext : AbpZeroDbContext<Tenant, Role, User, ThinkAcademyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ThinkAcademyDbContext(DbContextOptions<ThinkAcademyDbContext> options)
            : base(options)
        {
        }
    }
}
