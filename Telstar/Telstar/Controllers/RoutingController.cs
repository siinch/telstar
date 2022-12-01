using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Telstar.Models;
using Telstar.Pages;

namespace Telstar.Controllers
{
    public class RoutingController : Controller
    {
        
        public IActionResult Index()
        {
            return View("Login");
        }

        // For each page add a method like this
        [Route("Welcome")] 
        public IActionResult WelcomePage()
        {
            // Put the name of your .cshtml file inside this View string (The cshtml must be inside the pages/shared folder!)
            return View("Welcome");
        }

        [Route("Results")]
        public IActionResult RouteResultsPage()
        {
            return View("RouteResults");
        }


    }
}
