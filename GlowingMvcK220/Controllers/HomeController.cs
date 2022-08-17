using GlowingMvcK220.Data;
using GlowingMvcK220.Models;
using GlowingMvcK220.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GlowingMvcK220.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  readonly GlowingDB _db;
        public HomeController(ILogger<HomeController> logger, GlowingDB db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM vm = new()
            {
                Section1s = _db.Section1s.OrderByDescending(c=>c.Id).ToList(),
                FavoriteProducts=_db.Products.Where(c=>c.IsFavorite).ToList(),
                FeaturedProducts=_db.Products.Where(c=>c.IsFeatured).ToList(),
                Categories=_db.Categories.OrderByDescending(c=>c.Id).ToList(),
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
//Crud