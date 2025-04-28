using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;

namespace PortfolioCore7.ViewComponents
{
    public class _DefaultTestimonialComponentPartial:ViewComponent
    {
        PortfolioContext context = new();
        public IViewComponentResult Invoke()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }
    }
}
