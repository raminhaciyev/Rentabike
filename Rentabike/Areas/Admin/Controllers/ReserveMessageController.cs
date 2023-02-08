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
    public class ReserveMessageController : Controller
    {
        ReserveBikeMessageManager reserveBikeMessageManager = new ReserveBikeMessageManager(new EfReserveBikeMessageDal());
        public IActionResult Index(int page=1)
        {
            var values = reserveBikeMessageManager.TGetListMessageWithBike();
            var a = values.OrderByDescending(x => x.MessageId).ToPagedList(page, 2);
            return View(a);
        }

        public IActionResult GoToMessage(int id)
        {
            var value = reserveBikeMessageManager.TGetById(id);
            return View(value);
        }

    }
}
