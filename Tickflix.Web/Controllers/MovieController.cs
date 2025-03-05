using Microsoft.AspNetCore.Mvc;

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
        { var data = _context.Movies.ToList();
            return View();
        }
    }
}
