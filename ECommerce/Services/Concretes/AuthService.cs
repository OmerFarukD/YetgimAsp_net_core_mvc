using System.Security.Claims;
using ECommerce.Models;
using ECommerce.Models.Dtos.Users;
using ECommerce.Services.Abstracts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;

namespace ECommerce.Services.Concretes;

public class AuthService(SignInManager<User> signInManager,IUserService userService,IHttpContextAccessor contextAccessor) : IAuthService
{
    public async Task LoginAndAddCookieAsync(UserLoginDto dto)
    {
        var user = await userService.LoginAsync(dto);
        await signInManager.SignInAsync(user, isPersistent: false);
        
    }

    public async Task LogOutAsync()
    {
        await contextAccessor.HttpContext.SignOutAsync();
    }
}