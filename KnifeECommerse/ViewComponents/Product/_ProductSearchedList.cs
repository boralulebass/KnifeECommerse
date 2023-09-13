using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.Product
{
    public class _ProductSearchedList : ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductSearchedList(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(string p)
        {
            var values = _productService.TProductsIncluded().Where(x => x.ProductName.ToLower().Contains(p.ToLower())).ToList();
            return View(values);
        }
    }
}
