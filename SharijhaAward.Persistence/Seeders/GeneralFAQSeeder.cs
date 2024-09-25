using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class GeneralFAQSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public GeneralFAQSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.GeneralFAQs.Any())
            {
                await _context.GeneralFAQs.AddRangeAsync(
                new GeneralFAQ()
                {
                    // Id = 1,
                    ArabicAnswer = "اختبار جواب 1",
                    ArabicQuestion = "اختبار سؤال 1",
                    EnglishAnswer = "Test Answer 1",
                    EnglishQuestion = "Test Question 1",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    GeneralFrequentlyAskedQuestionCategoryId = 1
                }, new GeneralFAQ()
                {
                    // Id = 2,
                    ArabicAnswer = "اختبار جواب 2",
                    ArabicQuestion = "اختبار سؤال 2",
                    EnglishAnswer = "Test Answer 2",
                    EnglishQuestion = "Test Question 2",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    GeneralFrequentlyAskedQuestionCategoryId = 1
                }, new GeneralFAQ()
                {
                    // Id = 3,
                    ArabicAnswer = "اختبار جواب 3",
                    ArabicQuestion = "اختبار سؤال 3",
                    EnglishAnswer = "Test Answer 3",
                    EnglishQuestion = "Test Question 3",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    GeneralFrequentlyAskedQuestionCategoryId = 2
                }, new GeneralFAQ()
                {
                    // Id = 4,
                    ArabicAnswer = "اختبار جواب 4",
                    ArabicQuestion = "اختبار سؤال 4",
                    EnglishAnswer = "Test Answer 4",
                    EnglishQuestion = "Test Question 4",
                    isDeleted = false,
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = null,
                    DeletedAt = null,
                    LastModifiedAt = null,
                    LastModifiedBy = null,
                    GeneralFrequentlyAskedQuestionCategoryId = 2
                });
               await _context.SaveChangesAsync();
            }

        }
    }
}
