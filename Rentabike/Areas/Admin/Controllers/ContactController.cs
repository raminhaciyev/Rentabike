using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rentabike.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            var values = contactManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var values = contactManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact p)
        {
            contactManager.TUpdate(p);
            return RedirectToAction("Index", "Contact");
        }
    }
}
