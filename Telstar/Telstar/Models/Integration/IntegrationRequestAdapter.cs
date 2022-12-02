namespace Telstar.Models.Integration
{
    public class IntegrationRequestAdapter : IIntegrationRequestAdapter
    {
        public Booking toInternalBooking(IntegrationRequest request)
        {
            return new Booking()
            {
                Id = new Guid(),
                FromCity = new City(),
                ToCity = new City(),
                Parcels = new List<Parcel>
                {

                }
]
            }
        }

        public IntegrationRequest toBooking(Booking booking)
        {

        }
        
    }
}