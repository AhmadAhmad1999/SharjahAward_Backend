using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class EducationalInstitutionSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public EducationalInstitutionSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.EducationalInstitutions.Any())
            {
                _context.EducationalInstitutions.AddRange(
                   new EducationalInstitution()
                   {
                       isDeleted = false,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       Id = 1,
                       ArabicName = "مؤسسة تعليمية 1",
                       EducationalEntityId = 1,
                       EnglishName = "Educational Entity 1"
                   }, new EducationalInstitution()
                   {
                       isDeleted = false,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       Id = 2,
                       ArabicName = "مؤسسة تعليمية 2",
                       EducationalEntityId = 2,
                       EnglishName = "Educational Entity 2"
                   });
                _context.SaveChanges();
            }
        }
    }
}
