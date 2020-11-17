using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Championnat_Foot.Models;

namespace Championnat_Foot.Controllers
{
    public class StadeController : Controller
    {
        static championnatEntities ctx = new championnatEntities();
        // GET: Stade
        public ActionResult Index()
        {
            IList<Stade> listStades = ctx.Stades.ToList<Stade>();
            return View(listStades);
        }

        // GET: Stade/Details/5
        public ActionResult Details(string id)
        {
            Stade stade = ctx.Stades.Single(s => s.NomStd == id);
            return View(stade);
        }

        // GET: Stade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stade/Create
        [HttpPost]
        public ActionResult Create(Stade stadeCreated)
        {
            try
            {
                // TODO: Add insert logic here
                ctx.Stades.Add(stadeCreated);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stade/Edit/5
        public ActionResult Edit(string id)
        {
            Stade oldStade = ctx.Stades.Single(s => s.NomStd == id);
            return View(oldStade);
        }

        // POST: Stade/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Stade newStade)
        {
            try
            {
                // TODO: Add update logic here
                Stade oldStade = ctx.Stades.Single(s => s.NomStd == id);
                oldStade.Capacite = newStade.Capacite;
                oldStade.Adresse = newStade.Adresse;
                oldStade.Ville = newStade.Ville;
                oldStade.Peleuse = newStade.Peleuse;
                oldStade.Largeur = newStade.Largeur;
                oldStade.Longueur = newStade.Longueur;
                oldStade.Photo = newStade.Photo;
                
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stade/Delete/5
        public ActionResult Delete(string id)
        {
            Stade stadeDeleted = ctx.Stades.Single(s => s.NomStd == id);
            return View(stadeDeleted);
        }

        // POST: Stade/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Stade stadeDeleted = ctx.Stades.Single(s => s.NomStd == id);
                ctx.Stades.Remove(stadeDeleted);
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
