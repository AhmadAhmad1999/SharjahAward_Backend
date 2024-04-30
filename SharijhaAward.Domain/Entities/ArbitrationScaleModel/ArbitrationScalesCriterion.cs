using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Domain.Entities.ArbitrationScaleModel
{
    public class ArbitrationScalesCriterion : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public int? CriterionId { get; set; }
        public Criterion? Criterion { get; set; }
        public int? CriterionItemId { get; set; }
        public CriterionItem? CriterionItem { get; set; }
        public int ArbitrationScaleId { get; set; }
        public ArbitrationScale? ArbitrationScale { get; set; }
    }
}
