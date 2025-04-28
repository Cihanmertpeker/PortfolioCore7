using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;

namespace PortfolioCore7.ViewComponents
{
    public class _DefaultCategoryComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Categories.ToList();
            return View(values);
        }
    }
}
