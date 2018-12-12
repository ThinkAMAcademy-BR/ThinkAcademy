using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ThinkAM.ThinkAcademy.Controllers
{
    public abstract class ThinkAcademyControllerBase: AbpController
    {
        protected ThinkAcademyControllerBase()
        {
            LocalizationSourceName = ThinkAcademyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
