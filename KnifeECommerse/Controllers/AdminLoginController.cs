using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace KnifeECommerse.Controllers
{
    public class AdminLoginController : Controller
    {
        private readonly IAdminService _adminService;

		public AdminLoginController(IAdminService adminService)
		{
			_adminService = adminService;
		}
        [AllowAnonymous]
		[HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(Admin admin)
        {
            using var context = new Context();
            var value = _adminService.TGetList();
            var datavalue = value.FirstOrDefault(x=>x.Username == admin.Username && x.Password == admin.Password);
            if (datavalue != null) 
            {
                var claims = new List<Claim>
                { new Claim(ClaimTypes.Name,admin.Username)};

                var userIdentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                return RedirectToAction("Index", "AdminProduct");
            }
            return View();
        }
        [Authorize]
        public async Task<IActionResult> LogoutAsync() 
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index","HomePage");
        }
    }
}
