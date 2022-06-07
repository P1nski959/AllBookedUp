using AllBookedUp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllBookedUp.Client.Services.CartService1
{
    public interface ICartService1
    {
        event Action OnChange;
        Task AddToCart(Product product);
        Task<List<CartItem>> GetCartItems();
        Task DeleteItem(CartItem item);
        Task EmptyCart();
        Task<string> Checkout();
    }
}
