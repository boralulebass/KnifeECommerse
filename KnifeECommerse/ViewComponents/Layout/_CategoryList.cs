using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.Layout
{
    public class _CategoryList : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _CategoryList(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _categoryService.TGetList();
            return View(value);
        }
    }
}
