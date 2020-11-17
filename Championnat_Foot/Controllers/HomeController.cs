using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Championnat_Foot.Models;

namespace Championnat_Foot.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult loadData()
        {
            using (championnatEntities db = new championnatEntities())
            {
                var data = db.Matchs.ToList();
                return Json(new { data = data }, JsonRequestBehavior.AllowGet);

            }

        }
    }
}