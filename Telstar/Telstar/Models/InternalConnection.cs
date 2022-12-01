namespace Telstar.Models
{
    public class InternalConnection : IConnection
    {
        public Guid Id { get; set; }

        public City FromCity { get; set; }

        public City ToCity { get; set; }

        public int Distance { get; set; }
    }
}