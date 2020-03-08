using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidlee.Models;

namespace Vidlee.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }
        private List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1,  Name = "Sherk"},
                new Movie {Id = 2, Name = "wall-e"}
            };
        }
    }
}