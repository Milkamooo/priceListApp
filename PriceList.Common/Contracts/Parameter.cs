using PriceListApp.Common.Contracts.Base;

namespace PriceListApp.Common.Contracts
{
    public class Parameter : ExtendedBaseEntity
    {
        public ParameterType Type { get; set; }
        public List<PriceList> PriceLists { get; set; } = new();
    }
}
