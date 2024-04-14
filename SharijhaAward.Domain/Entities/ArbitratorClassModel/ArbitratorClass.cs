using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;

namespace SharijhaAward.Domain.Entities.ArbitratorClassModel
{
    public class ArbitratorClass : AuditableEntity
    {
        public int Id { get; set; }
        public int EducationalClassId { get; set; }
        public EducationalClass? EducationalClass { get; set; }
        public int ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
    }
}
