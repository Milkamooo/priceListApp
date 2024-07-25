using Microsoft.AspNetCore.Mvc;

namespace PriceListApp.Mvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult AddProduct()
        {
            return View();
        }
    }
}
