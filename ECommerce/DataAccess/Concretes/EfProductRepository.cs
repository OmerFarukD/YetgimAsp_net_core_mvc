using ECommerce.DataAccess.abstracts;
using ECommerce.DataAccess.Contexts;
using ECommerce.Models;

namespace ECommerce.DataAccess.Concretes;

public class EfProductRepository : EfRepositoryBase<Product,Guid,BaseDbContext>, IProductRepository
{
    public EfProductRepository(BaseDbContext context) : base(context)
    {
    }

    public List<Product> GetAllByPriceRange(double min, double max)
    {
        // select * from products where Price<= max and Price >= min
        return _context.Products.Where(x => x.Price <= max && x.Price >= min).ToList();
    }
}