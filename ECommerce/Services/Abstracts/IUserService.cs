using ECommerce.Models;
using ECommerce.Models.Dtos.Users;
using Microsoft.AspNetCore.Identity.Data;

namespace ECommerce.Services.Abstracts;

public interface IUserService
{
    Task<User> CreateUserAsync(UserRegisterDto dto);
    Task<User> LoginAsync(UserLoginDto dto);
}