namespace NeamPlatform.Domain.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        // الحقول الجديدة بناءً على صورة قاعدة البيانات
        public string? Address { get; set; }
        public string? Phone { get; set; }

        public bool IsActive { get; set; } = true;
    }
}