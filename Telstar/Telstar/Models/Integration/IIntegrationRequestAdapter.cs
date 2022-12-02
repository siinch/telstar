namespace Telstar.Models.Integration
{
    public interface IIntegrationRequestAdapter
    {
        public Booking toInternalBooking(IntegrationRequest request);

        public IntegrationRequest toBooking(Booking booking);
        
    }
}