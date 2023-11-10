using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1_Q2.Models;

namespace Test1_Q2.Controllers
{
    public class MoviesController : Controller
    {
        MoviesDBEntities1 mv = new MoviesDBEntities1();
        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Movie name)
        {
            mv.Movie.Add(name);
            mv.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult ByDate()
        {
            var date = 01 / 01 / 1990;
            List<Movie> movies = from m in mv.Movie
                                 where m.DateOfRelease = date
                                 select mv.Movie;
            return View();                 
        }
    }
}