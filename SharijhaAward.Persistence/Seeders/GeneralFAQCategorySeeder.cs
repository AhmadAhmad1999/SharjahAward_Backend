using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class GeneralFAQCategorySeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public GeneralFAQCategorySeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.GeneralFAQCategories.Any())
            {
                _context.GeneralFAQCategories.AddRange(new GeneralFAQCategory()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    // Id = 1,
                    ArabicName = "اختبار فئة أسئلة شائعة عامة 1",
                    EnglishName = "Test General FAQ Category 1"
                }, new GeneralFAQCategory()
                {
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    // Id = 2,
                    ArabicName = "اختبار فئة أسئلة شائعة عامة 2",
                    EnglishName = "Test General FAQ Category 2"
                });

                _context.SaveChanges();
            }

        }
    }
}
