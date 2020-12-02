using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMapC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var cities = new List<City>();
            cities.Add(new City() { Title = "ซีคอนสแควร์+ศรีนครินทร์", Lat = 13.6924988,  Lng = 100.6456539 });
            cities.Add(new City() { Title = "อาคารมณียา", Lat = 13.7439874, Lng = 100.5404542 });
            cities.Add(new City() { Title = "(PTT)บางปลา", Lat = 13.5879816, Lng = 100.7393852 });
            return View(cities);
        }


         
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}