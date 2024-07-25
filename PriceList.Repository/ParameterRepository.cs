using PriceListApp.Common.Contracts;
using PriceListApp.Repository.Base;

namespace PriceListApp.Repository
{
    public interface IParameterRepository : IBaseRepository<Parameter>
    {
    }
    public class ParameterRepository : BaseRepository<Parameter>, IParameterRepository
    {
    }
}
