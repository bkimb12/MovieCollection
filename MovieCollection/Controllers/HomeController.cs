using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MovieCollection.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Controllers
{
    public class HomeController : Controller
    {
        private MovieDatabaseContext movieContext { get; set; }

        public HomeController(MovieDatabaseContext someName)
        {
            movieContext = someName;
        }

        //home page
        public IActionResult Index()
        {
            return View();
        }

        //podcast page
        public IActionResult Podcasts()
        {
            return View();
        }

        //get for add movie page
        [HttpGet]
        public IActionResult AddMovie()
        {
            ViewBag.Categorys = movieContext.Categorys.ToList();

            return View(); 
        }

        //post for add movie page
        [HttpPost]
        public IActionResult AddMovie (AddMovie am)
        {
            ViewBag.Categorys = movieContext.Categorys.ToList();

            if (ModelState.IsValid)
            {
                movieContext.Add(am);
                movieContext.SaveChanges();

                return View(am);
            }
            else
            {
                ViewBag.Categorys = movieContext.Categorys.ToList();

                return View();
            }
        }
        //movie list get
        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = movieContext.Responses
                .Include(x => x.Category)
                .ToList();

            return View(movies);
        }
        //edit get
        [HttpGet]
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categorys = movieContext.Categorys.ToList();

            var EditMovie = movieContext.Responses.Single(x => x.MovieID == movieid);

            return View("AddMovie", EditMovie);
        }
        //edit post
        [HttpPost]
        public IActionResult Edit (AddMovie am)
        {
            movieContext.Update(am);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
        //delete get
        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var DeleteMovie = movieContext.Responses.Single(x => x.MovieID == movieid);

            return View(DeleteMovie);
        }
        //delete post
        [HttpPost]
        public IActionResult Delete (AddMovie am)
        {
            movieContext.Responses.Remove(am);
            movieContext.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
