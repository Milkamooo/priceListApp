using Microsoft.EntityFrameworkCore;
using PriceListApp.Common.Contracts;
using PriceListApp.Repository.Base;

namespace PriceListApp.Repository
{
    public interface IParameterRepository : IBaseRepository<Parameter>
    {
        List<Parameter> GetAllWithIncludes();
    }
    public class ParameterRepository : BaseRepository<Parameter>, IParameterRepository
    {
        public List<Parameter> GetAllWithIncludes()
        {
            return _db.Parameters.Include(p => p.PriceLists).ToList();
        }
    }
}
