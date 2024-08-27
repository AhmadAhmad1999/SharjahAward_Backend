using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class EducationalEntitySeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public EducationalEntitySeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.EducationalEntities.Any())
            {
                _context.EducationalEntities.AddRange(
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
                        ArabicName = "جهة تعليمية 1"
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
                        ArabicName = "جهة تعليمية 2"
                    });
                _context.SaveChanges();
            }
        }
    }
}
