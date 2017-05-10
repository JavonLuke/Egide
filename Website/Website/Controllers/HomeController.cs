using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var clothing = new Clothing()
            {
                Id = 1,
                Name = "First Clothing",
                Size = "Extra Large"
            };

            return View(clothing);
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            //The reason why this should be static is because, there should ever only be one master list.
            var _clothing = new Clothing[]
            {
                new Clothing()
                {
                    Id = 1,
                    Name = "First Clothing",
                    Size = "Extra Large"
                },
                  new Clothing()
                {
                    Id = 2,
                    Name = "Second Clothing",
                    Size = "Extra Large"
                }

            };
           


            return View(_clothing);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}