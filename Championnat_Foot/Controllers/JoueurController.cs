using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Championnat_Foot.Models;

namespace Championnat_Foot.Controllers
{
    public class JoueurController : Controller
    {
        static championnatEntities ctx = new championnatEntities();
        // GET: Joueur
        public ActionResult Index()
        {
            IList<Joueur> listJoueurs = ctx.Joueurs.ToList<Joueur>();
            return View(listJoueurs);
        }

        // GET: Joueur/Details/5
        public ActionResult Details(int id)
        {
            Joueur joueur = ctx.Joueurs.Single(j => j.CodeJou == id);
            return View(joueur);
        }

        // GET: Joueur/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Joueur/Create
        [HttpPost]
        public ActionResult Create(Joueur joueurCreated)
        {
            try
            {
                // TODO: Add insert logic here
                ctx.Joueurs.Add(joueurCreated);
                ctx.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Joueur/Edit/5
        public ActionResult Edit(int id)
        {
            Joueur oldJoueur = ctx.Joueurs.Single(j => j.CodeJou == id);
            return View(oldJoueur);
        }

        // POST: Joueur/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Joueur newJoueur)
        {
            try
            {
                // TODO: Add update logic here
                Joueur oldJoueur = ctx.Joueurs.Single(j => j.CodeJou == id);
                oldJoueur.Nom = newJoueur.Nom;
                oldJoueur.Prenom = newJoueur.Prenom;
                oldJoueur.Poste = newJoueur.Poste;
                oldJoueur.Nationalite = newJoueur.Nationalite;
                ctx.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Joueur/Delete/5
        public ActionResult Delete(int id)
        {
            Joueur joueurDeleted = ctx.Joueurs.Single(j => j.CodeJou == id);
            return View(joueurDeleted);
        }

        // POST: Joueur/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                Joueur joueurDeleted = ctx.Joueurs.Single(j => j.CodeJou == id);
                ctx.Joueurs.Remove(joueurDeleted);
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
