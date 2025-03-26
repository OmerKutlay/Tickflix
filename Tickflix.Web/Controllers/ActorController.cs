using Microsoft.AspNetCore.Mvc;
using Tickflix.Models;
using Tickflix.Business.Abstract;

namespace Tickflix.Web.Controllers
{
    public class ActorController : Controller
    {
        private readonly IActorService _actorService;

        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new { data = _actorService.GetAll() });
        }
        [HttpPost]
        public IActionResult Add(Actor actor)
        {
            return Ok(_actorService.Add(actor));
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_actorService.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(Actor actor)
        {
            return Ok(_actorService.Update(actor));
        }
        [HttpPost]
        public IActionResult Delete(Actor actor)
        {
            _actorService.Delete(actor);
            return Ok();
        }
    }
}
