using BethanyPieShop.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var pie_categories = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(pie_categories);
        }
    }
}
