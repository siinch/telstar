namespace Telstar.Models
{
    public class City
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        protected bool Equals(City other)
        {
            return Id == other.Id && Name == other.Name;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((City)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name);
        }
    }
}