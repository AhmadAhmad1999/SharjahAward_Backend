using SharijhaAward.Domain.Entities.CriterionItemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class CriterionItemSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public CriterionItemSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.CriterionItems.Any())
            {
               await _context.CriterionItems.AddRangeAsync(
                    new CriterionItem()
                    {
                        // Id =1,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CriterionId = 2,
                        OrderId = 1,
                        ArabicName = "التخطيط الاستراتيجي للمشاريع والمبادرات التي تخدم اللغة العربية",
                        EnglishName = "Strategic planning for projects and initiatives that serve the Arabic language",
                        Score = 40,
                        ActualScore = 40,
                        SizeOfAttachmentInKB = 5000
                    }, new CriterionItem()
                    {
                        // Id =2,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CriterionId = 2,
                        OrderId = 2,
                        ArabicName = "دعم المهارات اللغوية لدى جميع فئات الطلاب",
                        EnglishName = "Supporting language skills for all categories of students",
                        Score = 120,
                        ActualScore = 120,
                        SizeOfAttachmentInKB = 5000
                    }, new CriterionItem()
                    {
                        // Id =3,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CriterionId = 2,
                        OrderId = 3,
                        ArabicName = "قيادة تنمية الكفايات اللغوية للمجتمع المدرسي",
                        EnglishName = "Leading the development of the language competencies of the school community",
                        Score = 60,
                        ActualScore = 60,
                        SizeOfAttachmentInKB = 5000
                    }, new CriterionItem()
                    {
                        // Id =4,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CriterionId = 2,
                        OrderId = 4,
                        ArabicName = "إدارة رأس المال البشري والموارد بما يخدم اللغة العربية",
                        EnglishName = "Managing human capital and resources to serve the Arabic language",
                        Score = 60,
                        ActualScore = 60,
                        SizeOfAttachmentInKB = 5000
                    }, new CriterionItem()
                    {
                        // Id =5,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CriterionId = 2,
                        OrderId = 5,
                        ArabicName = "قيادة الأداء المؤسسي بما يثري المدرسة بنتاجات أدبية",
                        EnglishName = "Leading institutional performance to enrich the school with literary productions",
                        Score = 40,
                        ActualScore = 40,
                        SizeOfAttachmentInKB = 5000
                    }, new CriterionItem()
                    {
                        // Id =6,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CriterionId = 3,
                        OrderId = 1,
                        ArabicName = "إتقان المجتمع المدرسي لمهارات اللغة العربية تواصلاً وقراءةً وإبداعاً",
                        EnglishName = "The school community masters the Arabic language skills in communication, reading, and creativity",
                        Score = 150,
                        ActualScore = 150,
                        SizeOfAttachmentInKB = 5000
                    }, new CriterionItem()
                    {
                        // Id =7,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CriterionId = 3,
                        OrderId = 2,
                        ArabicName = "نشر ثقافة الاعتزاز باللغة العربية في المجتمع المدرسي والمحلي",
                        EnglishName = "Spreading a culture of pride in the Arabic language in the school and local community",
                        Score = 50,
                        ActualScore = 50,
                        SizeOfAttachmentInKB = 5000
                    });
                await _context.SaveChangesAsync();
            }
        }
    }
}
