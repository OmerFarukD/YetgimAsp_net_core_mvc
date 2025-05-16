using ECommerce.Models.Dtos.Users;

namespace ECommerce.Services.Abstracts;

public interface IAuthService
{
    Task LoginAndAddCookieAsync(UserLoginDto dto);
    Task LogOutAsync();
}