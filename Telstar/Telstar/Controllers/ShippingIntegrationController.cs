using Microsoft.AspNetCore.Mvc;
using Telstar.Models.Integration;

namespace Telstar.Controllers
{
    /// <summary>
    /// The controller for RouteFinding.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class RouteFindingController : ControllerBase
    {
        private readonly IRouteFindingController _routeFindingController;

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteFindingController"/> class.
        /// </summary>
        /// <param name="routeFindingController">Implementation of <see cref="IRouteFindingController"/> class.</param>>
        public RouteFindingController(IRouteFindingController routeFindingController)
        {
            _routeFindingController = routeFindingController;
        }

        [HttpGet(Name = "FindRoute")]
        public async Task<ActionResult<IEnumerable<Costs>>> FindRoutes(List<Parcel> parcelList, string startCity, string destinationCity)
        {
            // TODO: Change the return type to IEnumerable<model with retun body like nodes, total price, total time>
            var result = await _routeFindingController.FindRoutes(parcelList, startCity, destinationCity);

            return Ok(result);
        }
    }

}