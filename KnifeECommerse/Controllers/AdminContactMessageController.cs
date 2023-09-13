using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace KnifeECommerse.Controllers
{
    [Authorize]
    public class AdminContactMessageController : Controller
    {
        private readonly IContactClientService _contactClientService;

        public AdminContactMessageController(IContactClientService contactClientService)
        {
            _contactClientService = contactClientService;
        }

        public IActionResult Index(int page = 1)
        {
            var values = _contactClientService.TGetList().OrderByDescending(x=>x.ContactClientID).ToPagedList(page, 10);
            return View(values);
        }
        public IActionResult DeleteContactMessage(int id) 
        {
            var value = _contactClientService.TGetByID(id);
            _contactClientService.TDelete(value);
            return RedirectToAction("Index");
        }
    }
}
