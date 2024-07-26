using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PriceListApp.Common.Contracts;
using PriceListApp.Mvc.Models;
using PriceListApp.Repository;
using System.Diagnostics;

namespace PriceListApp.Mvc.Controllers
{
    public class PriceListController : Controller
    {
        private readonly IPriceListRepository _priceListRepository;
        private readonly IParameterRepository _parameterRepository;

        public PriceListController(IPriceListRepository priceListRepository, IParameterRepository parameterRepository)
        {
            _priceListRepository = priceListRepository;
            _parameterRepository = parameterRepository;
        }

        public IActionResult Index()
        {
            var priceLists = _priceListRepository.GetAll().OrderByDescending(p => p.Id);
            return View(priceLists);
        }

        public IActionResult GetPriceList(int id)
        {
            var priceList = _priceListRepository.GetByIdWithIncludes(id);
            return View(priceList);
        }

        public IActionResult AddPriceList()
        {
            PriceList priceList = new();
            priceList.Parameters = _parameterRepository.GetAll().DistinctBy(p => p.Name).ToList();
            FillParametersTypeViewBag();

            return View(priceList);
        }

        [HttpPost]
        public IActionResult AddPriceList(PriceList priceList)
        {
            if (!String.IsNullOrEmpty(priceList.Name))
            {
                _priceListRepository.Add(priceList);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("AddPriceList");
            }
        }

        [HttpPost]
        public IActionResult DeleteParameter(string parametersArray,string name = "")
        {
            List<Parameter> parameters = JsonConvert.DeserializeObject<List<Parameter>>(parametersArray);
            PriceList priceList = new();
            priceList.Parameters = parameters.DistinctBy(p => p.Name).Where(p => p.Name != name).ToList();
            FillParametersTypeViewBag();

            return View("AddPriceList", priceList);
        }

        [HttpPost]
        public IActionResult AddParameter(string parametersArray)
        {
            List<Parameter> parameters = JsonConvert.DeserializeObject<List<Parameter>>(parametersArray);
            PriceList priceList = new();
            priceList.Parameters.AddRange(parameters);
            priceList.Parameters.Add(new Parameter());
            FillParametersTypeViewBag();

            return View("AddPriceList", priceList);
        }

        public void FillParametersTypeViewBag()
        {
            var parametersTypes = Enum.GetValues(typeof(ParameterType))
                     .Cast<ParameterType>()
                     .ToList();
            ViewBag.ParameterTypes = parametersTypes;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}