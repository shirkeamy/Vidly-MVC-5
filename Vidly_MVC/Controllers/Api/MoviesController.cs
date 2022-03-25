using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly_MVC.Models;

namespace Vidly_MVC.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetMovies()
        {
            var movies = _context.Movies.ToList();
            return Ok(movies);
        }

        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return NotFound();

            return Ok(movie);
        }

        [HttpPost]
        public IHttpActionResult CreateMovie(Movies movies)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Movies.Add(movies);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + movies.Id), movies);
        }

        [HttpPut]
        public IHttpActionResult UpdateMovie(int id,Movies movies)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null)
                return NotFound();

            movieInDb.Name = movies.Name;
            movieInDb.ReleasedDate = movies.ReleasedDate;
            movieInDb.NumberInStock = movies.NumberInStock;
            movieInDb.GenreId = movies.GenreId;

            _context.SaveChanges();

            return Ok(movies);
        }

        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return NotFound();
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return Ok(movie);
        }


    }
}
