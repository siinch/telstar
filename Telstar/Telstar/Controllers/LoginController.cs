using Microsoft.AspNetCore.Mvc;
using Telstar.Pages;

namespace Telstar.Controllers;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        return View("Login");
    }
    
    [HttpPost]
    public ActionResult SubmitLogin(LoginModel loginModel)
    {
        Console.WriteLine(loginModel == null);
        Console.WriteLine(loginModel.Username);
        Console.WriteLine(loginModel.Password);
        return View("SearchRoutes"); // Go to the search page
    }
}