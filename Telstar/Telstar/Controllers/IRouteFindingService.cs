using Telstar.Models.Integration;

namespace Telstar.Controllers
{
    public interface IRouteFindingController
    {
        Task<Costs> FindRoutes(List<Parcel> parcelList, string startCity, string destinationCity) ;
    }
}