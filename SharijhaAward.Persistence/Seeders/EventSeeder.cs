using SharijhaAward.Domain.Entities.EventModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class EventSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public EventSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Events.Any())
            {
               await _context.Events.AddRangeAsync(
                    new Event()
                    {
                        isDeleted = false,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        // Id = 1,
                        ArabicDescription = "اختبار وصف حدث 1",
                        ArabicLocation = "اختبار موقع الفعالية 1",
                        ArabicName = "اختبار اسم حدث 1",
                        ArabicSiteName = "اختبار اسم مكان الحدث 1",
                        EndDate = DateTime.UtcNow.AddDays(5),
                        EnglishDescription = "Test Event Description 1",
                        EnglishLocation = "Test Event Location 1",
                        EnglishName = "Test Event Name 1",
                        EnglishSiteName = "Test Event Site Name 1",
                        EventDate = DateTime.UtcNow.AddDays(2),
                        StartDate = DateTime.UtcNow.AddDays(3),
                        UniqueIntegerId = 1
                    }, new Event()
                    {
                        isDeleted = false,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        // Id = 2,
                        ArabicDescription = "اختبار وصف حدث 2",
                        ArabicLocation = "اختبار موقع الفعالية 2",
                        ArabicName = "اختبار اسم حدث 2",
                        ArabicSiteName = "اختبار اسم مكان الحدث 2",
                        EndDate = DateTime.UtcNow.AddDays(8),
                        EnglishDescription = "Test Event Description 2",
                        EnglishLocation = "Test Event Location 2",
                        EnglishName = "Test Event Name 2",
                        EnglishSiteName = "Test Event Site Name 2",
                        EventDate = DateTime.UtcNow.AddDays(5),
                        StartDate = DateTime.UtcNow.AddDays(6),
                        UniqueIntegerId = 2
                    });
               await _context.SaveChangesAsync();
            }
        }
    }
}
