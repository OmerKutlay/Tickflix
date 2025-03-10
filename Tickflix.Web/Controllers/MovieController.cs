using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Tickflix.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;

        public MovieController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        { 
            var allMovies = _context.Movies.Include(n => n.Cinema).ToList();
            return View(allMovies);
        }
    }
}
