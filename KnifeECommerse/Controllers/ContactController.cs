using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.Controllers
{
    [AllowAnonymous]

    public class ContactController : Controller
	{
		private readonly IContactService _contactService;
		private readonly IContactClientService _contactClientService;

		public ContactController(IContactService contactService, IContactClientService contactClientService)
		{
			_contactService = contactService;
			_contactClientService = contactClientService;
		}
		[Route("/iletisim")]
		public IActionResult Index()
		{
			
			return View();
		}
		[HttpGet]
		public IActionResult Contact()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Contact(ContactClient contact)
		{
			_contactClientService.TInsert(contact);
			return RedirectToAction("Index"); 
		}
	}
}
