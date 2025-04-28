using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolioCore7.Context;
using PortfolioCore7.Entities;

namespace PortfolioCore7.Controllers
{
    public class PortfolioController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult PortfolioList()
        {
            var values = context.Portfolios.Include(x => x.Category).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            var value = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName");
            ViewBag.Categories = value;
            return View();
        }

        [HttpPost]
        public IActionResult CreatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Add(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        [HttpGet]
        public IActionResult UpdatePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            var value2  = new SelectList(context.Categories.ToList(), "CategoryId", "CategoryName");
            ViewBag.updatedCategory = value2;
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio(Portfolio portfolio)
        {
            context.Portfolios.Update(portfolio);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }
    }
}
