using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Championnat_Foot.Models;

namespace Championnat_Foot.Controllers
{
    public class EntraineurController : Controller
    {
        static championnatEntities ctx = new championnatEntities();
        // GET: Entraineur
        public ActionResult Index()
        {
            IList<Entraineur> listEntraineurs = ctx.Entraineurs.ToList<Entraineur>();
            return View(listEntraineurs);
        }

        // GET: Entraineur/Details/5
        public ActionResult Details(int id)
        {
            Entraineur entraineur = ctx.Entraineurs.Single(e => e.codeent == id);
            return View(entraineur);
        }

        // GET: Entraineur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entraineur/Create
        [HttpPost]
        public ActionResult Create(Entraineur entraineurCreated)
        {
            try
            {
                // TODO: Add insert logic here
                ctx.Entraineurs.Add(entraineurCreated);
                ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Entraineur/Edit/5
        public ActionResult Edit(int id)
        {
            Entraineur oldEntraineur = ctx.Entraineurs.Single(e => e.codeent == id);
            return View(oldEntraineur);
        }

        // POST: Entraineur/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Entraineur newEntraineur)
        {
            try
            {
                // TODO: Add update logic here
                Entraineur oldEntraineur = ctx.Entraineurs.Single(e => e.codeent == id);
                oldEntraineur.nom = newEntraineur.nom;
                oldEntraineur.prenom = newEntraineur.prenom;
                oldEntraineur.daten = newEntraineur.daten;
                oldEntraineur.nationnalite = newEntraineur.nationnalite;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Entraineur/Delete/5
        public ActionResult Delete(int id)
        {
            Entraineur entraineurDeleted = ctx.Entraineurs.Single(e => e.codeent == id);
            return View(entraineurDeleted);
        }

        // POST: Entraineur/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Entraineur entraineurDeleted = ctx.Entraineurs.Single(e => e.codeent == id);
                ctx.Entraineurs.Remove(entraineurDeleted);
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
