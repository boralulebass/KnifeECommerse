using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.HomePage
{
    public class _HomeCategory : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _HomeCategory(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var value1= _categoryService.TGetByID(3);
            var value4= _categoryService.TGetByID(4);
            var value2= _categoryService.TGetByID(5);
            var value3= _categoryService.TGetByID(6);
            ViewBag.Name1 = value1.CategoryName;
            ViewBag.Name2 = value2.CategoryName;
            ViewBag.Name3 = value3.CategoryName;
            ViewBag.Name4 = value4.CategoryName;
            return View();
        }
    }
}
