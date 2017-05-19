using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;
using Website.Data;

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
            ViewBag.Information = "Hello my name is Javon I would like to know your name";

            return View(clothing);
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            //The reason why this should be static is because, there should ever only be one master list.
            var _clothing = Active1.getProduct();
                


            return View(_clothing);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}