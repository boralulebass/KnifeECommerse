using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.Category
{
    public class _ProductCategoryList : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _ProductCategoryList(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke(int id)
        {
            if (id > 0) 
            {
                var values1 = _categoryService.TGetList().Where(x => x.CategoryID == id).ToList();
                var cat = _categoryService.TGetByID(id);

                ViewBag.v = cat.CategoryName.ToString();
                ViewBag.id = cat.CategoryID;
                return View(values1);

            }
            else
            {
                var values = _categoryService.TGetList();
                return View(values);
            }

        }
    }
}
