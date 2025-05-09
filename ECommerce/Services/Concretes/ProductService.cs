using ECommerce.DataAccess.abstracts;
using ECommerce.DataAccess.Concretes;
using ECommerce.DataAccess.Contexts;
using ECommerce.Models;
using ECommerce.Services.Abstracts;

namespace ECommerce.Services.Concretes;

public class ProductService : IProductService
{
    
    private IProductRepository _productRepository;

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public List<Product> GetAll()
    {
       return _productRepository.GetAll();
    }

    public Product? GetById(Guid id)
    {
        return _productRepository.GetById(id);
    }

    public void Add(Product product)
    {
        _productRepository.Add(product);
    }

    public void Update(Product product)
    {
        _productRepository.Update(product);
    }

    public void Delete(Guid id)
    {
        Product product = _productRepository.GetById(id);
        _productRepository.Delete(product);
    }
    
}