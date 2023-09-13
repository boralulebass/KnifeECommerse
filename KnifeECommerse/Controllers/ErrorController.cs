using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.Controllers
{
    [AllowAnonymous]

    public class ErrorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
