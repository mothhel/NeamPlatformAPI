namespace NeamPlatform.Domain.Entities
{
    // هذا الكلاس يمثل جميع من يسجل دخول للمنصة (مدير، موظف مطعم، مندوب جمعية)
    public class User
    {
        // معرف المستخدم
        public int Id { get; set; }

        // اسم المستخدم الذي سيدخل به للنظام
        public string Username { get; set; } = string.Empty;

        // كلمة المرور
        public string Password { get; set; } = string.Empty;

        // دور أو صلاحية المستخدم (مثال: SuperAdmin, RestaurantManager, Employee)
        public string Role { get; set; } = string.Empty;

        // هل حساب المستخدم مفعل؟
        public bool IsActive { get; set; } = true;

        // إذا كان المستخدم يتبع لمطعم، سيتم تخزين رقم المطعم هنا (مسموح أن يكون فارغاً null)
        public int? RestaurantId { get; set; }

        // إذا كان المستخدم يتبع لجمعية، سيتم تخزين رقم الجمعية هنا (مسموح أن يكون فارغاً null)
        public int? BeneficiaryId { get; set; }

        // --- العلاقات (Navigation Properties) ---
        // لربط المستخدم بالمطعم برمجياً لجلب بيانات المطعم مباشرة
        public Restaurant? Restaurant { get; set; }

        // لربط المستخدم بالجمعية برمجياً
        public Beneficiary? Beneficiary { get; set; }
    }
}