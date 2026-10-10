namespace NeamPlatform.Domain.Entities
{
    public class FoodDonation
    {
        public int Id { get; set; }

        // تحديث أسماء الحقول لتطابق قاعدة البيانات
        public string FoodName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime ExpiryTime { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public bool IsAvailable { get; set; } = true;

        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}