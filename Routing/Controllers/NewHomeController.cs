using Microsoft.AspNetCore.Mvc;

namespace Routing.Controllers
{
    public class NewHomeController : Controller
    {
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("")]
        [Route("Product")]
        [Route("Product/ProductList")]
        [Route("Product/ProductList/{id:int}/{str}")]
        public IActionResult ProductById(int id, string str)
        {
            return Content($"Blog entry with ID #{id} requested (URL Slug: {str})");
            // return View();
        }
    }
}
