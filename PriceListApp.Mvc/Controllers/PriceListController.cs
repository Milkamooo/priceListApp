using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<PriceListController> _logger;

        public PriceListController(IPriceListRepository priceListRepository, IParameterRepository parameterRepository, ILogger<PriceListController> logger)
        {
            _priceListRepository = priceListRepository;
            _parameterRepository = parameterRepository;
            _logger = logger;
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
            priceList.Parameters = _parameterRepository.GetAll().ToList();
            var parameters = Enum.GetValues(typeof(ParameterType))
                                 .Cast<ParameterType>()
                                 .ToList();
            ViewBag.ParameterTypes = parameters;

            return View(priceList);
        }

        [HttpPost]
        public IActionResult AddPriceList(PriceList priceList)
        {


            return View(priceList);
        }

        public IActionResult DeleteParameter(int id)
        {
            PriceList priceList = new();
            priceList.Parameters = _parameterRepository.GetAll().Where(p => p.Id != id).ToList();
            var parametersTypes = Enum.GetValues(typeof(ParameterType))
                                 .Cast<ParameterType>()
                                 .ToList();
            ViewBag.ParameterTypes = parametersTypes;

            return View("AddPriceList", priceList);
        }

        public IActionResult AddParameter(int[] parameters)
        {
            PriceList priceList = new();
            Parameter parameter = new();
            priceList.Parameters = _parameterRepository.GetAll().Where(p => parameters.Contains(p.Id)).ToList();
            priceList.Parameters.Add(parameter);
            var parametersTypes = Enum.GetValues(typeof(ParameterType))
                                 .Cast<ParameterType>()
                                 .ToList();
            ViewBag.ParameterTypes = parametersTypes;

            return View("AddPriceList", priceList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
