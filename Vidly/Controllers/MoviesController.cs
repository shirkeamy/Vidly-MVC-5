using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            IEnumerable<Movie> movies = new List<Movie> {
                new Movie{ Id =1,Name = "Shrek!"},
                new Movie{ Id =2,Name = "Wall-e"},
                new Movie{ Id =3,Name = "Avengers"},
                new Movie{ Id =4,Name = "Spider-Man"},
            };

            return View(movies);

        }

        #region Practice
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek!" };
        //    //ViewData["Movie"] = movie;
        //    //ViewBag.Movie= movie;
        //    var customers = new List<Customer>
        //    {
        //        new Customer{ Name="Amol Shirke"},
        //        new Customer{ Name="Komal Shirke"},
        //        new Customer{ Name="Komal Amol"}
        //    };
        //    var randomMovies = new RandomMovieViewModel
        //    {
        //        Movie=movie,
        //        Customers=customers
        //    };
        //    return View(randomMovies);
        //}
        //public ActionResult Edit(int id)
        //{
        //    return Content("id= " + id);
        //}


        //[Route("movies/released/{year}/{month:regex(\\d(2)):range(1,12)}")]
        //public ActionResult RealeasedByYear(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        #endregion Practice

    }
}