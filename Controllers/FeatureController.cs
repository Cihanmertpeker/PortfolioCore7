using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;
using PortfolioCore7.Entities;

namespace PortfolioCore7.Controllers
{
    public class FeatureController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult FeatureList()
        {
            var values = context.Features.ToList();
            return View(values);
        }

        public IActionResult FeatureDelete(int id)
        {
            var values = context.Features.Find(id);
            context.Features.Remove(values);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        public IActionResult CreateFeature()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateFeature(Feature feature)
        {
            context.Features.Add(feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }

        public IActionResult UpdateFeature(int id)
        {
            var values = context.Features.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            context.Features.Update(feature);
            context.SaveChanges();
            return RedirectToAction("FeatureList");
        }
        
    }
}
