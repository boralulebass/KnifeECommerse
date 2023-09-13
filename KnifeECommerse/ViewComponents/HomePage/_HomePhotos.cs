using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.HomePage
{
	public class _HomePhotos : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			using var context = new Context();
			var values = context.HomePhotos.Where(x => x.HomePhotosID == 1).FirstOrDefault();
			return View(values);
		}
	}
}
