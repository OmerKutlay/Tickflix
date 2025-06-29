using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Models;

namespace Tickflix.Business.Abstract
{
    public interface ICartItemService
    {
        List<CartItem> GetAllByCartId(int cartId);
        CartItem Add(CartItem cartItem);
        CartItem Update(CartItem cartItem);
        bool Delete(CartItem cartItem);
    }
}
