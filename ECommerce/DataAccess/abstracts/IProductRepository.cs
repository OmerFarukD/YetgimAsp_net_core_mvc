using ECommerce.Models;

namespace ECommerce.DataAccess.abstracts;

public interface IProductRepository
{
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);
    List<Product> GetAll();
    Product? GetById(Guid id);
}
