using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore7.ViewComponents
{
    public class _DefaultHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
