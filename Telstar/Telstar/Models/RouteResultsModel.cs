using Telstar.BusinessLogic;

namespace Telstar.Models;

public class RouteResultsModel
{
    public decimal BestPrice { get; set; }
    public double BestTravelTime { get; set; }
    public ParcelRoute Route { get; set; }

    public RouteResultsModel(ParcelRoute bestRoute, ParcelRoute cheapestRoute, ParcelRoute fastestRoute)
    {
        BestPrice = bestRoute.GetPrice();
        BestTravelTime = bestRoute.GetTravelTime();
        Route = bestRoute;
    }
}