namespace NeamPlatform.Domain.Entities
{
    public class PickupRequest
    {
        public int Id { get; set; }
        public DateTime RequestTime { get; set; } = DateTime.UtcNow;
        public string Status { get; set; } = "Pending"; // Pending, Delivered, etc.
        public int Quantity { get; set; }
        public string? ReceiverName { get; set; }
        public DateTime? DeliveredTime { get; set; }

        public int BeneficiaryId { get; set; }
        public Beneficiary? Beneficiary { get; set; }

        public int FoodDonationId { get; set; }
        public FoodDonation? FoodDonation { get; set; }
    }
}