using PriceListApp.Common.Contracts.Base;

namespace PriceListApp.Common.Contracts
{
    public class PriceList : ExtendedBaseEntity
    {
        public List<Parameter> Parameters { get; set; } = new();
        public List<Product> Products { get; set; } = new();
    } 
}
