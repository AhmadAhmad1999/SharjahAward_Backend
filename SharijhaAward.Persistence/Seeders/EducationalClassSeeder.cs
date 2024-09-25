using SharijhaAward.Domain.Entities.EducationalClassModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class EducationalClassSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public EducationalClassSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.EducationalClasses.Any())
            {
               await _context.EducationalClasses.AddRangeAsync(
                    new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 1,
                        ArabicName = "الصف الأول",
                        EnglishName = "First class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 2,
                        ArabicName = "الصف الثاني",
                        EnglishName = "Second class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 3,
                        ArabicName = "الصف الثالث",
                        EnglishName = "Third class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 4,
                        ArabicName = "الصف الرابع",
                        EnglishName = "Forth class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 5,
                        ArabicName = "الصف الخامس",
                        EnglishName = "Fifth class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 6,
                        ArabicName = "الصف السادس",
                        EnglishName = "Sixth class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 7,
                        ArabicName = "الصف السابع",
                        EnglishName = "Seventh class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 8,
                        ArabicName = "الصف الثامن",
                        EnglishName = "Eighth class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 9,
                        ArabicName = "الصف التاسع",
                        EnglishName = "Ninth class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 10,
                        ArabicName = "الصف العاشر",
                        EnglishName = "Tenth class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 11,
                        ArabicName = "الصف الحادي عشر",
                        EnglishName = "Eleventh class"
                    }, new EducationalClass()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        // Id = 12,
                        ArabicName = "الصف الثاني عشر",
                        EnglishName = "Twelfth class"
                    }
                );
               await _context.SaveChangesAsync();
            }
        }
    }
}
