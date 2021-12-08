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
            var cat = c.TB_CATEGORIES.ToList();
            return View(cat);
        }
    }
}
