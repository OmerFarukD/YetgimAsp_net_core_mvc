﻿namespace ECommerce.Models.Dtos.Users;

public class UserRegisterDto
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}