using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ProductApp.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        public async Task<IActionResult> Login(Admin admin)
        {
            var loginInfo = c.TB_ADMIN.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (loginInfo == null)
            {
                return View();
            }
            else
            {
                var claims = new List<Claim> {
                    new Claim( ClaimTypes.Name, admin.Username ),
                };

                var userIdentity = new ClaimsIdentity(claims, "Login");

                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIdentity);

                await HttpContext.SignInAsync(claimsPrincipal);

                return RedirectToAction("Index", "Category");
            }
        }
    }
}
