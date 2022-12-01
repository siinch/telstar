namespace Telstar.Models
{
    public class Booking
    {
        public Guid Id { get; set; }

        public City FromCity { get; set; }

        public City ToCity { get; set; }

        public List<Parcel> Parcels { get; set; }

    }
}