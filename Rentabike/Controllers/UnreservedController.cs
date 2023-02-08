using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rentabike.Controllers
{
    [AllowAnonymous]
    public class UnreservedController : Controller
    {
        BikeManager bikeManager = new BikeManager(new EfBikeDal());
        public IActionResult Index()
        {
            var values = bikeManager.GetListFalse();
            return View(values);
        }
    }
}
