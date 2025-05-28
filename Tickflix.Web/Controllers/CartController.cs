using Microsoft.AspNetCore.Mvc;
using Tickflix.Business.Abstract;

namespace Tickflix.Web.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        public IActionResult Index()
        {
            var cart = _cartService.GetCart();
            ViewBag.Total = _cartService.GetCartTotal();
            return View(cart.Items);
        }

        [HttpPost]
        public IActionResult Add(int movieId, int quantity = 1)
        {
            _cartService.AddToCart(movieId, quantity);
            return RedirectToAction("Index");
    }

        [HttpPost]
        public IActionResult Remove(int movieId)
        {
            _cartService.RemoveFromCart(movieId);
            return RedirectToAction("Index");
}
