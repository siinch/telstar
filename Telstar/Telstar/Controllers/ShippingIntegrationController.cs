using Microsoft.AspNetCore.Mvc;
using Telstar.Models.Integration;
using Telstar.Services;

namespace Telstar.Controllers
{
    /// <summary>
    /// The controller for ShippingIntegration.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ShippingIntegrationController : ControllerBase
    {
        private readonly IShippingIntegrationService _ShippingIntegrationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingIntegrationController"/> class.
        /// </summary>
        /// <param name="ShippingIntegrationController">Implementation of <see cref="IShippingIntegrationService"/> class.</param>>
        public ShippingIntegrationController(IShippingIntegrationService ShippingIntegrationService)
        {
            _ShippingIntegrationController = ShippingIntegrationController;
            _ShippingIntegrationService = ShippingIntegrationService;
        }

        [HttpPost(Name = "FindCosts")]
        public Costs FindRoutes(List<Parcel> parcelList, int startCity, int destinationCity)
        {
            // TODO: Change the return type to IEnumerable<model with retun body like nodes, total price, total time>
            var result = await _ShippingIntegrationController.FindRoutes(parcelList, startCity, destinationCity);
            var result = _ShippingIntegrationService.FindRoutes(parcelList, startCity, destinationCity);

            return result;
        }
    }

}