SET IDENTITY_INSERT PriceLists ON;
insert into PriceLists (Id, Name) values (1, 'Прайс-лист от 24.12.2013');
insert into PriceLists (Id, Name) values (2, 'Прайс-лист от 24.12.2013');
insert into PriceLists (Id, Name) values (3, 'Прайс-лист от 22.01.2014');
insert into PriceLists (Id, Name) values (4, 'Прайс-лист от 22.01.2014');
SET IDENTITY_INSERT PriceLists OFF;

SET IDENTITY_INSERT Parameters ON;
insert into Parameters (Id, Name, Type) values (1, 'Моя колонка (числовая)', 1);
insert into Parameters (Id, Name, Type) values (2, 'Еще одна моя колонка (строковая)', 2);
insert into Parameters (Id, Name, Type) values (3, 'И еще одна моя колонка (текстовая)', 3);
SET IDENTITY_INSERT Parameters OFF;

SET IDENTITY_INSERT Products ON;
insert into Products (Id, Name, Code) values (1, 'Стул', 100);
insert into Products (Id, Name, Code) values (2, 'Стол', 18263);
insert into Products (Id, Name, Code) values (3, 'Компьютер', 5);
SET IDENTITY_INSERT Products OFF;

insert into ParameterPriceList (ParametersId, PriceListsId) values (1, 4);
insert into ParameterPriceList (ParametersId, PriceListsId) values (2, 4);
insert into ParameterPriceList (ParametersId, PriceListsId) values (3, 4);

insert into PriceListProduct (PriceListsId, ProductsId) values (4, 1);
insert into PriceListProduct (PriceListsId, ProductsId) values (4, 2);
insert into PriceListProduct (PriceListsId, ProductsId) values (4, 3);

SET IDENTITY_INSERT ProductParameters ON;
insert into ProductParameters (Id, Value, ParameterId, ProductId) values (1, '100', 1, 1);
insert into ProductParameters (Id, Value, ParameterId, ProductId) values (2, '700', 1, 2);
insert into ProductParameters (Id, Value, ParameterId, ProductId) values (3, '2', 1, 3);
insert into ProductParameters (Id, Value, ParameterId, ProductId) values (4, 'Значение для первой строковой колонки', 2, 1);
insert into ProductParameters (Id, Value, ParameterId, ProductId) values (5, 'Деревянный', 2, 2);
insert into ProductParameters (Id, Value, ParameterId, ProductId) values (6, 'Pentium 4', 2, 3);
insert into ProductParameters (Id, Value, ParameterId, ProductId) values (7, 'Значение для второй строковой колонки', 3, 1);
insert into ProductParameters (Id, Value, ParameterId, ProductId) values (8, 'Красно-зеленый', 3, 2);
insert into ProductParameters (Id, Value, ParameterId, ProductId) values (9, '1.2GHz', 3, 3);
SET IDENTITY_INSERT ProductParameters OFF;