namespace Telstar.Models
{
    public interface IBookingConnection
    {
        public Guid Id { get; set; }

        public IConnection Connection { get; set; }

        public Costs Costs { get; set; }
    }
}