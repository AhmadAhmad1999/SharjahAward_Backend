using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;

namespace SharijhaAward.Domain.Entities.ArbitratorClassModel
{
    public class ArbitratorClass : AuditableEntity
    {
        public int Id { get; set; }
        public int CategoryEducationalClassId { get; set; }
        public CategoryEducationalClass? CategoryEducationalClass { get; set; }
        public int ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
    }
}
