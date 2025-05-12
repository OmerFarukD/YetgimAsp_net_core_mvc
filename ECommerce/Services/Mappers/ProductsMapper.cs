using ECommerce.Models;
using ECommerce.Models.Dtos.Categories;
using ECommerce.Models.Dtos.Products;

namespace ECommerce.Services.Mappers;

public class ProductsMapper
{
    public static ProductResponseDto ConvertToResponse(Product product)
    {
        return new ProductResponseDto()
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price,
            CategoryId = product.CategoryId,
            CategoryName = product.Category.Name,
        };
    }

    public static List<ProductResponseDto> ConvertToResponseList(List<Product> products)
    {
        List<ProductResponseDto> productResponseDtos = new List<ProductResponseDto>();

        foreach (var product in products)
        {
            ProductResponseDto productResponseDto = ConvertToResponse(product);
            productResponseDtos.Add(productResponseDto);
        }
        return productResponseDtos;
    }
    
}