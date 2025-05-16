using System.Security.Claims;
using ECommerce.Models.Dtos.Users;
using ECommerce.Services.Abstracts;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ECommerce.Services.Concretes;

public class AuthService(IUserService userService,IHttpContextAccessor contextAccessor) : IAuthService
{
    public async Task LoginAndAddCookieAsync(UserLoginDto dto)
    {
        var user = await userService.LoginAsync(dto);

        List<Claim> claims = new List<Claim>()
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Name),
            new Claim(ClaimTypes.Email, user.Email)
        };

        ClaimsIdentity claimsIdentity = new(claims, CookieAuthenticationDefaults.AuthenticationScheme);

        ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);
        // Oturum aç
        await contextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);
    }

    public async Task LogOutAsync()
    {
        await contextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
}