using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tickflix.Business.Abstract;

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
            return View();
        }
    }
}
