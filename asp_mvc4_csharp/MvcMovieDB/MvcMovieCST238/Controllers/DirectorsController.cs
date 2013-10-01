using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovieCST238.Models;

namespace MvcMovieCST238.Controllers
{
    public class DirectorsController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        //
        // GET: /Director/

        public ActionResult Index()
        {
            return View(db.Directors.ToList());
        }

        //
        // GET: /Director/Details/5

        public ActionResult Details(int id = 0)
        {
            Director director = db.Directors.Find(id);
            if (director == null)
            {
                return HttpNotFound();
            }
            return View(director);
        }

        //
        // GET: /Director/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Director/Create

        [HttpPost]
        public ActionResult Create(Director director)
        {
            if (ModelState.IsValid)
            {
                db.Directors.Add(director);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(director);
        }

        //
        // GET: /Director/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Director director = db.Directors.Find(id);
            if (director == null)
            {
                return HttpNotFound();
            }
            return View(director);
        }

        //
        // POST: /Director/Edit/5

        [HttpPost]
        public ActionResult Edit(Director director)
        {
            if (ModelState.IsValid)
            {
                db.Entry(director).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(director);
        }

        //
        // GET: /Director/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Director director = db.Directors.Find(id);
            if (director == null)
            {
                return HttpNotFound();
            }
            return View(director);
        }

        //
        // POST: /Director/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Director director = db.Directors.Find(id);
            db.Directors.Remove(director);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}