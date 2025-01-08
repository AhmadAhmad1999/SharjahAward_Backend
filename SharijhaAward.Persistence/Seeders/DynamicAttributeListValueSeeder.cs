using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class DynamicAttributeListValueSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public DynamicAttributeListValueSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.DynamicAttributeListValues.Any())
            {
               await _context.DynamicAttributeListValues.AddRangeAsync(
                    new DynamicAttributeListValue()
                    {
                        // Id =1,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DynamicAttributeId = 8,
                        EnglishValue = "Test Value 1",
                        ArabicValue = "Test Value 1"
                    }, new DynamicAttributeListValue()
                    {
                        // Id =2,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DynamicAttributeId = 8,
                        EnglishValue = "Test Value 2",
                        ArabicValue = "Test Value 2"
                    }, new DynamicAttributeListValue()
                    {
                        // Id =3,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DynamicAttributeId = 8,
                        EnglishValue = "Test Value 3",
                        ArabicValue = "Test Value 3"
                    }, new DynamicAttributeListValue()
                    {
                        // Id =4,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DynamicAttributeId = 8,
                        EnglishValue = "Test Value 4",
                        ArabicValue = "Test Value 4"
                    }, new DynamicAttributeListValue()
                    {
                        // Id =5,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DynamicAttributeId = 8,
                        EnglishValue = "Test Value 5",
                        ArabicValue = "Test Value 5"
                    });
                await _context.SaveChangesAsync();
            }
        }
    }
}
