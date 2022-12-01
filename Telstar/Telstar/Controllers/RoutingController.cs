using Microsoft.AspNetCore.Mvc;

namespace Telstar.Controllers
{
    public class RoutingController : Controller
    {

        public string Index()
        {
            return "This is the default page";
        }
        
        // For each page add a method like this
        [Route("Welcome")] 
        public IActionResult WelcomePage()
        {
            // Put the name of your .cshtml file inside this View string (The cshtml must be inside the pages/shared folder!)
            return View("Welcome");
        }



    }
}
