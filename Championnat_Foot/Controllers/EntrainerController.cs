using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Championnat_Foot.Models;

namespace Championnat_Foot.Controllers
{
    public class EntrainerController : Controller
    {
        static championnatEntities ctx = new championnatEntities();
        // GET: Entrainer
        public ActionResult Index()
        {
            using (championnatEntities db = new championnatEntities())
            {
                List<Entrainer> entrainers = db.Entrainers.ToList();
                List<Entraineur> entraineurs = db.Entraineurs.ToList();
                List<Equipe> equipes = db.Equipes.ToList();
                List<Saison> saisons = db.Saisons.ToList();

                var entrainer = from en in entrainers
                                join e in entraineurs on en.codeent equals e.codeent into table1
                                from e in table1.ToList()
                                join eq in equipes on en.nomeq equals eq.NomEq into table2
                                from eq in table2.ToList()
                                join s in saisons on en.codesai equals s.CodeSai into table3
                                from s in table3.ToList()
                                select new ViewModel
                                {
                                    entrainer = en,
                                    entraineur = e,
                                    equipe = eq,
                                    saison = s
                                };


                return View(entrainer);
            }
        }

        // GET: Entrainer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Entrainer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entrainer/Create
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

        // GET: Entrainer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Entrainer/Edit/5
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

        // GET: Entrainer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Entrainer/Delete/5
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
