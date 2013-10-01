using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovieCST238.Models;
using MvcMovieCST238.ViewModels;


namespace MvcMovieCST238.Controllers
{
    public class FullMovieInfoController : Controller
    {

        private MovieDBContext db = new MovieDBContext();
        //
        // GET: /FullMovieInfo/

        public ActionResult Index()
        {
            var viewModel = new ViewModels.FullMovieInfoViewModel();
            
            return View();
        }

        //
        // GET: /FullMovieInfo/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /FullMovieInfo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FullMovieInfo/Create

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

        //
        // GET: /FullMovieInfo/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /FullMovieInfo/Edit/5

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

        //
        // GET: /FullMovieInfo/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /FullMovieInfo/Delete/5

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
