using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.Controllers
{
    [AllowAnonymous]

    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

		public AboutController(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}
		[Route("/hakkimizda")]
		public IActionResult Index()
        {
            return View();
        }
		[Route("/virasurmene")]
		public IActionResult Index2() 
        {
            return View();
        }
    }
}
