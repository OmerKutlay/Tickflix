using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using Tickflix.Models;
using Tickflix.Repository.Shared.Abstract;


namespace Tickflix.Web.Controllers
{
    public class CinemaController : Controller
    {
       private readonly IRepository<Cinema> _cinemaService;

        public CinemaController(IRepository<Cinema> cinemaService)
        {
            _cinemaService = cinemaService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            
            return Json(new { data = _cinemaService.GetAll() });
        }
        [HttpPost]
        public IActionResult Add(Cinema cinema)
        {
            return Ok(_cinemaService.Add(cinema));
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_cinemaService.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(Cinema cinema)
        {
            return Ok(_cinemaService.Update(cinema));
        }
        [HttpPost]
        public IActionResult Delete(Cinema cinema)
        {
            _cinemaService.Delete(cinema);
            return Ok();
        }
    }
}
