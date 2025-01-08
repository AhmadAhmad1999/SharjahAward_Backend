using SharijhaAward.Domain.Entities.RelatedAccountModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class RelatedAccountRequestSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public RelatedAccountRequestSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.RelatedAccountRequests.Any())
            {
               await _context.RelatedAccountRequests.AddRangeAsync(
                   new RelatedAccountRequest()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       // Id = 1,
                       ReceiverId = 1,
                       SenderId = 2
                   }, new RelatedAccountRequest()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       // Id = 2,
                       ReceiverId = 1,
                       SenderId = 3
                   });
               await _context.SaveChangesAsync();
            }
        }
    }
}
