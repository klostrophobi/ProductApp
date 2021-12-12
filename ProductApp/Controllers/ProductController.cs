using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductApp.Controllers
{
    public class ProductController : Controller
    {
        Context c = new Context();
        public IActionResult Index(int ID)
        {
            var productList = c.TB_PRODUCTS.Include(x => x.Category).ToList().Where(x => x.Category.CategoryID == ID).ToList();
            if (productList == null || productList.Count == 0)
            {
                var pr = c.TB_PRODUCTS.Include(x => x.Category).ToList();
                return View(pr);
            }
            else
            {
                var pr = productList;
                return View(pr);
            }
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            List<SelectListItem> cats = (from x in c.TB_CATEGORIES.ToList()
                                         select new SelectListItem
                                         {
                                             Text = x.CategoryName,
                                             Value = x.CategoryID.ToString()
                                         }).ToList();
            ViewBag.Categories = cats;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            /*Take related table values*/
            var cat = c.TB_CATEGORIES.Where(x => x.CategoryID == product.Category.CategoryID).FirstOrDefault();
            product.Category = cat;

            c.TB_PRODUCTS.Add(product);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
