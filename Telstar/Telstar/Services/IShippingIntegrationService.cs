using Telstar.Models.Integration;

namespace Telstar.Services
{
    public interface IShippingIntegrationService
    {
        Costs FindRoutes(List<Parcel> parcelList, int startCity, int destinationCity);
    }
}