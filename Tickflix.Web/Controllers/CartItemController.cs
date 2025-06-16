using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Add(CartItemController item)
        {
            return Ok(_cartItemService.Add(item));
        }

        [HttpPost]
        public IActionResult Update(CartItemController item)
        {
            return Ok(_cartItemService.Update(item));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            return Ok(_cartItemService.Delete(id));
        }
    }
