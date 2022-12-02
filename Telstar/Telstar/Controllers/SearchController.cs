using Microsoft.AspNetCore.Mvc;
using System.Globalization;
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
        if(HttpContext.Session.GetString("username") == null)
            return View("Login");
        try
        {
            var originCity = _cityRepo.GetCityByName(model.OriginCity);
            var destinationCity = _cityRepo.GetCityByName(model.DestinationCity);
            var result = _algorithm.CalculateRoute(originCity, destinationCity);
            if (result == null) throw new NullReferenceException();
            result.RecommendedShipping = model.Recommended;
            result.Weapons = model.Weapons;
            result.RefrigeratedGoods = model.RefrigeratedGoods;
            result.LiveAnimals= model.LiveAnimals;
            result.CautiousParcels = model.CautiousParcels;
            result.Weight = Math.Abs(Decimal.Round(decimal.Parse(model.Weight, CultureInfo.InvariantCulture.NumberFormat), 2));
            result.Height = Math.Abs(Decimal.Round(decimal.Parse(model.Height, CultureInfo.InvariantCulture.NumberFormat), 2));
            result.Width = Math.Abs(Decimal.Round(decimal.Parse(model.Width, CultureInfo.InvariantCulture.NumberFormat), 2));
            result.Length = Math.Abs(Decimal.Round(decimal.Parse(model.Length, CultureInfo.InvariantCulture.NumberFormat), 2));
            return View("RouteResults", new RouteResultsModel(result, result, result));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return View("SearchRoutes");
        }
    }
    
}