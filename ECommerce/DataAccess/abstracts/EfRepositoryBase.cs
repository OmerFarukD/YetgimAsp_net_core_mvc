using System.Linq.Expressions;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccess.abstracts;

public class EfRepositoryBase<TEntity, TId, TContext> : IRepository<TEntity,TId>

where TEntity : Entity<TId>
where TContext : DbContext
{

    protected TContext _context { get;}

    public EfRepositoryBase(TContext context)
    {
        _context = context;
    }

    public void Add(TEntity entity)
    {
        entity.CreatedTime = DateTime.Now;
        _context.Set<TEntity>().Entry(entity).State = EntityState.Added;
        _context.SaveChanges();
    }

    public void Update(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        _context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
        _context.SaveChanges();
    }

    public List<TEntity> GetAll(Expression<Func<TEntity,bool>>? filter = null,bool include = true,bool tracking = true)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();

        if (filter != null)
        {
            query = query.Where(filter);
        }
        
        if (include == false)
        {
            query = query.IgnoreAutoIncludes();
        }

        if (tracking == false)
        {
            query = query.AsNoTracking();
        }
        
        
        return  query.ToList();
    }

    public TEntity? Get(Expression<Func<TEntity, bool>> filter, bool include = true, bool tracking = true)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();
        if (include == false)
        {
            query = query.IgnoreAutoIncludes();
        }

        if (tracking == false)
        {
            query = query.AsNoTracking();
        }

        return query.SingleOrDefault(filter);
    }

 
        
}