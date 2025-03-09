using SharijhaAward.Domain.Entities.EducationalEntityModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class EducationalEntitySeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public EducationalEntitySeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.EducationalEntities.Any())
            {
               await _context.EducationalEntities.AddRangeAsync(
                    new EducationalEntity()
                    {
                        isDeleted = false,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        // Id = 1,
                        EnglishName = "Educational Entity 1",
                        ArabicName = "جهة تعليمية 1",
                        CycleId = 1
                    }, new EducationalEntity()
                    {
                        isDeleted = false,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        // Id = 2,
                        EnglishName = "Educational Entity 2",
                        ArabicName = "جهة تعليمية 2",
                        CycleId = 1
                    });
                await _context.SaveChangesAsync();
            }
        }
    }
}
