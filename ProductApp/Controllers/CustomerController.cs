using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using System.Linq;

namespace ProductApp.Controllers
{
    public class CustomerController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var cst = c.TB_CUSTOMERS.ToList();
            return View(cst);
        }
    }
}
