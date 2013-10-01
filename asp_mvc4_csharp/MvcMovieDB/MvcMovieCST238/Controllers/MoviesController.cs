using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovieCST238.Models;
using MvcMovieCST238.ViewModels;

namespace MvcMovieCST238.Controllers
{
    public class MoviesController : Controller
    {
        private MovieDBContext db = new MovieDBContext();
        public static List<Movie> OriginalMovies = new List<Movie>();
        private static Boolean flg = true;


        public MoviesController()
        {
            //flg to only set StoreMovies on first entry of MoviesController
            if (flg) 
            {
                StoreMovies();
                flg = false;            
            }
        }

        public void StoreMovies()
        { 
            OriginalMovies = db.Movies.ToList();
            //RestoreMovies();
        }

        public ActionResult RestoreMovies()
        { 
            //current db set of original moves
            var OrigList = OriginalMovies;
            
            foreach (var o in OrigList)
            {
                var movie = db.Movies.Where(a => a.ID == o.ID).FirstOrDefault();

                //if movie still exist in db
                if (movie != null)
                {
                //movie.ID = o.ID;
                movie.Price = o.Price;
                movie.Rating = o.Rating;
                movie.ReleaseDate = o.ReleaseDate;
                movie.Title = o.Title;
                movie.Genre = o.Genre;
                movie.DirectorID = o.DirectorID;

                db.SaveChanges();
                }
            }
            return RedirectToAction("MovieInfo", "Movies");    
        }


        

        //
        // GET: /Movies/

        public ActionResult Index()
        {
            //MovieList = db.Movies.ToList();
            
            return View(db.Movies.ToList());
        }

        public ActionResult Modify()
        {
            return View(db.Movies.ToList());
        }

        private IEnumerable<Movie> ViewData(string p)
        {
            throw new NotImplementedException();
        }

        //
        // GET: /Movies/Details/5

        public ActionResult Details(int id = 0)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // GET: /Movies/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Movies/Create

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        //
        // GET: /Movies/Create

        public ActionResult CreateMovie()
        {
            return View();
        }

        //
        // POST: /Movies/Create

        [HttpPost]
        public ActionResult CreateMovie(MovieInfoViewModel movieInfo)
        {
            Movie movie = movieInfo.Movies[0];
            Director director = movieInfo.Directors[0];
            

            if (ModelState.IsValid)
            {
                db.Directors.Add(director);

                var lastID = db.Directors.Max(z => z.ID);

                movie.DirectorID = lastID + 1;

                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("MovieInfo");
            }

            return View(movie);
        }

        //
        // GET: /Movies/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // POST: /Movies/Edit/5

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("MovieInfo");
            }
            return View(movie);
        }

        //
        // GET: /Movies/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        //
        // POST: /Movies/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("MovieInfo");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        public ActionResult SearchIndex(string movieGenre, string searchString)
        {
            var GenreLst = new List<string>();

            var GenreQry = from d in db.Movies
                           orderby d.Genre
                           select d.Genre;
            GenreLst.AddRange(GenreQry.Distinct());
            ViewBag.movieGenre = new SelectList(GenreLst);

            var movies = from m in db.Movies
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString));
            }

            if (string.IsNullOrEmpty(movieGenre))
                return View(movies);
            else
            {
                return View(movies.Where(x => x.Genre == movieGenre));
            }

        }


        //Controls the 'Main' page which shows the view model of MovieInfo
        public ActionResult MovieInfo()
        {
            var viewModel = new ViewModels.MovieInfoViewModel();

            viewModel.Movies = db.Movies.ToList();
            viewModel.Directors = db.Directors.ToList();

            return View(viewModel);
        }

    }
}