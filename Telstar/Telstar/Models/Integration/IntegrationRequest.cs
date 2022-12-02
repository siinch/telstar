namespace Telstar.Models.Integration
{
    public class IntegrationRequest
    {
        public List<Parcel> Parcels { get; set; }
        public int StartCityId { get; set; }
        public int DestinationCityId { get; set; }
    }
}