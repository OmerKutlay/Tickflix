using Microsoft.AspNetCore.Mvc;
using Tickflix.Business.Abstract;
using Tickflix.Models;

namespace Tickflix.Web.Controllers
{
    public class CartItemController : Controller
    {
        private readonly ICartItemService _cartItemService;

        public CartItemController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllByCartId(int cartId)
        {
            var cartItems = _cartItemService.GetAllByCartId(cartId);
            return Ok(cartItems);
        }

        [HttpPost]
        public IActionResult Add(CartItem cartItem)
        {
            return Ok(_cartItemService.Add(cartItem));
        }

        [HttpPost]
        public IActionResult Update(CartItem cartItem)
        {
            return Ok(_cartItemService.Update(cartItem));
        }

        [HttpPost]
        public IActionResult Delete(CartItem cartItem)
        {
            return Ok(_cartItemService.Delete(cartItem));
        }
        }
    }
