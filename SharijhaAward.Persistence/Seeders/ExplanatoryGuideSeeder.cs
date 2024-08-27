using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class ExplanatoryGuideSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public ExplanatoryGuideSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.ExplanatoryGuides.Any())
            {
                _context.ExplanatoryGuides.AddRange(
                    new ExplanatoryGuide()
                    {
                        // Id = 1,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicTitle = "الدليل التفسيري",
                        EnglishTitle = "Explanatory Guide",
                        EnglishFilePath = "https://award-shj.ae/media/ffgjcmvp/the-gem-of-the-arabic-language-award-30.pdf",
                        ArabicFilePath = "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf",
                        CategoryId = 2
                    }, new ExplanatoryGuide()
                    {
                        // Id = 2,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicTitle = "الدليل التفسيري",
                        EnglishTitle = "Explanatory Guide",
                        EnglishFilePath = "https://award-shj.ae/media/tlrb5gxb/distinguished-educational-leader-category-senior-leadership-30.pdf",
                        ArabicFilePath = "https://award-shj.ae/media/i2flqxw5/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2-%D8%A7%D9%84%D9%82%D9%8A%D8%A7%D8%AF%D8%A9-%D8%A7%D9%84%D8%B9%D9%84%D9%8A%D8%A7-30.pdf",
                        CategoryId = 4
                    }, new ExplanatoryGuide()
                    {
                        // Id = 3,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicTitle = "الدليل التفسيري",
                        EnglishTitle = "Explanatory Guide",
                        EnglishFilePath = "https://award-shj.ae/media/1n5b35ld/distinguished-teacher-category-30.pdf",
                        ArabicFilePath = "https://award-shj.ae/media/kovhdfgh/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2-30.pdf",
                        CategoryId = 5
                    });
                _context.SaveChanges();
            }
        }
    }
}
