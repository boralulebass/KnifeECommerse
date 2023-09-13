using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace KnifeECommerse.ViewComponents.HomePage
{
	public class _HomeHeader : ViewComponent
	{
		private readonly IHomePageService _homePageService;

		public _HomeHeader(IHomePageService homePageService)
		{
			_homePageService = homePageService;
		}
		public IViewComponentResult Invoke()
		{
            using var context = new Context();
            var values = context.HomePhotos.Where(x => x.HomePhotosID == 1).FirstOrDefault();
            return View(values);
        }
	}
}
