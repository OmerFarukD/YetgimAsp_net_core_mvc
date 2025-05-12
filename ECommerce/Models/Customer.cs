namespace ECommerce.Models;

public class Customer : Entity<long>
{
    public string Name { get; set; }
    public string? Surname { get; set; }
    public string Type { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}