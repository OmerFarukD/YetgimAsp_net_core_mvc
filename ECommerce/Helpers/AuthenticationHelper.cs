namespace ECommerce.Helpers;

public class AuthenticationHelper(IHttpContextAccessor contextAccessor)
{
    public  bool IsAuthenticated()
    {
        return contextAccessor.HttpContext.User.Identity.IsAuthenticated;
    }

    public string GetUserName()
    {
        return IsAuthenticated() ? contextAccessor.HttpContext.User.Identity.Name : "None";
    }                                  
}