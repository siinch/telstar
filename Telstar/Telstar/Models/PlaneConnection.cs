namespace Telstar.Models
{
    public class PlaneConnection : IConnection
    {
        public Guid Id { get; set; }

        public City FromCity { get; set; }

        public City ToCity { get; set; }

        
    }
}