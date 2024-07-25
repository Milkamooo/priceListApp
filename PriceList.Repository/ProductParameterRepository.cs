using PriceListApp.Common.Contracts;
using PriceListApp.Repository.Base;

namespace PriceListApp.Repository
{
    public interface IProductParameterRepository : IBaseRepository<ProductParameter>
    {
    }
    public class ProductParameterRepository : BaseRepository<ProductParameter>, IProductParameterRepository
    {
    }
}
