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
    public class PoliciesController : Controller
    {
        private HomeInsDBContext db = new HomeInsDBContext();

        //
        // GET: /Policies/

        public ActionResult Index()
        {
            return View(db.Policies.ToList());
        }

        //
        // GET: /Policies/Details/5

        public ActionResult Details(int id = 0)
        {
            Policy policy = db.Policies.Find(id);
            if (policy == null)
            {
                return HttpNotFound();
            }
            return View(policy);
        }

        //
        // GET: /Policies/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Policies/Create

        [HttpPost]
        public ActionResult Create(Policy policy)
        {
            if (ModelState.IsValid)
            {
                db.Policies.Add(policy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(policy);
        }

        //
        // GET: /Policies/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Policy policy = db.Policies.Find(id);
            if (policy == null)
            {
                return HttpNotFound();
            }
            return View(policy);
        }

        //
        // POST: /Policies/Edit/5

        [HttpPost]
        public ActionResult Edit(Policy policy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(policy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(policy);
        }

        //
        // GET: /Policies/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Policy policy = db.Policies.Find(id);
            if (policy == null)
            {
                return HttpNotFound();
            }
            return View(policy);
        }

        //
        // POST: /Policies/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Policy policy = db.Policies.Find(id);
            db.Policies.Remove(policy);
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