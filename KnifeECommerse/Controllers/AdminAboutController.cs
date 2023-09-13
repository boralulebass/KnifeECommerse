using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.Controllers
{
    [Authorize]
    public class AdminAboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AdminAboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var value = _aboutService.TGetByID(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(About about) 
        {
            _aboutService.TUpdate(about);
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public IActionResult About() 
        {
            var value =_aboutService.TGetByID(2);
            return View(value); 
        }
        [HttpPost]
        public IActionResult About(About about)
        {
            _aboutService.TUpdate(about);
            return RedirectToAction("Index");
        }
		[HttpGet]
		public IActionResult HomePhotos()
		{
			using var context = new Context();
			var values = context.HomePhotos.Where(x => x.HomePhotosID == 1).FirstOrDefault();
			return View(values);
		}
		[HttpPost]
		public IActionResult HomePhotos(HomePhotos homePhotos)
		{
			using var context = new Context();
			context.HomePhotos.Update(homePhotos);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
        [HttpGet]
        public IActionResult Reviews()
        {
            var value = _aboutService.TGetByID(3);
            return View(value);
        }
        [HttpPost]
        public IActionResult Reviews(About about)
        {
            _aboutService.TUpdate(about);
            return RedirectToAction("Index");
        }

    }
}
