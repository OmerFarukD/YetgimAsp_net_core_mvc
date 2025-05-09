using ECommerce.DataAccess.abstracts;
using ECommerce.DataAccess.Contexts;
using ECommerce.Models;

namespace ECommerce.DataAccess.Concretes;

public class EfProductRepository : IProductRepository
{
    private BaseDbContext _context;

    public EfProductRepository(BaseDbContext context)
    {
        _context = context;
    }
    
    
    public void Add(Product product)
    {
        product.CreatedTime = DateTime.Now;
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public void Update(Product product)
    {
        product.UpdatedTime = DateTime.Now;
        _context.Products.Update(product);
        _context.SaveChanges();
    }

    public void Delete(Product product)
    {
        product.CreatedTime = DateTime.Now;
        _context.Products.Remove(product);
        _context.SaveChanges();
    }

    public List<Product> GetAll()
    {
        return _context.Products.ToList();
    }

    public Product? GetById(Guid id)
    {
        return _context.Products.Find(id);
    }
    
}