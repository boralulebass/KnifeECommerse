using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.Controllers
{

	[AllowAnonymous]
	public class HomePageController : Controller
	{
		[Route("/")]
		public IActionResult Index()
		{
			return View();
		}


	}
}
