namespace Telstar.Models
{
    public class Route
    {
        public Guid Id { get; set; }

        public List<IBookingConnection> bookingConnections { get; set; }

    }
    
}