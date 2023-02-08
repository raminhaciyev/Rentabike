using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace Rentabike.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        MessageContactManager message = new MessageContactManager(new EfMessageContactDal());
        public IActionResult Index(int page=1)
        {
            var values = message.TGetList();
            var a = values.OrderByDescending(x=>x.MessageId).ToPagedList(page, 2);
            return View(a);
        }

        public IActionResult GoToMessage(int id)
        {
            var value = message.TGetById(id);
            return View(value);
        }
    }
}
