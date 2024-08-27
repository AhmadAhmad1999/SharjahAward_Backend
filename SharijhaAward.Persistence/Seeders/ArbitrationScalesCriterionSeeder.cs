using SharijhaAward.Domain.Entities.ArbitrationScaleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class ArbitrationScalesCriterionSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public ArbitrationScalesCriterionSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.ArbitrationScalesCriterions.Any())
            {
                _context.ArbitrationScalesCriterions.AddRange(
                    new ArbitrationScalesCriterion()
                    {
                        // Id =1,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicDescription = "نماذج للخطط المتعلقة بالمشاريع والمبادرات التي تخطط لها مكتملة العناصر عناصر الخطة لكل مشروع ومبادرة ونشاط يخدم اللغة العربية)، مع مراعاة أن تتضمن خطة المدرسة التشغيلية خطط مشاريع ومبادرات رعاية اللغة العربية.",
                        EnglishDescription = "Models of plans related to the projects and initiatives that you are planning, with complete elements (plan elements for each project, initiative, and activity that serves the Arabic language), taking into account that the school’s operational plan includes plans for projects and initiatives to support the Arabic language.",
                        CriterionId = 2,
                        CriterionItemId = 1,
                        ArbitrationScaleId = 1
                    }, new ArbitrationScalesCriterion()
                    {
                        // Id =2,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicDescription = "إرفاق أدلة مختلفة على ما تقوم به من خطط، أو أنشطة، أو برامج ، أو مشروعات مختلفة تمكن الطلاب من مهارات اللغة المختلفة.\r\nمدى تقدم الطلاب في المهارات وتمكنهم منها.\r\n- تحديد أدوات المتابعة والقياس التي تم توظيفها، مع مراعاة أن تشمل جميع فئات الطلاب الموهوبين، الفائقون، أصحاب الهمم،\r\nطلاب متدنو المستوى الطلاب كافة . بجميع المستويات).",
                        EnglishDescription = "Attach various evidence of the different plans, activities, programs, or projects you are undertaking that enable students with different language skills.\r\nThe extent of students’ progress in skills and their mastery of them.\r\n- Determine the monitoring and measurement tools that have been employed, taking into account that they include all categories of gifted students, exceptional students, people of determination,\r\nLow level students All students. at all levels).",
                        CriterionId = 2,
                        CriterionItemId = 2,
                        ArbitrationScaleId = 1
                    }, new ArbitrationScalesCriterion()
                    {
                        // Id =3,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicDescription = "- الخطط والبرامج والمشروعات والأنشطة التي نفذتها المدرسة وأثرها في رفع الكفايات اللغوية للمجتمع المدرسي المعلم سواء معلم\r\nاللغة العربية أو المواد المختلفة ، الوظائف المختلفة في المدرسة مثل مصادر التعلم والوظائف الداعمة ، الإداريون بمختلف أدوارهم، ولي\r\nالأمر).\r\n- الإحصائيات والأرقام و\r\nالمقارنات التي تبين التطور في الكفايات اللغوية للمجتمع المدرسي",
                        EnglishDescription = "- The plans, programmes, projects and activities implemented by the school and their impact in raising the linguistic competencies of the school community, whether teachers\r\nThe Arabic language or various subjects, various functions in the school such as learning resources and supporting functions, administrators in their various roles, and...\r\ncommand).\r\n- Statistics, numbers and\r\nComparisons that show the development in the linguistic competencies of the school community",
                        CriterionId = 2,
                        CriterionItemId = 3,
                        ArbitrationScaleId = 1
                    }, new ArbitrationScalesCriterion()
                    {
                        // Id =4,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicDescription = ". جودة توظيف الكوادر البشرية والموارد المختلفة في رعاية اللغة العربية وتمكين المجتمع المدرسي منها.\r\nخطط المدرسة والمنفذة مع معلمو اللغة العربية معلمو المواد الأخرى الطلاب ولي الأمر بما يخدم اللغة العربية.\r\n- توظيف الموارد المختلفة مثل مصادر التعلم والمختبرات والنوادي والمرافق المختلفة في خدمة اللغة العربية.",
                        EnglishDescription = ". The quality of employing human cadres and various resources in nurturing the Arabic language and empowering the school community with it.\r\nSchool plans implemented with Arabic language teachers, teachers of other subjects, students, and guardians to serve the Arabic language.\r\n- Employing various resources such as learning resources, laboratories, clubs and various facilities in serving the Arabic language.",
                        CriterionId = 2,
                        CriterionItemId = 4,
                        ArbitrationScaleId = 1
                    }, new ArbitrationScalesCriterion()
                    {
                        // Id =5,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicDescription = "المشاركة في عضويات ولجان أدبية، أو مؤسسات وروابط أدبية مثل اتحاد كتاب وأدباء الإمارات أو جمعية حماية اللغة العربية  أو مجمع اللغة العربية والتي تنعكس إيجابيا في رفع مستوى الكفايات اللغوية للطلاب والمعلمين وغيرهم في المجتمع المدرسي",
                        EnglishDescription = "Participation in memberships and literary committees, or literary institutions and associations such as the Emirates Writers and Writers Union, the Society for the Protection of the Arabic Language, or the Arabic Language Academy, which is reflected positively in raising the level of linguistic competencies of students, teachers, and others in the school community.",
                        CriterionId = 2,
                        CriterionItemId = 5,
                        ArbitrationScaleId = 1
                    }, new ArbitrationScalesCriterion()
                    {
                        // Id =6,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicDescription = "- نتائج الطلاب في الاختبارات المختلفة (المركزية الوطنية، الدولية).\r\n- تقارير لجان الجودة والرقابة والمتابعة ولجان الدعم الأكاديمي.\r\n- مشاركة المجتمع المدرسي في الفعاليات والمسابقات والمبادرات والأنشطة اللغوية والأدبية المختلفة وعلى جميع المستويات\r\nوحصولهم على مراكز متقدمة.",
                        EnglishDescription = "- Students’ results in various tests (central, national, international).\r\n- Reports of the quality, oversight and follow-up committees and academic support committees.\r\n- Participation of the school community in various events, competitions, initiatives, and linguistic and literary activities at all levels\r\nAnd they achieved advanced positions.",
                        CriterionId = 3,
                        CriterionItemId = 6,
                        ArbitrationScaleId = 1
                    }, new ArbitrationScalesCriterion()
                    {
                        // Id =7,
                        isDeleted = false,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        ArabicDescription = "رصد الممارسات والانشطة التي تدل على نشر وتأصيل اعتزاز المجتمع المدرسي بلغته العربية على مستوى المدرسة، والمجتمع المحلي\r\nوالدولي، والعالمي.\r\n- رصد الممارسات والبرامج والفعاليات والأنشطة التي تتبناها لأجل تأصيل حب اللغة العربية في المجتمع المدرسي تواصلاً وإبداعاً.",
                        EnglishDescription = "Monitoring practices and activities that demonstrate the dissemination and consolidation of the school community’s pride in its Arabic language at the school and local community levels\r\nInternational, and global.\r\n- Monitoring the practices, programmes, events and activities it adopts in order to establish the love of the Arabic language in the school community through communication and creativity.",
                        CriterionId = 3,
                        CriterionItemId = 7,
                        ArbitrationScaleId = 1
                    });
                _context.SaveChanges();
            }
        }
    }
}
