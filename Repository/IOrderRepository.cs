using BethanyPieShop.Models;

namespace BethanyPieShop.Repository
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
