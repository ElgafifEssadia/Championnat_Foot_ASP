using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Championnat_Foot.Models;

namespace Championnat_Foot.Controllers
{
    public class ArbitreController : Controller
    {
        static championnatEntities ctx = new championnatEntities();
        // GET: Arbitre
        public ActionResult Index()
        {
            IList<Arbitre> listArbitres = ctx.Arbitres.ToList<Arbitre>();
            return View(listArbitres);
        }

        // GET: Arbitre/Details/5
        public ActionResult Details(int id)
        {
            Arbitre arbitre = ctx.Arbitres.Single(a => a.codearb == id);
            return View(arbitre);
        }

        // GET: Arbitre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Arbitre/Create
        [HttpPost]
        public ActionResult Create(Arbitre arbitreCreated)
        {
            try
            {
                // TODO: Add insert logic here
                ctx.Arbitres.Add(arbitreCreated);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Arbitre/Edit/5
        public ActionResult Edit(int id)
        {
            Arbitre oldArbitre = ctx.Arbitres.Single(a => a.codearb == id);
            return View(oldArbitre);
        }

        // POST: Arbitre/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Arbitre newArbitre)
        {
            try
            {
                // TODO: Add update logic here
                Arbitre oldArbitre = ctx.Arbitres.Single(a => a.codearb == id);
                oldArbitre.nom = newArbitre.nom;
                oldArbitre.prenom = newArbitre.prenom;
                oldArbitre.daten = newArbitre.daten;
                oldArbitre.nationalite = newArbitre.nationalite;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Arbitre/Delete/5
        public ActionResult Delete(int id)
        {
            Arbitre arbitreDeleted = ctx.Arbitres.Single(a => a.codearb == id);
            return View(arbitreDeleted);
        }

        // POST: Arbitre/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Arbitre arbitreDeleted = ctx.Arbitres.Single(a => a.codearb == id);
                ctx.Arbitres.Remove(arbitreDeleted);
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
