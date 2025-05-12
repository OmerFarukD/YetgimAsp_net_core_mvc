namespace ECommerce.Models;

public class Product : Entity<Guid>
{
    public Product()
    {
        Category = new Category();
        Name = string.Empty;
    }
    
    public string Name { get; set; }
    public double Price { get; set; }
    
    public int CategoryId { get; set; }
    public Category Category { get; set; } 
    
    
    
}