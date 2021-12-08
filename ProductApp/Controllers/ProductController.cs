using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using System.Linq;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        Context c =new Context();
        public IActionResult Index()
        {
            return View();
        }

        #region Category

        [HttpGet]
        public IActionResult Category()
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
            return RedirectToAction("Category");
        }
        public IActionResult DeleteCategory(int ID)
        {
            var categoryToDelete = c.TB_CATEGORIES.Find(ID);
            if (categoryToDelete != null)
            {
                c.TB_CATEGORIES.Remove(categoryToDelete);
                c.SaveChanges();
            }
            return RedirectToAction("Category");
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
            return RedirectToAction("Category");
        }
        #endregion

        [HttpGet]
        public IActionResult Customer()
        {
            var cst = c.TB_CUSTOMERS.ToList();
            return View(cst);
        }
        [HttpGet]
        public IActionResult Product()
        {
            var pr = c.TB_PRODUCTS.ToList();
            return View(pr);
        }
        public IActionResult Sales()
        {
            return View();
        }
    }
}
