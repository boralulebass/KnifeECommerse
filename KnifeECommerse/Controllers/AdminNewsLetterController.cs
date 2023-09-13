using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace KnifeECommerse.Controllers
{
    [Authorize]
    public class AdminNewsLetterController : Controller
    {
        private readonly INewsLetterService _newsLetterService;

        public AdminNewsLetterController(INewsLetterService newsLetterService)
        {
            _newsLetterService = newsLetterService;
        }

        public IActionResult Index(int page = 1)
        {
            var values = _newsLetterService.TGetList().OrderByDescending(x=>x.NewsLetterID).ToPagedList(page, 10);
            return View(values);
        }
        public IActionResult DeleteNewsLetter(int id) 
        {
            var value = _newsLetterService.TGetByID(id);
            _newsLetterService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
