using SharijhaAward.Domain.Entities.StaticNotificationModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class StaticNotificationSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public StaticNotificationSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.StaticNotifications.Any())
            {
                await _context.StaticNotifications.AddRangeAsync(new List<StaticNotification>()
                {
                    new StaticNotification()
                    {
                        StaticNotificationType = StaticNotificationTypes.AfterSigningTheForm,
                        ArabicTitle = "إكمال تقديم استمارة",
                        EnglishTitle = "Finishing The Form",
                        ArabicBody = "مبارك, تم ملئ الاستمارة الخاصة بك بنجاح",
                        EnglishBody = "Congratulation, You have completed all the required steps for signing your form",
                        isActive = true
                    }, new StaticNotification()
                    {
                        StaticNotificationType = StaticNotificationTypes.ConfirmSelectedWinningForms,
                        ArabicTitle = "الفوز بجائزة الشارقة للتميز والتفوق التربوي",
                        EnglishTitle = "Winning the Sharjah Award for Educational Excellence and Distinction",
                        ArabicBody = "تهانينا\r\nلقد فزت في جائزة الشارقة للتميز والتفوق التربوي",
                        EnglishBody = "Congratulations\r\nYou have won the Sharjah Award for Excellence and Educational Excellence",
                        isActive = true
                    }, new StaticNotification()
                    {
                        StaticNotificationType = StaticNotificationTypes.SendRelatingRequest,
                        ArabicTitle = "طلب إرتباط",
                        EnglishTitle = "Related Account Request",
                        ArabicBody = "لديك طلب إرتباط جديد",
                        EnglishBody = "You have a new Related Account Request",
                        isActive = true
                    }
                });

                await _context.SaveChangesAsync();
            }
        }
    }
}
