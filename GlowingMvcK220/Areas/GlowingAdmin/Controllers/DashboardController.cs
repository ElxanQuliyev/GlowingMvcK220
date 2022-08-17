using Microsoft.AspNetCore.Mvc;

namespace GlowingMvcK220.Areas.GlowingAdmin.Controllers
{
    [Area(nameof(GlowingAdmin))]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
