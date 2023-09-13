using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.Controllers
{
    [Authorize]
    public class AdminContactController : Controller
    {
        private readonly IContactService _contactService;

        public AdminContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet]
        public IActionResult Index()
        {
           var value = _contactService.TGetByID(1);
            return View(value);
        }
        [HttpPost]
        public IActionResult Index(Contact contact) 
        {
            _contactService.TUpdate(contact);
            return RedirectToAction("Index");
        }
    }
}
