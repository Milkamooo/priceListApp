using PriceListApp.Common.Contracts.Base;

namespace PriceListApp.Repository.Base
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        IList<T> GetAll();
        T? GetById(int id);
        T Add(T entity);
        public void Remove(T entity);
        public void Update(T entity);
    }

    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public PriceListDbContext _db = new PriceListDbContext();
        public IList<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }
        public virtual T? GetById(int id)
        {
            return _db.Set<T>().FirstOrDefault(p => p.Id == id);
        }

        public T Add(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();

            return entity;
        }

        public virtual void Remove(T entity)
        {
            var entityToRemove = _db.Set<T>().Find(entity.Id);

            if (entityToRemove != null)
            {
                _db.Set<T>().Remove(entityToRemove);
                _db.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            _db.Set<T>().Update(entity);
            _db.SaveChanges();
        }
    }
}
