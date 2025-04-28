using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;
using PortfolioCore7.Entities;

namespace PortfolioCore7.ViewComponents
{
    public class _DefaultMessageComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View(new Message());

        }
    }
}
