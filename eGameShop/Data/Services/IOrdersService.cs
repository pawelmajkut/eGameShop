using eGameShop.Data.Base;
using eGameShop.Data.ViewModels;
using eGameShop.Models;

namespace eGameShop.Data.Services
{
    public interface IOrdersService
    {
        Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}
