using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using KnifeECommerse.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.Controllers
{
    [AllowAnonymous]

    public class LayoutController : Controller
    {
        private readonly INewsLetterService _letterService;
        private readonly ICategoryService _categoryService;
		public LayoutController(INewsLetterService letterService, ICategoryService categoryService)
		{
			_letterService = letterService;
			_categoryService = categoryService;
		}

		public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Subscribe() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Subscribe(NewsLetter newsLetter)
        {
            _letterService.TInsert(newsLetter);
            return RedirectToAction("Index","HomePage");
        }
        [HttpGet]
        public IActionResult CategoryList() 
        {
            var value = _categoryService.TGetList();
            return View(value);
        }
        [HttpGet]
        public PartialViewResult SearchButton()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SearchButton(SearchModel model)
        {
            string p = model.p;
            return RedirectToAction("SearchedFor","Product", new {p = p});
        }
    }
}
