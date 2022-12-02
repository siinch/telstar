using Telstar.Models.Integration;

namespace Telstar.Services
{
    public interface IShippingHttpRequester
    {
        public Task<Costs> OutboundShippingRequest(List<Parcel> parcelList, int startCityId, int destinationCityId);
    }
}