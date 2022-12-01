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
        private readonly IShippingIntegrationService _ShippingIntegrationController;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingIntegrationController"/> class.
        /// </summary>
        /// <param name="ShippingIntegrationController">Implementation of <see cref="IShippingIntegrationService"/> class.</param>>
        public ShippingIntegrationController(IShippingIntegrationService ShippingIntegrationController)
        {
            _ShippingIntegrationController = ShippingIntegrationController;
        }

        [HttpGet(Name = "FindRoute")]
        public async Task<ActionResult<IEnumerable<Costs>>> FindRoutes(List<Parcel> parcelList, int startCity, int destinationCity)
        {
            // TODO: Change the return type to IEnumerable<model with retun body like nodes, total price, total time>
            var result = await _ShippingIntegrationController.FindRoutes(parcelList, startCity, destinationCity);

            return Ok(result);
        }
    }

}