﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1_Q2.Models;

namespace Test1_Q2.Controllers
{
    public class MoviesController : Controller
    {
        private MovieContext mv=new MovieContext();
        
        // GET: Movies
        public ActionResult Index()
        {           
            return View(mv.Movies.ToList());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            mv.Movies.Add(movie);
            mv.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var movie = mv.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            mv.Entry(movie).State = EntityState.Modified;
            mv.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var movie = mv.Movies.Find(id);
            mv.Movies.Remove(movie);
            mv.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ByYear(int year)
        {
            var movies = mv.Movies.Where(m => m.Date_of_Release.Year == year).ToList();
            return View(movies);
        }
    }
}