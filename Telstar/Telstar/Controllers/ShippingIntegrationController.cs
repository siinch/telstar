using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Telstar.BusinessLogic;
using Telstar.Models;
using Telstar.Models.Integration;
using Telstar.Repository;
using Telstar.Services;

namespace Telstar.Controllers
{
    /// <summary>
    /// The controller for ShippingIntegration.
    /// </summary>
    [ApiController]
    public class ShippingIntegrationController : ControllerBase
    {
        private readonly IShippingIntegrationService _ShippingIntegrationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingIntegrationController"/> class.
        /// </summary>
        /// <param name="ShippingIntegrationController">Implementation of <see cref="IShippingIntegrationService"/> class.</param>>
        public ShippingIntegrationController(IShippingIntegrationService ShippingIntegrationService)
        {
            _ShippingIntegrationService = ShippingIntegrationService;
        }

     
        [HttpPost("FindCosts")]
        public Models.Integration.Costs FindRoutes(IntegrationRequest request)
        {

            var originCity = _cityRepo.GetCityById(request.StartCityId);
            var destinationCity = _cityRepo.GetCityById(request.DestinationCityId);
            var result = _algorithm.CalculateRoute(originCity, destinationCity);
            if (result == null) throw new NullReferenceException();
            // TODO: Change the return type to IEnumerable<model with retun body like nodes, total price, total time

            Models.Integration.Costs cost = new Models.Integration.Costs();
            var reqPrice = result.GetPrice() * 7.08 * 1.05;
            cost.Price = reqPrice.ToString();
            cost.Time = (float)result.GetTravelTime();
            return cost;
        }

        private RouteFindingAlgorithm _algorithm = new RouteFindingAlgorithm();
        private CityRepository _cityRepo = new CityRepository();
        private ConnectionRepository _conRepo = new ConnectionRepository();

        private SearchModel mapRequestToSearchModel(IntegrationRequest request)
        {
            SearchModel mappedRequest = new SearchModel();
         
            
            return mappedRequest;
        }
    }


}