using Microsoft.AspNetCore.Mvc;
using Telstar.BusinessLogic;
using Telstar.Models;
using Telstar.Repository;

namespace Telstar.Controllers;

public class SearchController : Controller
{
    private RouteFindingAlgorithm _algorithm = new RouteFindingAlgorithm();
    private CityRepository _cityRepo = new CityRepository();
    private ConnectionRepository _conRepo = new ConnectionRepository();
    
    [Route("Search")] 
    public IActionResult CalculateRoutes(SearchModel model)
    {
        var result = _algorithm.CalculateRoute(_cityRepo.GetCityById(10), _cityRepo.GetCityById(22));
        result.ForEach(edge => Console.WriteLine(edge.FromCity.Name + " -> " + edge.ToCity.Name));
        Console.WriteLine(model == null);
        Console.WriteLine(model.DestinationCity);
        Console.WriteLine(model.OriginCity);
        return View("RouteResults");
    }
    
}