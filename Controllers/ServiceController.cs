using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;
using PortfolioCore7.Entities;

namespace PortfolioCore7.Controllers
{
    public class ServiceController : Controller
    {
        PortfolioContext _context = new PortfolioContext();
        public IActionResult ServiceList()
        {
            var values = _context.Services.ToList();
            return View(values);
        }

        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public IActionResult DeleteService(int id)
        {
            var value = _context.Services.Find(id);
            _context.Services.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ServiceList");
        }

        public IActionResult UpdateService(int id)
        {
            var value = _context.Services.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
            return RedirectToAction("ServiceList");
        }
    }
}
