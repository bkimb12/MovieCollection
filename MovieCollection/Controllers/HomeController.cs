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

            movieContext.Add(am);
            movieContext.SaveChanges();

            return View(am);
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var movies = movieContext.Responses
                .Include(x => x.Category)
                .ToList();

            return View(movies);
        }

    }
}
