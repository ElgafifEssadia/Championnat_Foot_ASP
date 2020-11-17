using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Championnat_Foot.Models;

namespace Championnat_Foot.Controllers
{
    public class SaisonController : Controller
    {
        static championnatEntities ctx = new championnatEntities();
        // GET: Saison
        public ActionResult Index()
        {
            IList<Saison> listSaisons = ctx.Saisons.ToList<Saison>();
            return View(listSaisons);
        }

        // GET: Saison/Details/5
        public ActionResult Details(string id)
        {
            Saison saison = ctx.Saisons.Single(s => s.CodeSai == id);
            return View(saison);
        }

        // GET: Saison/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Saison/Create
        [HttpPost]
        public ActionResult Create(Saison saisonCreated)
        {
            try
            {
                // TODO: Add insert logic here
                ctx.Saisons.Add(saisonCreated);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Saison/Edit/5
        public ActionResult Edit(string id)
        {
            Saison oldSaison = ctx.Saisons.Single(s => s.CodeSai == id);
            return View(oldSaison);
        }

        // POST: Saison/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Saison newSaison)
        {
            try
            {
                // TODO: Add update logic here
                Saison oldSaison = ctx.Saisons.Single(s => s.CodeSai == id);
                oldSaison.CodeSai = newSaison.CodeSai;
                
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Saison/Delete/5
        public ActionResult Delete(string id)
        {
            Saison saisonDeleted = ctx.Saisons.Single(s => s.CodeSai == id);
            return View(saisonDeleted);
        }

        // POST: Saison/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Saison saisonDeleted = ctx.Saisons.Single(s => s.CodeSai == id);
                ctx.Saisons.Remove(saisonDeleted);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
