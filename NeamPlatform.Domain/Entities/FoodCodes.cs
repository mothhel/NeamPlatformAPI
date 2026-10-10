namespace NeamPlatform.Domain.Entities
{
    public class FoodCode
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // مثل: أرز بخاري، دجاج شواية

        public int RestaurantId { get; set; }
        public Restaurant? Restaurant { get; set; }
    }
}