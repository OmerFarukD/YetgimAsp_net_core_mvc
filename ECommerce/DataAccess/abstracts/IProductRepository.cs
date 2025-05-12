using ECommerce.Models;

namespace ECommerce.DataAccess.abstracts;

public interface IProductRepository : IRepository<Product,Guid>
{
    List<Product> GetAllByPriceRange(double min, double max);
}
