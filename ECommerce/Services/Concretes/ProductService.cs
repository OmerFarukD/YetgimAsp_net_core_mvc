using ECommerce.DataAccess.abstracts;
using ECommerce.Models;
using ECommerce.Models.Dtos.Products;
using ECommerce.Services.Abstracts;


namespace ECommerce.Services.Concretes;

public class ProductService : IProductService
{
    
    private IProductRepository _productRepository;
    

    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
 
    }


    public List<ProductResponseDto> GetAll()
    {
       
        
        List<Product> products = _productRepository.GetAll(include:true);
        List<ProductResponseDto> responseDtos = products.Select(x=> (ProductResponseDto)x).ToList();
        
        return responseDtos;
    }

    public ProductResponseDto? GetById(Guid id)
    {
        Product product =  _productRepository.Get(filter:x=>x.Id == id);
        ProductResponseDto response = product;
        
        return response;
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
        Product product = _productRepository.Get(x=>x.Id == id);
        _productRepository.Delete(product);
    }
    
}