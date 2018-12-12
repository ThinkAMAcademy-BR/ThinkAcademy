using Microsoft.AspNetCore.Antiforgery;
using ThinkAM.ThinkAcademy.Controllers;

namespace ThinkAM.ThinkAcademy.Web.Host.Controllers
{
    public class AntiForgeryController : ThinkAcademyControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
