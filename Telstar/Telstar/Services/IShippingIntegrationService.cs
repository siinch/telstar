using Telstar.Models.Integration;

namespace Telstar.Services
{
    public interface IShippingIntegrationService
    {
        Task<Costs> FindRoutes(List<Parcel> parcelList, int startCity, int destinationCity);
    }
}