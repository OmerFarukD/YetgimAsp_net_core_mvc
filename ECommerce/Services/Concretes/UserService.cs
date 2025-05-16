using ECommerce.Exceptions;
using ECommerce.Models;
using ECommerce.Models.Dtos.Users;
using ECommerce.Services.Abstracts;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Services.Concretes;

public class UserService(UserManager<User> userManager) : IUserService
{
    public async Task<User> CreateUserAsync(UserRegisterDto dto)
    {

        var findEmail = await userManager.FindByEmailAsync(dto.Email);

        if (findEmail is not null)
        {
            throw new BusinessException("Bu email kullanılmaktadır.");
        }
        
        
        User user = new User()
        {
            Email = dto.Email,
            Name = dto.Name,
            Surname = dto.Surname,
            UserName = dto.Username
        };

        
     
        await userManager.CreateAsync(user, dto.Password);

        return user;
    }

    public async Task<User> LoginAsync(UserLoginDto dto)
    {
        var findEmail = await userManager.FindByEmailAsync(dto.Email);

        if (findEmail is null)
        {
            throw new BusinessException("Kullanıcı Bulunamadı");
        }

        bool passwordCheck = await userManager.CheckPasswordAsync(findEmail,dto.Password);

        if (passwordCheck == false)
        {
            throw new BusinessException("Parola Hatalıdır.");
        }

        return findEmail;
    }
}