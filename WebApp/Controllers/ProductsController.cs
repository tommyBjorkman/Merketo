using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProductsController : Controller
    {
        [Route("products/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("products/{id}")]
        public IActionResult Detail(string id)
        {
            return View();
        }
    }
}
