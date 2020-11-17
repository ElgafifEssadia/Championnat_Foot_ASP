using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Championnat_Foot.Models;

namespace Championnat_Foot.Controllers
{
    public class ArbitrageController : Controller
    {
        static championnatEntities ctx = new championnatEntities();
        // GET: Arbitrage
        public ActionResult Index()
        {
             
            return View();
        }

        // GET: Arbitrage/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Arbitrage/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arbitrage/Create
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

        // GET: Arbitrage/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Arbitrage/Edit/5
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

        // GET: Arbitrage/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Arbitrage/Delete/5
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
