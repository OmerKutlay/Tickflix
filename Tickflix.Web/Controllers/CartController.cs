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
        public IActionResult Add(int movieId)
        {
            var cart = new Cart();
            var cartItems = new List<CartItem>
            {
                new CartItem
                {
                    MovieId = movieId,
                    Quantity = 1
                }
            };

            _cartService.Add(cart, cartItems);
            return Ok();
        }

        [HttpPost]
        public IActionResult Remove(int movieId)
        {
            _cartService.RemoveFromCart(movieId);
            return Ok();
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int movieId, int quantity)
        {
            var cart = _cartService.GetCart();
            var item = cart.Items.FirstOrDefault(i => i.MovieId == movieId);

            if (item == null)
                return NotFound();

            if (quantity <= 0)
            {
                _cartService.RemoveFromCart(movieId);
            }
            else
            {
                item.Quantity = quantity;
            }

            return Ok();
        }

        [HttpPost]
        public IActionResult Clear()
        {
            _cartService.ClearCart();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult GetCartTotal()
        {
            var total = _cartService.GetCartTotal();
            return Json(new { Total = total });
        }
    }
}