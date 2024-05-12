using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Domain.Entities.CategoryEducationalClassModel
{
    public class CategoryEducationalClass : AuditableEntity
    {
        public int Id { get; set; }
        public int EducationalClassId { get; set; }
        public EducationalClass? EducationalClass { get; set; }
        public int CategoryId { get; set; } // 2, 5, 7, 8
        public Category? Category { get; set; }
        public int NumberOfExpectedWinners { get; set; }
    }
}
