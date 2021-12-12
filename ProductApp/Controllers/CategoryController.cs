using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApp.Models;
using System.Linq;

namespace ProductApp.Controllers
{
    public class CategoryController : Controller
    {
        Context c = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var cat = c.TB_CATEGORIES.ToList();
            return View(cat);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            c.TB_CATEGORIES.Add(category);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int ID)
        {
            var categoryToDelete = c.TB_CATEGORIES.Find(ID);
            if (categoryToDelete != null)
            {
                c.TB_CATEGORIES.Remove(categoryToDelete);
                c.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult GetCategory(int ID)
        {
            var categoryToGet = c.TB_CATEGORIES.Find(ID);
            return View("GetCategory", categoryToGet);
        }
        public IActionResult UpdateCategory(Category category)
        {
            var categoryToUpdate = c.TB_CATEGORIES.Find(category.CategoryID);
            if (categoryToUpdate != null)
            {
                categoryToUpdate.CategoryName = category.CategoryName;
                c.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        //public IActionResult GoCategoryDetails(int ID)
        //{
        //    var products = c.TB_PRODUCTS.Include(x => x.Category).ToList().Where(x => x.Category.CategoryID == ID).ToList();
        //    return RedirectToAction("/Product/Index/", ID);
        //}
    }
}
    