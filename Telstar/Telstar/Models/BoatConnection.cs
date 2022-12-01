namespace Telstar.Models
{
    public class BoatConnection : IConnection
    {
        public Guid Id { get; set; }

        public City FromCity { get; set; }

        public City ToCity { get; set; }

    }
}