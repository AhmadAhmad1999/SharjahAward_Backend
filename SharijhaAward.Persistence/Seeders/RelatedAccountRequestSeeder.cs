using SharijhaAward.Domain.Entities.RelatedAccountModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class RelatedAccountRequestSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public RelatedAccountRequestSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.RelatedAccountRequests.Any())
            {
                _context.RelatedAccountRequests.AddRange(
                   new RelatedAccountRequest()
                   {
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       Id = 1,
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
                       Id = 2,
                       ReceiverId = 1,
                       SenderId = 3
                   });
                _context.SaveChanges();
            }
        }
    }
}
