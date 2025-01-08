using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class DynamicAttributeSectionSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public DynamicAttributeSectionSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.DynamicAttributeSections.Any())
            {
               await _context.DynamicAttributeSections.AddRangeAsync(
                    new DynamicAttributeSection()
                    {
                        ArabicName = "اختبار اسم 1",
                        EnglishName = "Test Name 1",
                        isDeleted = false,
                        AttributeTableNameId = 1,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        RecordIdOnRelation = 2,
                        // Id = 1,
                        OrderId = 1
                    }
                );
                 await _context.SaveChangesAsync();
            }
        }
    }
}
