using Microsoft.AspNetCore.Mvc;

namespace Tickflix.Web.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
