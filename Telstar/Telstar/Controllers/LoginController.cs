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
        //return View("SearchRoutes");
        if (loginModel.Password == "admin" && loginModel.Username == "admin") 
            return View("SearchRoutes"); // Go to the search page
        return View("Login");
    }
}