using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class TermAndConditionSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public TermAndConditionSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.TermsAndConditions.Any())
            {
                _context.TermsAndConditions.AddRange(
                   new TermAndCondition()
                   {
                       Id = 1,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicTitle = "الشروط العامة للمشاركة",
                       ArabicDescription = "يحق لجميع المدارس الحكومية والخاصة في الميدان التربوي في دولة الإمارات العربية المتحدة التقدم للمشاركة في الجائزة.\r\n- إرفاق أدلة توضح جهود المدرسة في رعاية اللغة العربية لثلاثة أعوام سابقة لعام الترشح, ويلغى طلب الترشح أو الفوز في حال ثبوت عدم صحة أحد الأدلة أو الوثائق المقدمة.\r\n- المشاركات جماعية وباسم المدرسة ولا تقبل المشاركات الفردية.\r\n- تقدم المدرسة رسالة مصدقة من الجهة المختصة بعدم وجود مخالفات إدارية ومالية عن اخر 3 سنوات سابقة لعام الترشح.\r\n- ترفق نسخة الهيكل التنظيمي للمدرسة و التوصيف الوظيفي لجميع الوظائف فيها.",
                       EnglishTitle = "General conditions for participation",
                       EnglishDescription = "All public and private schools in the educational field in the United Arab Emirates are eligible to apply to participate in the award.\r\n- Attach evidence explaining the school’s efforts in sponsoring the Arabic language for three years prior to the year of candidacy. The application for candidacy or winning will be canceled if any of the evidence or documents submitted is proven incorrect.\r\n- Participations are group and in the name of the school. Individual entries are not accepted.\r\n- The school submits a certified letter from the competent authority stating that there are no administrative and financial violations for the last 3 years preceding the year of candidacy.\r\nA copy of the school’s organizational structure and job descriptions for all positions are attached.",
                       NeedAttachment = false,
                       RequiredAttachmentNumber = null,
                       AttachmentType = null,
                       SizeOfAttachmentInKB = null,
                       IsAgree = false,
                       CategoryId = 2
                   }, new TermAndCondition()
                   {
                       Id = 2,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicTitle = "الشروط العامة للمشاركة",
                       ArabicDescription = "يحق لجميع المدارس الحكومية والخاصة في الميدان التربوي في دولة الإمارات العربية المتحدة التقدم للمشاركة في الجائزة.\r\n- إرفاق أدلة توضح جهود المدرسة في رعاية اللغة العربية لثلاثة أعوام سابقة لعام الترشح, ويلغى طلب الترشح أو الفوز في حال ثبوت عدم صحة أحد الأدلة أو الوثائق المقدمة.\r\n- المشاركات جماعية وباسم المدرسة ولا تقبل المشاركات الفردية.\r\n- تقدم المدرسة رسالة مصدقة من الجهة المختصة بعدم وجود مخالفات إدارية ومالية عن اخر 3 سنوات سابقة لعام الترشح.\r\n- ترفق نسخة الهيكل التنظيمي للمدرسة و التوصيف الوظيفي لجميع الوظائف فيها.",
                       EnglishTitle = "General conditions for participation",
                       EnglishDescription = "All public and private schools in the educational field in the United Arab Emirates are eligible to apply to participate in the award.\r\n- Attach evidence explaining the school’s efforts in sponsoring the Arabic language for three years prior to the year of candidacy. The application for candidacy or winning will be canceled if any of the evidence or documents submitted is proven incorrect.\r\n- Participations are group and in the name of the school. Individual entries are not accepted.\r\n- The school submits a certified letter from the competent authority stating that there are no administrative and financial violations for the last 3 years preceding the year of candidacy.\r\nA copy of the school’s organizational structure and job descriptions for all positions are attached.",
                       NeedAttachment = false,
                       RequiredAttachmentNumber = null,
                       AttachmentType = null,
                       SizeOfAttachmentInKB = null,
                       IsAgree = false,
                       CategoryId = 4
                   }, new TermAndCondition()
                   {
                       Id = 3,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicTitle = "الشروط العامة للمشاركة",
                       ArabicDescription = "يحق لجميع المدارس الحكومية والخاصة في الميدان التربوي في دولة الإمارات العربية المتحدة التقدم للمشاركة في الجائزة.\r\n- إرفاق أدلة توضح جهود المدرسة في رعاية اللغة العربية لثلاثة أعوام سابقة لعام الترشح, ويلغى طلب الترشح أو الفوز في حال ثبوت عدم صحة أحد الأدلة أو الوثائق المقدمة.\r\n- المشاركات جماعية وباسم المدرسة ولا تقبل المشاركات الفردية.\r\n- تقدم المدرسة رسالة مصدقة من الجهة المختصة بعدم وجود مخالفات إدارية ومالية عن اخر 3 سنوات سابقة لعام الترشح.\r\n- ترفق نسخة الهيكل التنظيمي للمدرسة و التوصيف الوظيفي لجميع الوظائف فيها.",
                       EnglishTitle = "General conditions for participation",
                       EnglishDescription = "All public and private schools in the educational field in the United Arab Emirates are eligible to apply to participate in the award.\r\n- Attach evidence explaining the school’s efforts in sponsoring the Arabic language for three years prior to the year of candidacy. The application for candidacy or winning will be canceled if any of the evidence or documents submitted is proven incorrect.\r\n- Participations are group and in the name of the school. Individual entries are not accepted.\r\n- The school submits a certified letter from the competent authority stating that there are no administrative and financial violations for the last 3 years preceding the year of candidacy.\r\nA copy of the school’s organizational structure and job descriptions for all positions are attached.",
                       NeedAttachment = false,
                       RequiredAttachmentNumber = null,
                       AttachmentType = null,
                       SizeOfAttachmentInKB = null,
                       IsAgree = false,
                       CategoryId = 5
                   });
                _context.SaveChanges();
            }
        }
    }
}
