using Microsoft.AspNetCore.Mvc;
using Telstar.Models;

namespace Telstar.Controllers;

public class SearchController : Controller
{
    [Route("Search")] 
    public IActionResult CalculateRoutes(SearchModel model)
    {
        Console.WriteLine(model == null);
        Console.WriteLine(model.DestinationCity);
        Console.WriteLine(model.OriginCity);
        return View("RouteResults");
    }
    
}