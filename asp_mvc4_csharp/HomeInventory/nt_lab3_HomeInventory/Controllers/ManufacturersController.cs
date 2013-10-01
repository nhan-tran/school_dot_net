using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using nt_lab3_HomeInventory.Models;

namespace nt_lab3_HomeInventory.Controllers
{
    public class ManufacturersController : Controller
    {
        private HomeInsDBContext db = new HomeInsDBContext();

        //
        // GET: /Manufacturers/

        public ActionResult Index()
        {
            return View(db.Manufacturers.ToList());
        }

        //
        // GET: /Manufacturers/Details/5

        public ActionResult Details(int id = 0)
        {
            Manufacturer manufacturer = db.Manufacturers.Find(id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }

        //
        // GET: /Manufacturers/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Manufacturers/Create

        [HttpPost]
        public ActionResult Create(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                db.Manufacturers.Add(manufacturer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manufacturer);
        }

        //
        // GET: /Manufacturers/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Manufacturer manufacturer = db.Manufacturers.Find(id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }

        //
        // POST: /Manufacturers/Edit/5

        [HttpPost]
        public ActionResult Edit(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manufacturer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manufacturer);
        }

        //
        // GET: /Manufacturers/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Manufacturer manufacturer = db.Manufacturers.Find(id);
            if (manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }

        //
        // POST: /Manufacturers/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Manufacturer manufacturer = db.Manufacturers.Find(id);
            db.Manufacturers.Remove(manufacturer);
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