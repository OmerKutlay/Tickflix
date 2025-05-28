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
        void AddToCart(int movieId, int quantity = 1);
        void RemoveFromCart(int movieId);
        void ClearCart();
        double GetCartTotal();
    }
}
