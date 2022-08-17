using GlowingMvcK220.Data;
using GlowingMvcK220.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GlowingMvcK220.Controllers
{
    public class CategoryController : Controller
    {
        private readonly GlowingDB _db;

        public CategoryController(GlowingDB db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Categories.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category cat)
        {
            _db.Categories.Add(cat);
            _db.SaveChanges();
            return RedirectToAction("index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Category? selectedCategory=_db.Categories.FirstOrDefault(c => c.Id == id);
            if (selectedCategory == null) return NotFound();
            return View(selectedCategory);
        }
        [HttpPost]
        public IActionResult Edit(Category cat)
        {
            _db.Categories.Update(cat);
            _db.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Delete(Category cat)
        {
            _db.Categories.Remove(cat);
            _db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
