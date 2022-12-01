namespace Telstar.Models
{
    public interface IConnection
    {
        public Guid Id { get; set; }

        public City FromCity { get; set; }

        public City ToCity { get; set; }
    }
}