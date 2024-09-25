using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class FrequentlyAskedQuestionSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public FrequentlyAskedQuestionSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.FrequentlyAskedQuestions.Any())
            {
                await _context.FrequentlyAskedQuestions.AddRangeAsync(
                    new FrequentlyAskedQuestion()
                    {
                        // Id = 1,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CategoryId = 2,
                        ArabicQuestion = "كيف يمكنني المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                        ArabicAnswer = "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\n\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.",
                        EnglishQuestion = "How can I participate in the Sharjah Award for Educational Excellence and Excellence?",
                        EnglishAnswer = "You can participate in the award by following the following steps:\r\n\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria."
                    }, new FrequentlyAskedQuestion()
                    {
                        // Id = 2,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CategoryId = 4,
                        ArabicQuestion = "كيف يمكنني المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                        ArabicAnswer = "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\n\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.",
                        EnglishQuestion = "How can I participate in the Sharjah Award for Educational Excellence and Excellence?",
                        EnglishAnswer = "You can participate in the award by following the following steps:\r\n\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria."
                    }, new FrequentlyAskedQuestion()
                    {
                        // Id = 3,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CategoryId = 5,
                        ArabicQuestion = "كيف يمكنني المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                        ArabicAnswer = "يمكنك المشاركة في الجائزة من خلال اتباع الخطوات التالية:\r\n\r\nالنقر على \"بوابة المشتركين\" في القائمة الرئيسية للموقع.\r\nإذا لم يكن لديك حساب في البوابة، يرجى إنشاء حساب مستخدم جديد بالنقر على خيار \"سجل الآن\"، وقم بتعبئة البيانات المطلوبة.\r\nإذا كان لديك حساب مسبق في البوابة، يرجى النقر على خيار \"لقد قمت بالتسجيل مسبقاً\"، وقم بتسجيل الدخول بإدخال اسم المستخدم وكلمة المرور.\r\nبعد الدخول إلى البوابة، يمكنك التسجيل في الفئة التي ترغب بها ورفع المستندات المطلوبة.\r\nيمكنك رفع الأدلة بجانب كل معيار من معايير الفئة.",
                        EnglishQuestion = "How can I participate in the Sharjah Award for Educational Excellence and Excellence?",
                        EnglishAnswer = "You can participate in the award by following the following steps:\r\n\r\nClick on “Subscribers Portal” in the main menu of the site.\r\nIf you do not have an account on the portal, please create a new user account by clicking on the “Register Now” option and filling out the required data.\r\nIf you already have an account on the portal, please click on the “I have already registered” option and log in by entering your username and password.\r\nAfter entering the portal, you can register in the category you desire and upload the required documents.\r\nYou can upload evidence next to each category criteria."
                    }, new FrequentlyAskedQuestion()
                    {
                        // Id = 4,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CategoryId = 2,
                        ArabicQuestion = "ما هي شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                        ArabicAnswer = "تنقسم شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي إلى قسمين:\r\n\r\nالشروط العامة: وهي شروط تنطبق على جميع فئات الجائزة.\r\nالشروط الخاصة: وهي شروط محددة لفئة معينة من فئات الجائزة.\r\n\r\nللاطلاع على الشروط العامة والخاصة لفئات الجائزة، الرجاء اتباع الخطوات التالية:\r\n\r\nالدخول إلى صفحة فئات الجائزة من القائمة الرئيسية للموقع.\r\nالنقر على \"تحميل الدليل التفسيري للفئة\" وذلك للفئة التي ترغب بالاطلاع عليها.\r\nمن خلال الدليل التفسيري يمكنك الاطلاع على الشروط العامة والخاصة للفئة.",
                        EnglishQuestion = "What are the conditions for participation in the Sharjah Award for Excellence and Educational Excellence?",
                        EnglishAnswer = "The conditions for participation in the Sharjah Award for Excellence and Educational Excellence are divided into two parts:\r\n\r\nGeneral conditions: These are conditions that apply to all categories of the award.\r\nSpecial Conditions: These are specific conditions for a specific award category.\r\n\r\nTo view the general and specific conditions for the award categories, please follow the following steps:\r\n\r\nAccess the award categories page from the main menu of the website.\r\nClick on “Download the category interpretive guide” for the category you wish to view.\r\nThrough the interpretive guide you can view the general and special conditions of the category."
                    }, new FrequentlyAskedQuestion()
                    {
                        // Id = 5,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CategoryId = 4,
                        ArabicQuestion = "ما هي شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                        ArabicAnswer = "تنقسم شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي إلى قسمين:\r\n\r\nالشروط العامة: وهي شروط تنطبق على جميع فئات الجائزة.\r\nالشروط الخاصة: وهي شروط محددة لفئة معينة من فئات الجائزة.\r\n\r\nللاطلاع على الشروط العامة والخاصة لفئات الجائزة، الرجاء اتباع الخطوات التالية:\r\n\r\nالدخول إلى صفحة فئات الجائزة من القائمة الرئيسية للموقع.\r\nالنقر على \"تحميل الدليل التفسيري للفئة\" وذلك للفئة التي ترغب بالاطلاع عليها.\r\nمن خلال الدليل التفسيري يمكنك الاطلاع على الشروط العامة والخاصة للفئة.",
                        EnglishQuestion = "What are the conditions for participation in the Sharjah Award for Excellence and Educational Excellence?",
                        EnglishAnswer = "The conditions for participation in the Sharjah Award for Excellence and Educational Excellence are divided into two parts:\r\n\r\nGeneral conditions: These are conditions that apply to all categories of the award.\r\nSpecial Conditions: These are specific conditions for a specific award category.\r\n\r\nTo view the general and specific conditions for the award categories, please follow the following steps:\r\n\r\nAccess the award categories page from the main menu of the website.\r\nClick on “Download the category interpretive guide” for the category you wish to view.\r\nThrough the interpretive guide you can view the general and special conditions of the category."
                    }, new FrequentlyAskedQuestion()
                    {
                        // Id = 6,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        CategoryId = 5,
                        ArabicQuestion = "ما هي شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي؟",
                        ArabicAnswer = "تنقسم شروط المشاركة في جائزة الشارقة للتفوق والتميز التربوي إلى قسمين:\r\n\r\nالشروط العامة: وهي شروط تنطبق على جميع فئات الجائزة.\r\nالشروط الخاصة: وهي شروط محددة لفئة معينة من فئات الجائزة.\r\n\r\nللاطلاع على الشروط العامة والخاصة لفئات الجائزة، الرجاء اتباع الخطوات التالية:\r\n\r\nالدخول إلى صفحة فئات الجائزة من القائمة الرئيسية للموقع.\r\nالنقر على \"تحميل الدليل التفسيري للفئة\" وذلك للفئة التي ترغب بالاطلاع عليها.\r\nمن خلال الدليل التفسيري يمكنك الاطلاع على الشروط العامة والخاصة للفئة.",
                        EnglishQuestion = "What are the conditions for participation in the Sharjah Award for Excellence and Educational Excellence?",
                        EnglishAnswer = "The conditions for participation in the Sharjah Award for Excellence and Educational Excellence are divided into two parts:\r\n\r\nGeneral conditions: These are conditions that apply to all categories of the award.\r\nSpecial Conditions: These are specific conditions for a specific award category.\r\n\r\nTo view the general and specific conditions for the award categories, please follow the following steps:\r\n\r\nAccess the award categories page from the main menu of the website.\r\nClick on “Download the category interpretive guide” for the category you wish to view.\r\nThrough the interpretive guide you can view the general and special conditions of the category."
                    });
                await _context.SaveChangesAsync();
            }
        }
    }
}
