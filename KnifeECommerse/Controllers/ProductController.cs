using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using KnifeECommerse.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace KnifeECommerse.Controllers
{
    [AllowAnonymous]

    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IContactService _contactService;
        private readonly ICommentService _commentService;

        public ProductController(IProductService productService, IContactService contactService, ICommentService commentService)
        {
            _productService = productService;
            _contactService = contactService;
            _commentService = commentService;
        }

        [Route("/surmenebicaklari/{id?}")]
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                ViewBag.v = 0;
                return View(); }
            else { ViewBag.v = id; return View(); }

        }
		[Route("/surmenebicaklari/urundetaylari/{id}")]
		public IActionResult ProductDetail(int id)
        {
            var value = _productService.TGetByID(id);
            ViewBag.ProductId = value.ProductID;
            ViewBag.ProductName = value.ProductName;
            ViewBag.ProductDescription = value.ProductDescription;
            ViewBag.Img = value.ProductImg;
            CultureInfo trCulture = new CultureInfo("tr-TR");
            ViewBag.Price = value.ProductPrice.ToString("c", trCulture);
            if(value.ProductOldPrice > 0) 
            {
                ViewBag.OldPrice = value.ProductOldPrice.ToString("c", trCulture);
            }

            var phoneNumber = _contactService.TGetByID(1);
            ViewBag.PhoneNumber = phoneNumber.Phone;

            return View();
        }
        public IActionResult SearchedFor(string p)
        {
            ViewBag.p = p; 
            return View();
        }
        public IActionResult CheapToExp()
        {
            return View();
        }
        public IActionResult ExpToCheap()
        {
            return View();
        }


    }
}
