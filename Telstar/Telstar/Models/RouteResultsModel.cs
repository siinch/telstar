using Telstar.BusinessLogic;

namespace Telstar.Models;

public class RouteResultsModel
{
    public double BestPrice { get; set; }
    public double BestTravelTime { get; set; }

    public RouteResultsModel(ParcelRoute bestRoute, ParcelRoute cheapestRoute, ParcelRoute fastestRoute)
    {
        BestPrice = bestRoute.GetPrice();
        BestTravelTime = bestRoute.GetTravelTime();
    }
}