using Microsoft.AspNetCore.Mvc;

namespace Tickflix.Web.Controllers
{
    public class CinemaController : Controller
    {
        private readonly AppDbContext _context;

        public CinemaController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Cinemas.ToList();
            return View();
        }
    }
}
