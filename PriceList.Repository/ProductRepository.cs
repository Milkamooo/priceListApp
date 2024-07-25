using PriceListApp.Common.Contracts;
using PriceListApp.Repository.Base;

namespace PriceListApp.Repository
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
    }
}
