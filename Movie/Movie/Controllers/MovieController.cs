using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Movie.Models;

namespace Movie.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Movies()
        {
            var movies = new List<Movie>
            {
                new Movie
            };
            return View(movies);
        }
    }
}