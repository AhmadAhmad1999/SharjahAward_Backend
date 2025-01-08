using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Persistence.Seeders
{
    public class CategorySeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public CategorySeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public async Task Seed()
        {
            if (!_context.Categories.Any())
            {
                await _context.Categories.AddRangeAsync(
                   new Category()
                   {
                       // Id =1,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "جائزة جوهرة اللغة العربية",
                       EnglishName = "The \"Gem\" of the Arabic Language",
                       ArabicDescription = string.Empty,
                       EnglishDescription = string.Empty,
                       Icon = "https://award-shj.ae/media/cb2igx0d/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%A7%D9%84%D8%AC%D9%88%D9%87%D8%B1%D8%A9.png",
                       CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                       FinalArbitrationQualificationMark = null,
                       ExpectedNumberOfWinners = null,
                       RelatedToClasses = null,
                       ParentId = null,
                       CycleId = 1
                   }, new Category()
                   {
                       // Id =2,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "جائزة جوهرة اللغة العربية",
                       EnglishName = "The \"Gem\" of the Arabic Language",
                       ArabicDescription = "جائزة رائدة استثنائيّة تتسابق فيها المدارس الحكومية والخاصة في رعاية اللغة العربية، وتمكين المجتمع المدرسيّ (طالب، معلم، ولي الأمر...) من امتلاك مهارات اللغة العربية وتوظيفها في العلم والحياة.",
                       EnglishDescription = "It is an exceptional pioneering award where both public and private schools compete to promote the Arabic language, empower the school community students, teachers, and parents and equip them with the Arabic language skills that they can utilize in life and knowledge acquisition.",
                       Icon = "https://award-shj.ae/media/cb2igx0d/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%A7%D9%84%D8%AC%D9%88%D9%87%D8%B1%D8%A9.png",
                       CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                       FinalArbitrationQualificationMark = 100,
                       MinimumWinningScore = 90,
                       MinimumAmountToObtainAStatement = 50,
                       MaximumAmountToObtainAStatement = 60,
                       MinimumRequirementToObtainACertificate = 65,
                       MaximumRequirementToObtainACertificate = 80,
                       ExpectedNumberOfWinners = 4,
                       RelatedToClasses = false,
                       ParentId = 1,
                       CycleId = 1
                   }, new Category()
                   {
                       // Id =3,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "فئة الأفراد المتميزين",
                       EnglishName = "Distinguished Individuals Category",
                       ArabicDescription = string.Empty,
                       EnglishDescription = string.Empty,
                       Icon = "https://award-shj.ae/media/iqzhrizm/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2.png",
                       CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                       FinalArbitrationQualificationMark = null,
                       MinimumWinningScore = null,
                       ExpectedNumberOfWinners = null,
                       RelatedToClasses = false,
                       ParentId = null,
                       CycleId = 1
                   }, new Category()
                   {
                       // Id =4,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "فئة القائد التربوي المتميز",
                       EnglishName = "Distinguished Educational Leader Category",
                       ArabicDescription = "تشمل جميع القيادات التّربويّة في القطاعين الحكوميّ والخاص من فئة القيادات العليا والقيادات الوسطى.\r\n\r\nتشمل القيادة العليا (مدير مدرسة).\r\nتشمل القيادة الوسطى (مساعد مدير أكاديمي، رئيس وحدة الشؤون الأكاديمية، رئيس وحدة شؤون الطلبة، رئيس وحدة الخدمات).",
                       EnglishDescription = "This category consists of all educational leaders in the public and private sectors including senior leaders and middle leaders.\r\n\r\n- Senior leadership includes school principal.\r\n\r\n- Middle leadership includes Assistant Academic Principal, Head of Academic Affairs Unit, Head of Student Affairs Unit, Head of Services Unit.",
                       Icon = "https://award-shj.ae/media/iqzhrizm/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%82%D8%A7%D8%A6%D8%AF-%D8%A7%D9%84%D8%AA%D8%B1%D8%A8%D9%88%D9%8A-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2.png",
                       CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                       FinalArbitrationQualificationMark = 100,
                       MinimumWinningScore = 90,
                       MinimumAmountToObtainAStatement = 50,
                       MaximumAmountToObtainAStatement = 60,
                       MinimumRequirementToObtainACertificate = 65,
                       MaximumRequirementToObtainACertificate = 80,
                       ExpectedNumberOfWinners = 3,
                       RelatedToClasses = false,
                       ParentId = 3,
                       CycleId = 1
                   }, new Category()
                   {
                       // Id =5,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "فئة المعلم المتميز",
                       EnglishName = "Distinguished Teacher Category",
                       ArabicDescription = "المعلم هو المحرك الأساسي لعملية التعليم والتعلم، فبمقدار جودة عطائه ترتقي العملية التعليمية، وخاصة مع المتغيرات الحديثة التي تقتضي من المعلم مواكبتها، لينتج التعليم ثماره المرجوة، ويمتزج بعصر المعرفة والثورات التكنولوجية، ويصبح جزءاً فاعلًا في الحياة والاقتصاد، وتهتم الجائزة بهذه الفئة وتأهيلها ليثبت المعلم المشارك إنجازه وقيادته الفاعلة، وتطوّره المهنيّ، ويبرهن على إبداعه وابتكاراته الوظيفيّة ومسؤولياته المجتمعيّة، ويحق لجميع المعلمين من مرحلة رياض الأطفال إلى الصف الثاني عشر ومن ذوي التّخصصات المختلفة في التعليم الحكومي والخاص والفنّي والتكنولوجي الترشح لهذه الفئة.",
                       EnglishDescription = "The teacher is the main guide of the teaching and learning process as the quality of his/her input elevates the educational process, especially with the new changes and the technological revolution that require teachers to keep up with in order to achieve the desired results in life and economy. The Sharjah Award for Educational Excellence acknowledges this category and requires participant teachers to underscore their distinguished performance, effective leadership, professional development, creativity and innovation in the job, and social responsibility. All teachers from kindergarten to the twelfth grade with various specializations in public, private, and applied technology schools are eligible to nominate for this category.",
                       Icon = "https://award-shj.ae/media/5kbhcktn/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2.png",
                       CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Individual,
                       FinalArbitrationQualificationMark = 100,
                       MinimumWinningScore = 90,
                       MinimumAmountToObtainAStatement = 50,
                       MaximumAmountToObtainAStatement = 60,
                       MinimumRequirementToObtainACertificate = 65,
                       MaximumRequirementToObtainACertificate = 80,
                       ExpectedNumberOfWinners = 4,
                       RelatedToClasses = false,
                       ParentId = 3,
                       CycleId = 1
                   }, new Category()
                   {
                       // Id =6,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "فئة المؤسسات المتميزة",
                       EnglishName = "Distinguished Institutions Category",
                       ArabicDescription = string.Empty,
                       EnglishDescription = string.Empty,
                       Icon = "https://award-shj.ae/media/ceihv5g3/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%A4%D8%B3%D8%B3%D8%A7%D8%AA-%D8%A7%D9%84%D8%AA%D8%B9%D9%84%D9%8A%D9%85%D9%8A%D8%A9-%D8%A7%D9%84%D8%AD%D8%B6%D8%A7%D9%86%D8%A9-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2%D8%A9.png",
                       CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Group,
                       FinalArbitrationQualificationMark = null,
                       MinimumWinningScore = null,
                       ExpectedNumberOfWinners = null,
                       RelatedToClasses = false,
                       ParentId = null,
                       CycleId = 1
                   }, new Category()
                   {
                       // Id =7,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "فئة الحضانة المتميزة",
                       EnglishName = "Distinguished Nursery Category",
                       ArabicDescription = "تحرص الحكومة الرشيدة في دولة الامارات العربية المتحدة على جودة الخدمات المقدمة للطفل باعتباره اللبنة الأولى في بناء المجتمع وتلقينه الدروس الأولى للانطلاق إلى فضاء الحياة مسلحاً بالقيم والسلوكيات الإيجابية ومتمكنا من المهارات الأساسية الأولى لذا فقد أفردت الجائزة لهذه الفئة مجالًا لإبراز تميزها في مجال تطوير الأدوات وبيئة العمل وتقديم الخدمات المتميزة للعاملين فيها، وللطلبة ولأولياء الأمور، وللمجتمع ككل، ويحق لجميع الحضانات الحكومية والخاصة على مستوى دولة الإمارات التّقدّم للجائزة وفق معايير مخصّصة وضمن شروط محدّدة.",
                       EnglishDescription = "The rational government in the United Arab Emirates accentuates the quality of the services provided to the children as they are the first building block of the society and emphasizes on preparing them for life, equipping them with values and positive behavior, and mastering the key basic skills. Therefore, the Sharjah Award has devoted space to this category to highlight its excellence in developing the tools and work environment and providing distinguished services to its staff, students, parents, and the community. All nurseries at the UAE level are eligible to apply for the award according to specific criteria and conditions.",
                       Icon = "https://award-shj.ae/media/ceihv5g3/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%A4%D8%B3%D8%B3%D8%A7%D8%AA-%D8%A7%D9%84%D8%AA%D8%B9%D9%84%D9%8A%D9%85%D9%8A%D8%A9-%D8%A7%D9%84%D8%AD%D8%B6%D8%A7%D9%86%D8%A9-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2%D8%A9.png",
                       CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Group,
                       FinalArbitrationQualificationMark = 100,
                       MinimumWinningScore = 90,
                       MinimumAmountToObtainAStatement = 50,
                       MaximumAmountToObtainAStatement = 60,
                       MinimumRequirementToObtainACertificate = 65,
                       MaximumRequirementToObtainACertificate = 80,
                       ExpectedNumberOfWinners = 4,
                       RelatedToClasses = false,
                       ParentId = 6,
                       CycleId = 1
                   }, new Category()
                   {
                       // Id =8,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       ArabicName = "فئة المدرسة المتميزة",
                       EnglishName = "Distinguished School Category",
                       ArabicDescription = "تسهم المدرسة الفاعلة في معالجة مشكلات المجتمع ومساعدته على التطوير؛ وتقوم بدور طليعي في خدمته، وتعمل على تعزيز الصلة والتلاحم بين أفراده وتوجيه التربية وجهة عملية تتصل بواقع الحياة ، وتدريب الطلاب على التنظيم والتخطيط والعمل الجماعي لذا حظيت المدرسة المتميزة على جل اهتمام القائمين على الجائزة وخصصوا لها فئة لتحدد المدارس المشاركة من خلالها قدرتها الفائقة على قيادة التعليم والتعلم والأمن والسلامة وتحقيق جودة الحياة لطلابها، ويحق لجميع المدارس الحكومية و الخاصة على مستوى دولة الإمارات التّقدّم للجائزة وفق معايير مخصّصة وضمن شروط محدّدة.",
                       EnglishDescription = "An effective school contributes to developing the community and addressing its problems. It plays a key role in serving the community, strengthening the links and relations between its members, directing education to address real life, as well as training the students on organization, planning and teamwork. The Sharjah Award paid special attention to this category through providing schools with opportunities to demonstrate their abilities in leading teaching and learning, security and safety as well as wellbeing for its students. All public and private schools in the UAE are eligible to apply for the award according to specific criteria and conditions.",
                       Icon = "https://award-shj.ae/media/1dlpga1u/%D9%81%D8%A6%D8%A9-%D8%A7%D9%84%D9%85%D8%A4%D8%B3%D8%B3%D8%A7%D8%AA-%D8%A7%D9%84%D8%AA%D8%B9%D9%84%D9%8A%D9%85%D9%8A%D8%A9-%D8%A7%D9%84%D9%85%D8%AF%D8%B1%D8%B3%D8%A9-%D8%A7%D9%84%D9%85%D8%AA%D9%85%D9%8A%D8%B2%D8%A9.png",
                       CategoryClassification = Domain.Constants.CategoryConstants.CategoryClassification.Group,
                       FinalArbitrationQualificationMark = 100,
                       MinimumWinningScore = 90,
                       MinimumAmountToObtainAStatement = 50,
                       MaximumAmountToObtainAStatement = 60,
                       MinimumRequirementToObtainACertificate = 65,
                       MaximumRequirementToObtainACertificate = 80,
                       ExpectedNumberOfWinners = 4,
                       RelatedToClasses = false,
                       ParentId = 6,
                       CycleId = 1
                   });
                 await _context.SaveChangesAsync();
            }
        }
    }
}
