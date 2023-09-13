using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.About
{
    public class _AboutInfos: ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutInfos(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetByID(1);
            return View(values);
        }
    }
}
