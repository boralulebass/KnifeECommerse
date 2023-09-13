using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using KnifeECommerse.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using X.PagedList;

namespace KnifeECommerse.Controllers
{
    [Authorize]
    public class AdminProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public AdminProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index(int page = 1)
        {
            var values = _productService.TProductsIncluded().OrderBy(x=>x.ProductOrder).ToPagedList(page,8);  
            return View(values);

        }
        [HttpGet]
        public IActionResult AddProduct() 
        {
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product) 
        {
            product.ProductDate = DateTime.Now;
            _productService.TInsert(product);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetByID(id);
            _productService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditProduct(int id) 
        {
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = _productService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EditProduct(Product product)
        {

            _productService.TUpdate(product);
            return RedirectToAction("Index");
        }
    }
}
