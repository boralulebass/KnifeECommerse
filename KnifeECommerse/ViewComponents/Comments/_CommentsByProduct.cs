using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace KnifeECommerse.ViewComponents.Comments
{
    public class _CommentsByProduct : ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _CommentsByProduct(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke() 
        {
            var values = _aboutService.TGetByID(2);
            return View(values);
        }
    }
}
