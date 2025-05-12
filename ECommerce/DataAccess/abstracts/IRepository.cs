using System.Linq.Expressions;
using ECommerce.Models;

namespace ECommerce.DataAccess.abstracts;

public interface IRepository<TEntity,TId>
where TEntity : Entity<TId>
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    List<TEntity> GetAll(Expression<Func<TEntity,bool>>? filter = null,bool include = true, bool tracking = true);
    TEntity? Get(Expression<Func<TEntity,bool>> filter, bool include = true, bool tracking = true);
    
}