namespace Telstar.Models.Integration
{

    public class Costs
    {
        public Guid Id { get; set; }
        public string? Price { get; set; } //DKK

        public float Time { get; set; } //Hours
    }
}