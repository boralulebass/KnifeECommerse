using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.Layout
{
	public class _WhatsappDirection : ViewComponent
	{
		private readonly IContactService _contactService;

		public _WhatsappDirection(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IViewComponentResult Invoke()
		{
			var value =_contactService.TGetByID(1);
			return View(value);
		}
	}
}
