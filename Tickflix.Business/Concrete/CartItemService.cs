using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Business.Abstract;
using Tickflix.Models;
using Tickflix.Repository.Shared.Abstract;

namespace Tickflix.Business.Concrete
{
    public class CartItemService : ICartItemService
    {
        private readonly IRepository<CartItem> _cartItemRepository;
        public CartItemService(IRepository<CartItem> cartItemRepository)
        {
            _cartItemRepository = cartItemRepository;
        }
        public CartItem Add(CartItem cartItem)
        {
            return _cartItemRepository.Add(cartItem);
        }

        public bool Delete(int id)
        {
            return _cartItemRepository.Delete(id);
        }

        public List<CartItem> GetAllByCartId(int cartId)
        {
           return _cartItemRepository.GetAll(ci => ci.CartId == cartId).ToList();
        }

        public CartItem Update(CartItem cartItem)
        {
            throw new NotImplementedException();
        }
    }
}
