using Abp.Authorization;
using ThinkAM.ThinkAcademy.Authorization.Roles;
using ThinkAM.ThinkAcademy.Authorization.Users;

namespace ThinkAM.ThinkAcademy.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
