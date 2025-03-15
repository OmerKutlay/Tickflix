using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using Tickflix.Models;
using Tickflix.Repository.Shared.Abstract;

namespace Tickflix.Web.Controllers
{
    public class ActorController : Controller
    {
        private readonly IRepository<Actor> _actorService;

        public ActorController(IRepository<Actor> actorService)
        {
            _actorService = actorService;
        }

        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View(data);
        }
    }
}
