namespace ECommerce.Models.Dtos.Products;

public class ProductResponseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}