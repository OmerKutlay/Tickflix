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
        public IActionResult Index(string searchString)
        {
            var movies = _movieService.GetFilteredMovies(searchString);
            return View(movies);
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _movieService.GetAll() });
        }

        [HttpPost]
        public IActionResult Add(Movie movie, List<int> Actors)
        {
            return Ok(_movieService.Add(movie, Actors));
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            var movie = _movieService.GetById(id);

            if (movie == null)
                return NotFound();

            return Ok(new
            {
                movie.Id,
                movie.Name,
                movie.Description,
                movie.Price,
                movie.ImageURL,
                movie.StartDate,
                movie.EndDate,
                movie.MovieCategory,
                movie.CinemaId,
                movie.ProducerId,
                Actors = movie.Actors.Select(a => a.Id).ToList()
            });
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

        [HttpGet]
        public IActionResult Detail(int id)
        {
            return View(_movieService.GetById(id));
        }
    }

}

