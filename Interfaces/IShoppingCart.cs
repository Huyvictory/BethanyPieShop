using BethanyPieShop.Models;

namespace BethanyPieShop.Interfaces
{
    public interface IShoppingCart
    {
        void AddToCart(Pie pie);
        int RemoveFormCart(Pie pie);
        List<ShoppingCartItem> GetShoppingCartItems();
        void ClearCart();
        decimal GetShoppingCartTotal();
        List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
