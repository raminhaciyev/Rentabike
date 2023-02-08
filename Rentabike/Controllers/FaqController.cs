using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rentabike.Controllers
{
    [AllowAnonymous]
    public class FaqController : Controller
    {
        FaqManager faqManager = new FaqManager(new EfFaqDal());
        public IActionResult Index()
        {
            var values = faqManager.TGetList();
            return View(values);
        }
    }
}
