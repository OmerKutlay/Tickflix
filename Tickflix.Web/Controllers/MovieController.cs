using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickflix.Business.Abstract;
using Tickflix.Models;

namespace Tickflix.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            return View(_movieService.GetAll()); 
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _movieService.GetAll() });
        }

        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            return Ok(_movieService.Add(movie));
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_movieService.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(Movie movie)
        {
            return Ok(_movieService.Update(movie));
        }
        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            _movieService.Delete(movie);
            return Ok();
        }

        public IActionResult Filter(string searchString)
        {
            var filteredMovies = _movieService.GetFilteredMovies(searchString);
            return View("Index", filteredMovies); // Arama sonuçlarını Index.cshtml'e gönderiyoruz
        }
    }

}

