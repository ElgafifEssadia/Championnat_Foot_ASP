using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Championnat_Foot.Controllers
{
    public class MatchDataController : Controller
    {
        // GET: MatchData
        public ActionResult Index()
        {
            return View();
        }

        // GET: MatchData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MatchData/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MatchData/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MatchData/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MatchData/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MatchData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MatchData/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
