using PriceListApp.Common.Contracts;

namespace PriceListApp.Mvc.Models
{
    public class AddProductViewModel
    {
        public int PriceListId { get; set; }
        public Product Product { get; set; } = new();
        public List<Parameter> Parameters { get; set; } = new();
    }
}
