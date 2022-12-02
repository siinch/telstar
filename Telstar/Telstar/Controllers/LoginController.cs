using Microsoft.AspNetCore.Cryptography.KeyDerivation;
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

        byte[] salt =
            {
                251, 232, 57, 244, 108, 185, 10, 200, 231, 187, 221, 103, 91, 63, 117
            };

        var hash = "8RsZqXWzavEFE7HziNpj5We+MM+0Tjjx9PaXHkFitJ8=";

        if(loginModel.Password == null)
               return View("Login");

        // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
        string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: loginModel.Password,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));



        if (hash.Equals(hashed) && loginModel.Username != null)
        {
            HttpContext.Session.SetString("username", loginModel.Username);
            return View("SearchRoutes");
        }
       
        HttpContext.Session.Clear();
        return View("Login");
    }
}