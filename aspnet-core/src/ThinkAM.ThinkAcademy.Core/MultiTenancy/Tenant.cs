using Abp.MultiTenancy;
using ThinkAM.ThinkAcademy.Authorization.Users;

namespace ThinkAM.ThinkAcademy.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
