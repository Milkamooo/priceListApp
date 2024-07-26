namespace PriceListApp.Repository.Tests
{
    public class PriceListRepositoryTests
    {
        PriceListRepository _priceListRepository = new PriceListRepository();

        [Fact]
        public void GetAllPriceLists()
        {
            var priceList = _priceListRepository.GetAll();

            Assert.NotNull(priceList);
            Assert.True(priceList.Any());
        }
    }
}
