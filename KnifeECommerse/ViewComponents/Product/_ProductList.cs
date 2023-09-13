using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace KnifeECommerse.ViewComponents.Product
{
    public class _ProductList : ViewComponent
    {
        private readonly IProductService _productService;

        public _ProductList(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke(int id)
        {
            if (id == 0) 
            {
            var values = _productService.TProductsIncluded().OrderBy(x=>x.ProductOrder).ToList();
            return View(values);
            }
            else
            {
                var values = _productService.TProductsIncluded().OrderBy(x => x.ProductOrder).Where(x => x.CategoryID == id).ToList();
                return View(values);
            }
        }
    }
}
