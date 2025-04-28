using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore7.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
