using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;

namespace PortfolioCore7.ViewComponents
{
    public class _DefaultStatisticsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.testimonialCount = context.Testimonials.Count();
            ViewBag.portfolioCount = context.Portfolios.Count();
            ViewBag.skillCount = context.Skills.Count();

            Random random = new Random();

            int randomStats = random.Next(10, 21);

            ViewBag.randomCount = randomStats;

            return View();
        }
    }
}
