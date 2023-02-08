using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Rentabike.Areas.Admin.Controllers
{
    [AllowAnonymous]
    [Area("Admin")]
    public  class LoginController : Controller
    {
        LoginManager loginManager = new LoginManager(new EfLoginDal());
        public async Task<IActionResult> Index(Login p)
        {
            Context c = new Context();
            var datavalue = c.Logins.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);
            if (datavalue!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Username)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Bike");
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Home()
        {
            var values = loginManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult Settings(int id)
        {
            var values = loginManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Settings(Login p)
        {
            loginManager.TUpdate(p);
            return RedirectToAction("Index", "Login");

        }
    }
}
