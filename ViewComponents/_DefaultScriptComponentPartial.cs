using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore7.ViewComponents
{
    public class _DefaultScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
