using Telstar.Models.Integration;

namespace Telstar.Services
{
    public class ShippingIntegrationService : IShippingIntegrationService
    {
        public Costs FindRoutes(List<Parcel> parcelList, int startCity, int destinationCity)
        {
            Costs costs = new Costs() {
                Id = new Guid(),
                Price = "111.00",
                Time = 13.4f
            };
            return costs;
        }
    }
}