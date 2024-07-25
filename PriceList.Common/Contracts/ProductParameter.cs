using PriceListApp.Common.Contracts.Base;

namespace PriceListApp.Common.Contracts
{
    public class ProductParameter : BaseEntity
    {
        public string Value { get; set; } = string.Empty;
        public Parameter Parameter { get; set; } = new();
        public Product Product { get; set; } = new();
    }
}
