﻿namespace ECommerce.Models;

public class Employee : Entity<long>
{
    public string Name { get; set; }
    public string? Surname { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}