using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Championnat_Foot.Models;

namespace Championnat_Foot.Controllers
{
    public class EquipeController : Controller
    {
        static championnatEntities ctx = new championnatEntities();

        // GET: Equipe
        public ActionResult Index()
        {
            IList<Equipe> listEquipes = ctx.Equipes.ToList<Equipe>();
            return View(listEquipes);
        }

        // GET: Equipe/Details/5
        public ActionResult Details(string id)
        {
            Equipe equipe = ctx.Equipes.Single(e => e.NomEq == id);
            return View(equipe);
        }

        // GET: Equipe/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipe/Create
        [HttpPost]
        public ActionResult Create(Equipe equipeCreated)
        {
            try
            {
                // TODO: Add insert logic here
                ctx.Equipes.Add(equipeCreated);
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipe/Edit/5
        public ActionResult Edit(string id)
        {
            Equipe oldEquipe = ctx.Equipes.Single(e => e.NomEq == id);
            return View(oldEquipe);
        }

        // POST: Equipe/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, Equipe newEquipe)
        {
            try
            {
                // TODO: Add update logic here
                Equipe oldEquipe = ctx.Equipes.Single(e => e.NomEq == id);
                oldEquipe.AbreEq = newEquipe.AbreEq;
                oldEquipe.Adresse = newEquipe.Adresse;
                oldEquipe.Tel = newEquipe.Tel;
                oldEquipe.Ville = newEquipe.Ville;
                oldEquipe.Logo = newEquipe.Logo;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Equipe/Delete/5
        public ActionResult Delete(string id)
        {
            Equipe equipeDeleted = ctx.Equipes.Single(e => e.NomEq == id);
            return View(equipeDeleted);
        }

        // POST: Equipe/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Equipe equipeDeleted = ctx.Equipes.Single(e => e.NomEq == id);
                ctx.Equipes.Remove(equipeDeleted);
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
