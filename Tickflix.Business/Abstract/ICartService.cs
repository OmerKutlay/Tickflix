using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Models;

namespace Tickflix.Business.Abstract
{
    public interface ICartService
    {
        Cart GetCart();
        Cart Add(Cart cart, List<CartItem> cartItems);
        void RemoveFromCart(int movieId);
        void ClearCart();
        double GetCartTotal();
    }
}
