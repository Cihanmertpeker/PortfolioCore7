using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;

namespace PortfolioCore7.ViewComponents
{
    public class _DefaultServiceComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Services.Take(6).ToList();
            return View(values);
        }
    }
}
