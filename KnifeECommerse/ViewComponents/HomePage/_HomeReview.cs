using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.HomePage
{
    public class _HomeReview : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _HomeReview(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult  Invoke()
        {
            var values = _aboutService.TGetByID(3);
            return View(values);
        }
    }
}
