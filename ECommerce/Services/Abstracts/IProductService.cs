using ECommerce.Models;

namespace ECommerce.Services.Abstracts;

public interface IProductService
{
    List<Product> GetAll();
    Product? GetById(Guid id);
    void Add(Product product);
    void Update(Product product);
    void Delete(Guid id);
}