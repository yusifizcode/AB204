using Microsoft.AspNetCore.Mvc;

namespace CarTemplateMVC.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
