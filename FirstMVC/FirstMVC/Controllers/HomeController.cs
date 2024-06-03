using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetViewResult()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "Salam, AB204";
        //}

        //public JsonResult GetJsonResult()
        //{
        //    Product product = new Product
        //    {
        //        Id = 1,
        //        Name = "Test",
        //    };

        //    JsonResult jsonResult = new JsonResult(product);
        //    return jsonResult;
        //}


    }
}
