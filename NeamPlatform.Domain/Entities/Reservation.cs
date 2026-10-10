namespace NeamPlatform.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int FoodDonationId { get; set; }
        public int BeneficiaryId { get; set; }
        public string ReservedByUsername { get; set; } = string.Empty; // لمعرفة من قام بالحجز
        public int Quantity { get; set; }
        public string Status { get; set; } = "Pending"; // الحالات: Pending, Delivered, Cancelled
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? RecipientName { get; set; } // سيتم تعبئته لاحقاً عند الاستلام
    }
}