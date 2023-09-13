using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace KnifeECommerse.Controllers
{
    [Authorize]
    public class AdminBestSellersController : Controller
    {
        private readonly IBestSellerService _bestSellerService;
        private readonly IProductService _productService;

        public AdminBestSellersController(IBestSellerService bestSellerService, IProductService productService)
        {
            _bestSellerService = bestSellerService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            var values = _bestSellerService.IncludedBestSellers().OrderByDescending(x => x.BestSellerID).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddBestSeller() 
        {
            List<SelectListItem> values = (from x in _productService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.ProductName,
                                               Value = x.ProductID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public IActionResult AddBestSeller(BestSeller bestSeller) 
        {
            _bestSellerService.TInsert(bestSeller);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteBestSeller(int id) 
        {
           var value = _bestSellerService.TGetByID(id);
            _bestSellerService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
