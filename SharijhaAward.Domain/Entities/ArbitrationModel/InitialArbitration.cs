using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Domain.Entities.ArbitrationModel
{
    public class InitialArbitration : AuditableEntity
    {
        public int Id { get; set; }
        public int CriterionId { get; set; }
        public Criterion? Criterion { get; set; }
        public int ArbitrationId { get; set; }
        public Arbitration? Arbitration { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
    }
}
