using BusinessLayer.Concrete;
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
    public class MessageController : Controller
    {
        MessageContactManager message = new MessageContactManager(new EfMessageContactDal());


        [HttpGet]
        public IActionResult CMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CMessage(MessageContact p)
        {
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            message.TAdd(p);
            return RedirectToAction("Index", "Contact");
        }
    }
}
