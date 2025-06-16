using System.Linq;
using Tickflix.Business.Abstract;
using Tickflix.Models;
using Tickflix.Repository.Shared.Abstract;

namespace Tickflix.Business.Concrete
{
    public class CartService : ICartService
    {
        private readonly IRepository<Movie> _movieRepository;
        private static Cart _cart = new Cart();

        public CartService(IRepository<Movie> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Cart GetCart()
        {
            return _cart;
        }

        public void Add(Cart cart, List<CartItem> cartItems)
        {
            if (cart == null || cartItems == null || !cartItems.Any())
            {
                return;
            }
            foreach (var item in cartItems)
            {
                var existingItem = _cart.Items.FirstOrDefault(i => i.MovieId == item.MovieId);
                if (existingItem != null)
            {
                    existingItem.Quantity += item.Quantity;
            }
            else
            {
                    var movie = _movieRepository.GetById(item.MovieId);
                if (movie != null)
                {
                    _cart.Items.Add(new CartItem
                    {
                            MovieId = item.MovieId,
                        Movie = movie,
                            Quantity = item.Quantity
                    });
                }
            }
        }
        }

        public void RemoveFromCart(int movieId)
        {
            var item = _cart.Items.FirstOrDefault(i => i.MovieId == movieId);
            if (item != null)
            {
                _cart.Items.Remove(item);
            }
        }

        public void ClearCart()
        {
            _cart.Items.Clear();
        }

        public double GetCartTotal()
        {
            return _cart.Items.Sum(i => i.Movie.Price * i.Quantity);
        }
    }
}