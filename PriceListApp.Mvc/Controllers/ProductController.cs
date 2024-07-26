using Microsoft.AspNetCore.Mvc;
using PriceListApp.Common.Contracts;
using PriceListApp.Repository;

namespace PriceListApp.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IPriceListRepository _priceListRepository;

        public ProductController(IPriceListRepository priceListRepository)
        {
            _priceListRepository = priceListRepository;
        }
        public IActionResult AddProduct(int id)
        {
            var priceList = _priceListRepository.GetByIdWithIncludes(id);
            priceList.Products.Add(new Product());
            foreach (var item in priceList.Parameters)
            {
                priceList.Products.FirstOrDefault().ProductParameters.Add(new ProductParameter());
            }

            return View(priceList);
        }

        [HttpPost]
        public IActionResult AddProduct(PriceList priceList)
        {
            _priceListRepository.Update(priceList);
            return RedirectToAction("GetPriceList", "PriceList", new { id = priceList.Id });
        }
    }
}
