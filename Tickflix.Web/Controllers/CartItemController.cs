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

       
    }
