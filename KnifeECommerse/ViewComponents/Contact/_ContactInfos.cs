using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.Contact
{
	public class _ContactInfos :ViewComponent
	{
		private readonly IContactService _contactService;

		public _ContactInfos(IContactService contactService)
		{
			_contactService = contactService;
		}

		public IViewComponentResult Invoke()
		{
			var value = _contactService.TGetByID(1);
			return View(value);
		}
	}
}
