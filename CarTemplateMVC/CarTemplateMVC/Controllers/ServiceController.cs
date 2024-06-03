using Microsoft.AspNetCore.Mvc;

namespace CarTemplateMVC.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
