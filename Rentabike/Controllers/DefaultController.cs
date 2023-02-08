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
    public class DefaultController : Controller
    {
        BikeManager bikeManager = new BikeManager(new EfBikeDal());
        ReserveBikeMessageManager reserveBikeMessageManager = new ReserveBikeMessageManager(new EfReserveBikeMessageDal());

        public IActionResult Index()
        {
            var values = bikeManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult BikeDetails(int id)
        {
            var values = bikeManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult BikeDetails(Bike p)
        {
            return View();
        }

        [HttpGet]
        public IActionResult BikeDetailsReserve()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BikeDetailsReserve(ReserveBikeMessage p)
        {
            p.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            reserveBikeMessageManager.TAdd(p);
            return RedirectToAction("Index", "Default");
        }

        
        
    }
}
