using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;

namespace PortfolioCore7.ViewComponents
{
    public class _DefaultExperienceComponentPartial:ViewComponent
    {
      PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = context.Experiences.OrderByDescending(x=>x.ExperienceId).ToList();
            return View(values);
        }
    }
}
