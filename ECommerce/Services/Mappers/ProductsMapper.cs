using ECommerce.Models;
using ECommerce.Models.Dtos.Categories;
using ECommerce.Models.Dtos.Products;
using ECommerce.Models.ViewModels.Products;

namespace ECommerce.Services.Mappers;

public class ProductsMapper
{
    public static Product ConvertToEntity(ProductAddViewModel viewModel)
    {
        Product product = new()
        {
            Name = viewModel.Name,
            CategoryId = viewModel.CategoryId,
            Price = viewModel.Price
        };

        return product;
    }
    
    
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