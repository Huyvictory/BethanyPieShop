using BethanyPieShop.Models;

namespace BethanyPieShop.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
