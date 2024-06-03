using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
