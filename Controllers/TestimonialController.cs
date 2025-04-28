using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;
using PortfolioCore7.Entities;

namespace PortfolioCore7.Controllers
{
    public class TestimonialController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult TestimonialList()
        {
            var values = context.Testimonials.ToList();
            return View(values);
        }

        public IActionResult AddTestimonial()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            context.Testimonials.Remove(value);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonials.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            context.Testimonials.Update(testimonial);
            context.SaveChanges();
            return RedirectToAction("TestimonialList");
        }
    }
}
