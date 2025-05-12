using ECommerce.Models;

namespace ECommerce.DataAccess.abstracts;

public interface IRepository<TEntity,TId>
where TEntity : Entity<TId>
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    List<TEntity> GetAll();
    TEntity? GetById(TId id);
}