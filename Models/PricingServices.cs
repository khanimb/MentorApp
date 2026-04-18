namespace MentorApp.Models
{
    public class PricingServices
    {
        public int PricingId { get; set; }
        public int ServiceId { get; set; }
        public Pricing Pricing { get; set; } = null!;
        public Service Service { get; set; } = null!;
    }
}
