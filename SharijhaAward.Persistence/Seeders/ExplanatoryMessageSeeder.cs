using SharijhaAward.Domain.Entities.ExplanatoryMessageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class ExplanatoryMessageSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public ExplanatoryMessageSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.ExplanatoryMessages.Any())
            {
                _context.ExplanatoryMessages.AddRange(
                   new ExplanatoryMessage()
                   {
                       Id = 1,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicText = "يمكنك البحث عن منسق لإرشادك في عملية المشاركة في الجائزة من خلال نحديد المعلومات الموجودة أدناه لتتمكن من اختيار المنسق الذي تريده.",
                       EnglishText = "You can search for a coordinator to guide you in the process of participating in the award by specifying the information below so that you can choose the coordinator you want.",
                       Type = TypeOfExplantoryMessage.SearchForCoordinator
                   }, new ExplanatoryMessage()
                   {
                       Id = 2,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicText = "شاركنا إنجازاتك هنا، نحن نبحث عن الأفراد المميزين في مجالاتهم ليشاركونا مهاراتهم وخبراتهم.",
                       EnglishText = "Share your achievements with us here. We are looking for distinguished individuals in their fields to share their skills and experiences with us.",
                       Type = TypeOfExplantoryMessage.Achievements
                   }, new ExplanatoryMessage()
                   {
                       Id = 3,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicText = "يمكنك ربط حسابك مع اشخاص آخرين عن طريق إرسال دعوة لهم عن طريق البريد الالكتروني .",
                       EnglishText = "You can link your account with other people by sending them an invitation via email.",
                       Type = TypeOfExplantoryMessage.LinkedAccounts
                   }, new ExplanatoryMessage()
                   {
                       Id = 4,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicText = "20 يوماً باق لانتهاء مرحلة التحكيم النهائية للمشاركين.",
                       EnglishText = "20 days remain until the end of the final judging phase for the participants.",
                       Type = TypeOfExplantoryMessage.HomePage
                   }, new ExplanatoryMessage()
                   {
                       Id = 5,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicText = "لقد اتممت خطوات التسجيل في الجائزة   -   الرجاء الذهاب إلى المراحل الخاصة بالاستمارة لإرسال الاستمارة .",
                       EnglishText = "You have completed the steps to register for the award - please go to the application stages to submit the form.",
                       Type = TypeOfExplantoryMessage.TheLastStepAfterSendingTheForm
                   }, new ExplanatoryMessage()
                   {
                       Id = 6,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicText = "الرجاء إتمام جميع المراحل الخاصة بالاستمارة الجديدة لتتمكن من الاشتراك بنجاح     --  يمكن الاشتراك بفئتين فقط (فئة ذات طابع فردي وفئة ذات طابع جماعي )خلال الدورة الواحدة ورفع الملفات المطلوبة عند تعبئة الاستمارة.",
                       EnglishText = "Please complete all stages of the new form to be able to participate successfully. You can participate in only two categories (an individual category and a group category) during one session and upload the required files when filling out the form.",
                       Type = TypeOfExplantoryMessage.TheFirstStepInTheForm
                   }, new ExplanatoryMessage()
                   {
                       Id = 7,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicText = "الرجاء الموافقة على الشروط الخاصة كل شرط على حدا ورفع البيانات المطلوبة  في الحقول الخاصة ليتم قبول استمارة الترشح الخاصة.",
                       EnglishText = "Please agree to the special conditions one by one and upload the required data in the special fields for the special nomination form to be accepted.",
                       Type = TypeOfExplantoryMessage.SpecialConditions
                   }, new ExplanatoryMessage()
                   {
                       Id = 8,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicText = "عزيزي المشترك الرجاء تأكيد الموافقة على كافة المعلومات الواردة ضمن الإستمارة الخاصة بك كون هذه الخطوة غير قابلة للتراجع.",
                       EnglishText = "Dear subscriber, please confirm your approval of all the information contained in your form, as this step is irreversible.",
                       Type = TypeOfExplantoryMessage.SignaturePage
                   }, new ExplanatoryMessage()
                   {
                       Id = 9,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicText = "يمكنك رفع عدد غير محدود من الملفات والتعديل عليها قبل إرسال الاستمارة",
                       EnglishText = "You can upload an unlimited number of files and modify them before submitting the form",
                       Type = TypeOfExplantoryMessage.Criterions
                   }, new ExplanatoryMessage()
                   {
                       Id = 10,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicText = "الرجاء إتمام جميع المراحل الخاصة بالاستمارة الجديدة لتتمكن من الاشتراك بنجاح     --  يمكن الاشتراك بفئتين فقط (فئة ذات طابع فردي وفئة ذات طابع جماعي )خلال الدورة الواحدة ورفع الملفات المطلوبة عند تعبئة الاستمارة.",
                       EnglishText = "Please complete all stages of the new form to be able to participate successfully. You can participate in only two categories (an individual category and a group category) during one session and upload the required files when filling out the form.",
                       Type = TypeOfExplantoryMessage.TheFirstStepInTheForm2
                   });
                _context.SaveChanges();
            }
        }
    }
}
