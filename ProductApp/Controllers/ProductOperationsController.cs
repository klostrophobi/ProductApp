using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using System.Linq;

namespace ProductApp.Controllers
{
    public class ProductOperationsController : Controller
    {
        Context c =new Context();
        public IActionResult Index()
        {
            return View();
        }

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
