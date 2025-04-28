using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;

namespace PortfolioCore7.ViewComponents
{
    public class _DefaultEducationComponentPartial:ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Educations.OrderByDescending(x=>x.EducationId).ToList();
            return View(values);
        }

    }
}
