using ECommerce.Models;
using ECommerce.Models.Dtos.Products;

namespace ECommerce.Services.Abstracts;

public interface IProductService
{
    List<ProductResponseDto> GetAll();
    ProductResponseDto? GetById(Guid id);
    void Add(Product product);
    void Update(Product product);
    void Delete(Guid id);
}