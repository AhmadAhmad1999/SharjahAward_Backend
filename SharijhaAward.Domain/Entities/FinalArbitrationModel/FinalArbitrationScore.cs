using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Domain.Entities.FinalArbitrationModel
{
    public class FinalArbitrationScore : AuditableEntity
    {
        public int Id { get; set; }
        public int? CriterionId { get; set; }
        public Criterion? Criterion { get; set; }
        public int? CriterionItemId { get; set; }
        public CriterionItem? CriterionItem { get; set; }
        public int FinalArbitrationId { get; set; }
        public FinalArbitration? FinalArbitration { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
    }
}
