using Microsoft.AspNetCore.Mvc;
using Mission06_Hawkins.Models;
using SQLitePCL;
using System.Diagnostics;

namespace Mission06_Hawkins.Controllers
{
    public class HomeController : Controller
    {
        

        private MoviesContext _context;

        public HomeController(MoviesContext temp)
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovies()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(c => c.Category)
                .ToList();

            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(NewMovie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        public IActionResult MovieList()
        {
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();

            return View(movies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
