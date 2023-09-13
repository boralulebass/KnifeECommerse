using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.Product
{
    public class _ProductListExpensive : ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductListExpensive(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TProductsIncluded().OrderByDescending(x => x.ProductPrice).ToList();
            return View(values);
        }
    }
}
