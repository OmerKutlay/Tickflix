using Microsoft.AspNetCore.Mvc;
using Tickflix.Business.Abstract;
using Tickflix.Models;

namespace Tickflix.Web.Controllers
{
    public class ProducerController : Controller
    {
        private readonly IProducerService _producerService;

        public ProducerController(IProducerService producerService)
        {
            _producerService = producerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            return Json(new { data = _producerService.GetAll() });
        }
        [HttpPost]
        public IActionResult Add(Producer producer)
        {
            return Ok(_producerService.Add(producer));
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return Ok(_producerService.GetById(id));
        }
        [HttpPost]
        public IActionResult Update(Producer producer)
        {
            return Ok(_producerService.Update(producer));
        }
        [HttpPost]
        public IActionResult Delete(Producer producer)
        {
            _producerService.Delete(producer);
            return Ok();
        }
    }
}
