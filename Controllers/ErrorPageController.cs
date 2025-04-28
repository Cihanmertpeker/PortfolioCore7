using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore7.Controllers
{
    public class ErrorPageController : Controller
    {
       
        public ActionResult Page404()
        {
         
            return View();
        }
    }
}
