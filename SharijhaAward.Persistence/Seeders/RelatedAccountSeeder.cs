using SharijhaAward.Domain.Entities.RelatedAccountModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class RelatedAccountSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public RelatedAccountSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.RelatedAccounts.Any())
            {
               await _context.RelatedAccounts.AddRangeAsync(
                    new RelatedAccount()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 1,
                        User1Id = 1,
                        User2Id = 4,
                    }, new RelatedAccount()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 2,
                        User1Id = 1,
                        User2Id = 5,
                    });
                await _context.SaveChangesAsync();
            }
        }
    }
}
