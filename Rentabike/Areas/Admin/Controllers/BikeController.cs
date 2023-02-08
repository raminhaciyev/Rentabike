using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Rentabike.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Rentabike.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BikeController : Controller
    {
        BikeManager bikeManager = new BikeManager(new EfBikeDal());

        public IActionResult Index()
        {
            var values = bikeManager.TGetList();
            return View(values);

        }

        [HttpGet]
        public IActionResult AddBike()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBike(AddBikeImage p)
        {
            Bike b = new Bike();
            if (p.Image!=null)
            {
                var extension = Path.GetExtension(p.Image.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/hmarthtml-10/hmart/assets/images/product-image/", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                p.Image.CopyTo(stream);
                b.Image = newimagename;
            }
            b.Category = p.Category;
            b.Title = p.Title;
            b.Description = p.Description;
            b.Status = p.Status;
            b.Rules = p.Rules;
            b.Requirements = p.Requirements;
            b.Material = p.Material;
            b.Dimensions = p.Dimensions;
            b.Weight = p.Weight;
            b.Price = p.Price;
            bikeManager.TAdd(b);
            return RedirectToAction("Index", "Bike");
        }


        public IActionResult DeleteBike(int id)
        {
            var values = bikeManager.TGetById(id);
            bikeManager.DeleteTrue(values);
            return RedirectToAction("Index", "Bike");
        }

        public IActionResult RemoveBike(int id)
        {
            var values = bikeManager.TGetById(id);
            bikeManager.TDelete(values);
            return RedirectToAction("Index", "Bike");
        }



        [HttpGet]
        public IActionResult UpdateBike(int id)
        {
            var values = bikeManager.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateBike(Bike p)
        {
            bikeManager.TUpdate(p);
            return RedirectToAction("Index", "Bike");
        }

    }
}
