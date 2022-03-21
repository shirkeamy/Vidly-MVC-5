using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly_MVC.Models;
using Vidly_MVC.ViewModels;

namespace Vidly_MVC.Controllers
{
    public class MoviesController : Controller
    {

        ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m=>m.Genre).SingleOrDefault(c=>c.Id==id);
            return View(movie);
        }

        public ActionResult MoviesForm()
        {
            var viewModel = new RandomMovieViewModel
            {
                Movie=new Movies(),
                Genres=_context.Genres.ToList()
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(RandomMovieViewModel viewModel)
        {
            if (viewModel.Movie.Id == 0)
                _context.Movies.Add(viewModel.Movie);
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == viewModel.Movie.Id);
                movieInDb.Name = viewModel.Movie.Name;
                movieInDb.DateAdded = viewModel.Movie.DateAdded;
                movieInDb.ReleasedDate = viewModel.Movie.ReleasedDate;
                movieInDb.NumberInStock = viewModel.Movie.NumberInStock;
                movieInDb.GenreId = viewModel.Movie.GenreId;
            }

            _context.SaveChanges();

            return RedirectToAction("Index","Movies");
        }
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m=>m.Id==id);

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Genres=_context.Genres.ToList()
            };

            return View("MoviesForm",viewModel);
        }
    }
}