using SharijhaAward.Domain.Entities.RelatedAccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class RelatedAccountSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public RelatedAccountSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.RelatedAccounts.Any())
            {
                _context.RelatedAccounts.AddRange(
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
                _context.SaveChanges();
            }
        }
    }
}
