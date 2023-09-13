using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.About
{
	public class _AboutInfos2 : ViewComponent
	{
		private readonly IAboutService _aboutService;

		public _AboutInfos2(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _aboutService.TGetByID(2);
			return View(values);
		}
	}
}
