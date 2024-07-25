using Microsoft.EntityFrameworkCore;
using PriceListApp.Common.Contracts;
using PriceListApp.Repository.Base;

namespace PriceListApp.Repository
{
    public class PriceListDbInitData
    {
        //IPriceListRepository _priceListRepository;
        //IProductRepository _productRepository;
        //IParameterRepository _parameterRepository;
        //IProductParameterRepository _productParameterRepository;
        //public PriceListDbInitData(IPriceListRepository priceListRepository, IProductRepository productRepository, IParameterRepository parameterRepository, IProductParameterRepository productParameterRepository)
        //{
        //    _priceListRepository = priceListRepository;
        //    _productRepository = productRepository;
        //    _parameterRepository = parameterRepository;
        //    _productParameterRepository = productParameterRepository;
        //}

        //public void InitData()
        //{
        //    Parameter parameter1 = new()
        //    {
        //        Id = 1,
        //        Name = "Моя колонка (числовая)",
        //        Type = ParameterType.Number
        //    };
        //    Parameter parameter2 = new()
        //    {
        //        Id = 2,
        //        Name = "Еще одна моя колонка (строковая)",
        //        Type = ParameterType.SingleText
        //    };
        //    Parameter parameter3 = new()
        //    {
        //        Id = 3,
        //        Name = "И еще одна моя колонка (текстовая)",
        //        Type = ParameterType.MultilineText
        //    };

        //    Product product1 = new()
        //    {
        //        Id = 1,
        //        Name = "Стул",
        //    };
        //    Product product2 = new()
        //    {
        //        Id = 2,
        //        Name = "Стол",
        //    };
        //    Product product3 = new()
        //    {
        //        Id = 3,
        //        Name = "Компьютер",
        //    };

        //    ProductParameter productParameter1 = new()
        //    {
        //        Id = 1,
        //        Value = "100"
        //    };
        //    ProductParameter productParameter2 = new()
        //    {
        //        Id = 2,
        //        Value = "700"
        //    };
        //    ProductParameter productParameter3 = new()
        //    {
        //        Id = 3,
        //        Value = "2"
        //    };
        //    ProductParameter productParameter4 = new()
        //    {
        //        Id = 4,
        //        Value = "Значение для первой строковой колонки"
        //    };
        //    ProductParameter productParameter5 = new()
        //    {
        //        Id = 5,
        //        Value = "Деревянный"
        //    };
        //    ProductParameter productParameter6 = new()
        //    {
        //        Id = 6,
        //        Value = "Pentium 4"
        //    };
        //    ProductParameter productParameter7 = new()
        //    {
        //        Id = 7,
        //        Value = "Значение для второй строковой колонки"
        //    };
        //    ProductParameter productParameter8 = new()
        //    {
        //        Id = 8,
        //        Value = "Красно-зеленый"
        //    };
        //    ProductParameter productParameter9 = new()
        //    {
        //        Id = 9,
        //        Value = "1.2GHz"
        //    };

        //    PriceList priceList1 = new()
        //    {
        //        Id = 1,
        //        Name = "Прайс-лист от 24.12.2013",
        //    };
        //    PriceList priceList2 = new()
        //    {
        //        Id = 2,
        //        Name = "Прайс-лист от 24.12.2013",
        //    };
        //    PriceList priceList3 = new()
        //    {
        //        Id = 3,
        //        Name = "Прайс-лист от 22.01.2014",
        //    };
        //    PriceList priceList4 = new()
        //    {
        //        Id = 4,
        //        Name = "Прайс-лист от 22.01.2014",
        //    };

        //    _parameterRepository.Add(parameter1);
        //    _parameterRepository.Add(parameter2);
        //    _parameterRepository.Add(parameter3);

        //    _productRepository.Add(product1);
        //    _productRepository.Add(product2);
        //    _productRepository.Add(product3);

        //    _productParameterRepository.Add(productParameter1);
        //    _productParameterRepository.Add(productParameter2);
        //    _productParameterRepository.Add(productParameter3);
        //    _productParameterRepository.Add(productParameter4);
        //    _productParameterRepository.Add(productParameter5);
        //    _productParameterRepository.Add(productParameter6);
        //    _productParameterRepository.Add(productParameter7);
        //    _productParameterRepository.Add(productParameter8);
        //    _productParameterRepository.Add(productParameter9);

        //    _priceListRepository.Add(priceList1);
        //    _priceListRepository.Add(priceList2);
        //    _priceListRepository.Add(priceList3);
        //    _priceListRepository.Add(priceList4);


        //    parameter1.PriceLists = new List<PriceList> { priceList4 };
        //    parameter2.PriceLists = new List<PriceList> { priceList4 };
        //    parameter3.PriceLists = new List<PriceList> { priceList4 };

        //    priceList4.Parameters = new List<Parameter> { parameter1, parameter2, parameter3 };

        //    product1.PriceLists = new List<PriceList> { priceList4 };
        //    product2.PriceLists = new List<PriceList> { priceList4 };
        //    product3.PriceLists = new List<PriceList> { priceList4 };

        //    productParameter1.Parameter = parameter1;
        //    productParameter2.Parameter = parameter1;
        //    productParameter3.Parameter = parameter1;
        //    productParameter1.Product = product1;
        //    productParameter2.Product = product2;
        //    productParameter3.Product = product3;

        //    productParameter4.Parameter = parameter2;
        //    productParameter5.Parameter = parameter2;
        //    productParameter6.Parameter = parameter2;
        //    productParameter4.Product = product1;
        //    productParameter5.Product = product2;
        //    productParameter6.Product = product3;

        //    productParameter7.Parameter = parameter3;
        //    productParameter8.Parameter = parameter3;
        //    productParameter9.Parameter = parameter3;
        //    productParameter7.Product = product1;
        //    productParameter8.Product = product2;
        //    productParameter9.Product = product3;
        //}
    }
}