using Microsoft.AspNetCore.Mvc;
using Telstar.Models.Integration;
using Telstar.Services;

namespace Telstar.Controllers
{
    /// <summary>
    /// The controller for ShippingIntegration.
    /// </summary>
    [Route("")]
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
        public JsonResult FindRoutes(IntegrationRequest integrationRequest)
        {
            // TODO: Change the return type to IEnumerable<model with retun body like nodes, total price, total time>
            var result = _ShippingIntegrationService.FindRoutes(integrationRequest.Parcels, integrationRequest.StartCityId, integrationRequest.DestinationCityId);

            return new JsonResult(result);
        }
    }

}