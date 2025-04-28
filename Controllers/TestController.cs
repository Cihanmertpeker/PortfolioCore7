using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore7.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
