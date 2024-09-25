using SharijhaAward.Domain.Entities.CriterionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class CriterionSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public CriterionSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Criterions.Any())
            {
               await _context.Criterions.AddRangeAsync(
                    new Criterion()
                    {
                        // Id =1,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        OrderId = 1,
                        ArabicTitle = "الأداء والإنجازات المؤثرة",
                        EnglishTitle = "Influential performance and achievements",
                        Score = 500,
                        SizeOfAttachmentInKB = 0,
                        ParentId = null,
                        CategoryId = 2
                    }, new Criterion()
                    {
                        // Id =2,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        OrderId = 1,
                        ArabicTitle = "جودة الأداء والإنجازات والمبادرات المؤثرة التي تبنتها المدرسة",
                        EnglishTitle = "The quality of performance, achievements and influential initiatives adopted by the school",
                        Score = 300,
                        SizeOfAttachmentInKB = 5000,
                        ParentId = 1,
                        CategoryId = 2
                    }, new Criterion()
                    {
                        // Id =3,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        OrderId = 2,
                        ArabicTitle = "أثر الإنجازات والمبادرات في المجتمع المدرسي والمحلي، والقيمة المضافة لها",
                        EnglishTitle = "The impact of achievements and initiatives in the school and local community, and their added value",
                        Score = 200,
                        SizeOfAttachmentInKB = 5000,
                        ParentId = 1,
                        CategoryId = 2
                    });
                await _context.SaveChangesAsync();
            }
        }
    }
}
