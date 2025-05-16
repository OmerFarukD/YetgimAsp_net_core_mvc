using System.Security.Claims;
using ECommerce.Models.Dtos.Users;
using ECommerce.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
namespace ECommerce.Controllers;

public class AuthenticationController(IAuthService service) : Controller
{
    /*
    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(UserRegisterDto dto)
    {
        await serviceRe(dto);
        return RedirectToAction("Index","Home");
    }
    */


    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(UserLoginDto dto)
    {
        await service.LoginAndAddCookieAsync(dto);
        return RedirectToAction("Index","Home");
    }

    public async Task<IActionResult> LogOut()
    {
        await service.LogOutAsync();
        return RedirectToAction("Login");
    }

    [HttpGet]
    public IActionResult TestAuth()
    {
        if (HttpContext.User.Identity != null && HttpContext.User.Identity.IsAuthenticated)
        {
            var username = HttpContext.User.Identity.Name;
            var roles = HttpContext.User.Claims
                .Where(c => c.Type == ClaimTypes.Role)
                .Select(c => c.Value)
                .ToList();
            
            return Json(new
            {
                IsAuthenticated = true,
                Username=username,
                Roles = roles
            });
        }
        return Json(new { IsAuthenticated = false });
    }
}