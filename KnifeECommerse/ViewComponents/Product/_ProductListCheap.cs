using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.Product
{
    public class _ProductListCheap : ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductListCheap(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TProductsIncluded().OrderBy(x => x.ProductPrice).ToList();
            return View(values);
        }
    }
}
