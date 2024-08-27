using SharijhaAward.Domain.Entities.AboutAwardPageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Persistence.Seeders
{
    public class OurGoalSeeder
    {
        private readonly SharijhaAwardDbContext _context;

        public OurGoalSeeder(SharijhaAwardDbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.OurGoals.Any())
            {
                _context.OurGoals.AddRange(
                   new OurGoal()
                   {
                       // Id = 1,
                       isDeleted = false,
                       DeletedAt = null,
                       LastModifiedAt = null,
                       LastModifiedBy = null,
                       CreatedAt = DateTime.UtcNow,
                       CreatedBy = null,
                       AboutAwardPageId = 1,
                       ArabicGoal = "1- تطوير القطاع التربوي من خلال بث روح التنافس بينهم؛ لتحقيق أفضل الممارسات التربوية. 2- تطوير أعمال الجائزة ومنهجياتها، ورفع الكفايات المهنية للعاملين بها. 3- دعم الطلاب المتميزين في مختلف المجالات، وإكسابهم مهارات متنوعة ومتكاملة. 4- تبني منهجية مبتكرة لاستقطاب وبناء الشراكات الداعمة للجائزة والتعليم.",
                       EnglishGoal = "1- Developing the educational sector by spreading the spirit of competition among them; To achieve best educational practices. 2- Developing the Award’s work and methodologies, and raising the professional competencies of its employees. 3- Supporting distinguished students in various fields, and providing them with diverse and integrated skills. 4- Adopting an innovative methodology to attract and build partnerships that support the award and education."
                   });
                _context.SaveChanges();
            }
        }
    }
}
