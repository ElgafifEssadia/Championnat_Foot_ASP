using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Championnat_Foot.Models;

namespace Championnat_Foot.Controllers
{
    public class MatchsController : Controller
    {
        static championnatEntities ctx = new championnatEntities();
        // GET: Matchs
        public ActionResult Index()
        {
            using (championnatEntities db = new championnatEntities())
            {
                List<Match> matchs = db.Matchs.ToList();
                List<Equipe> equipes = db.Equipes.ToList();
                List<Stade> stades = db.Stades.ToList();
                
                var match = from m in matchs
                                join e in equipes on m.NomEqDom equals e.NomEq into table1
                                from e in table1.ToList()
                                join eq in equipes on m.NomEqVis equals eq.NomEq into table2
                                from eq in table2.ToList()
                                join s in stades on m.nomStd equals s.NomStd into table3
                                from s in table3.ToList()
                                select new ViewModel
                                {
                                    match = m,
                                    equipe = e,
                                    equipe1 = eq,
                                    stade = s
                                };


                return View(match);
            }
        }

        // GET: Matchs/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Matchs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Matchs/Create
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

        // GET: Matchs/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Matchs/Edit/5
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

        // GET: Matchs/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Matchs/Delete/5
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
