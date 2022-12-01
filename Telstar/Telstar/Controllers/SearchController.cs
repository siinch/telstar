using Microsoft.AspNetCore.Mvc;

namespace Telstar.Controllers;

public class SearchController : Controller
{
    [Route("Search")] 
    public IActionResult SearchRoutes()
    {
        
        return View();
    }
    
}