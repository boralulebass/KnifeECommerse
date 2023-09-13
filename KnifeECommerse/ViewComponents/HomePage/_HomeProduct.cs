using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.HomePage
{
	public class _HomeProduct : ViewComponent
	{
		private readonly IBestSellerService _bestSellerService;

		public _HomeProduct(IBestSellerService bestSellerService)
		{
			_bestSellerService = bestSellerService;
		}

		public IViewComponentResult Invoke()
		{
			var values = _bestSellerService.IncludedBestSellers();
			return View(values);
		}
	}
}
