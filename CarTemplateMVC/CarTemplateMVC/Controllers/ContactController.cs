using Microsoft.AspNetCore.Mvc;

namespace CarTemplateMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
