using PriceListApp.Common.Contracts;
using PriceListApp.Repository.Base;
using Microsoft.EntityFrameworkCore;

namespace PriceListApp.Repository
{
    public interface IPriceListRepository : IBaseRepository<PriceList>
    {
        PriceList? GetByIdWithIncludes(int id);
    }
    public class PriceListRepository : BaseRepository<PriceList>, IPriceListRepository
    {
        public PriceList? GetByIdWithIncludes(int id)
        {
            return _db.PriceLists.Where(p => p.Id == id).Include(p => p.Products).ThenInclude(pr => pr.ProductParameters)
                                .Include(p => p.Parameters).FirstOrDefault();
        }
    }
}
