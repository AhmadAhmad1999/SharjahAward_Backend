using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Domain.Entities.CategoryClassModel
{
    public class CategoryClass : AuditableEntity
    {
        public int Id { get; set; }
        public int WinnerNumber { get; set; }
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        public int EducationalClassId { get; set; }
        public EducationalClass? EducationalClass { get; set; }
    }
}
