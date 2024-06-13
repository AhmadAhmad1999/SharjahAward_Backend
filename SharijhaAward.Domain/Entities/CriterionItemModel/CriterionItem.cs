using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Domain.Entities.CriterionItemModel
{
    public class CriterionItem : AuditableEntity
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public int Score { get; set; }
        public int ActualScore { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public int CriterionId { get; set; }
        public Criterion Criterion { get; set; } = null!;
        public int MaxAttachmentNumber { get; set; }
        public AttachmentType AttachmentType { get; set; }
        //public virtual List<Scale> Scales { get; set; } = new();
        //public virtual List<CriterionItemScale> CriterionItemScales { get; set; } = new();
    }
}