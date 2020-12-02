using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using TCI_ProcessT.Models;

namespace TCI_ProcessT.Controllers
{
    public class HomeController : Controller
    {
        private Entities DbFile = new Entities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        public string GetDATASO(string BASE) //ข้อมูล P1 || P2
        {
            var dt= DateTime.UtcNow.Date.AddDays(-2);

            var Get = (from M_SO in DbFile.OESO
                       join M_CUSs in DbFile.ARMAS on M_SO.CUSCOD equals M_CUSs.cuscod into M_CUS1
                       from M_CUS in M_CUS1.DefaultIfEmpty()
                       where M_SO.SODAT >=dt
                       orderby M_SO.SONUM ascending
                       select new
                       {
                           M_SO.SONUM,
                           //M_SO.SODAT,
                           SODAT = SqlFunctions.Replicate("0", 2 - SqlFunctions.DateName("dd", M_SO.SODAT).Trim().Length) +
                                SqlFunctions.DateName("dd", M_SO.SODAT) +"/"+
                              //  SqlFunctions.Replicate("/", 2 - SqlFunctions.StringConvert((double)M_SO.SODAT.Value.Month).TrimStart().Length) +
                                SqlFunctions.Replicate("0", 2 - SqlFunctions.StringConvert((double)M_SO.SODAT.Value.Month).TrimStart().Length) +
                                SqlFunctions.StringConvert((double)M_SO.SODAT.Value.Month).TrimStart() +"/"+
                               // SqlFunctions.Replicate("/", 2 - SqlFunctions.StringConvert((double)M_SO.SODAT.Value.Month).TrimStart().Length) +
                                SqlFunctions.DateName("year", M_SO.SODAT).Trim(),
                           M_CUS.cusnam
                       }).ToList();
            string jsonlog = new JavaScriptSerializer().Serialize(Get);
            return jsonlog;
            //   return View();
        } 
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}