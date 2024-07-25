using PriceListApp.Common.Contracts.Base;

namespace PriceListApp.Common.Contracts
{
    public class Product : ExtendedBaseEntity
    {
        public int Code { get; set; }
        public List<PriceList> PriceLists { get; set; } = new();
        public List<ProductParameter> ProductParameters { get; set; } = new();
    }
}
