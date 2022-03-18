using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_MVC.Models;

namespace Vidly_MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }


        private IEnumerable<Movies> GetMovies()
        {
            var movies = new List<Movies>
            {
                new Movies{ Id=1,Name="Mahabharat"},
                new Movies{ Id=2,Name="Mahadev"},
            };

            return movies;

        }


    }
}