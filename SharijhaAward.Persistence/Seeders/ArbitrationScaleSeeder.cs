using SharijhaAward.Domain.Entities.ArbitrationScaleModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class ArbitrationScaleSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public ArbitrationScaleSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.ArbitrationScales.Any())
            {
               await _context.ArbitrationScales.AddRangeAsync(
                    new ArbitrationScale()
                    {
                        // Id =1,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CategoryId = 2,
                        ArabicTitle = "النماذج والأدلة",
                        EnglishTitle = "Forms and evidence",
                        DegreeScale = "0 - 100"
                    });
                await _context.SaveChangesAsync();
            }
        }
    }
}
