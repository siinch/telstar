using Route = Telstar.Models.Route;

namespace Telstar.BusinessLogic;

public interface IPathFindingAlgorithm
{

    public Route CalculateFastestRoute(String originCityName, String destinationCityName,
        bool recommendedShippingRequired);

    public Route CalculateCheapestRoute(String originCityName, String destinationCityName,
        bool recommendedShippingRequired);

    public Route CalculateBestRoute(String originCityName, String destinationCityName,
        bool recommendedShippingRequired);

}