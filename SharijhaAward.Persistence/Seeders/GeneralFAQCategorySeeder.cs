using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class GeneralFAQCategorySeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public GeneralFAQCategorySeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.GeneralFAQCategories.Any())
            {
               await _context.GeneralFAQCategories.AddRangeAsync(
                new GeneralFAQCategory()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    // Id = 1,
                    ArabicName = "اختبار فئة أسئلة شائعة عامة 1",
                    EnglishName = "Test General FAQ Category 1"
                }, new GeneralFAQCategory()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    // Id = 2,
                    ArabicName = "اختبار فئة أسئلة شائعة عامة 2",
                    EnglishName = "Test General FAQ Category 2"
                });

                await _context.SaveChangesAsync();
            }

        }
    }
}
