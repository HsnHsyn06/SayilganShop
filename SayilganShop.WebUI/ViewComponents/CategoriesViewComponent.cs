using Microsoft.AspNetCore.Mvc;
using SayilganShop.Business.Services;
using SayilganShop.WebUI.Models;

namespace SayilganShop.WebUI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {

            var categoriesDtos = _categoryService.GetCategories();

            var viewModel = categoriesDtos.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();

            return View(viewModel);
        }

    }
}
