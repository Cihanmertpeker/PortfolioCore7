using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore7.ViewComponents
{
    public class _DefaultSidebarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
