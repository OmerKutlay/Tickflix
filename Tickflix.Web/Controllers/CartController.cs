using Microsoft.AspNetCore.Mvc;
using Tickflix.Business.Abstract;
using Tickflix.Models;

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
        public IActionResult Add(Cart cart, List<CartItem> cartItems)
        {
            _cartService.Add(cart, cartItems);
            return Ok();
        }

        [HttpPost]
        public IActionResult Remove(int movieId)
        {
            _cartService.RemoveFromCart(movieId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Clear()
        {
            _cartService.ClearCart();
            return RedirectToAction("Index");
        }
    }
}