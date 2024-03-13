using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CriterionItemScaleModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ScaleModel;

namespace SharijhaAward.Domain.Entities.CriterionItemModel; 

public class CriterionItem : AuditableEntity
{
    public Guid Id { get; set; }
    public string ArabicName { get; set; } = string.Empty;
    public string EnglishName { get; set; } = string.Empty;
    public int Score { get; set; }
    public int ActualScore { get; set; }
    public int? SizeOfAttachmentInKB { get; set; }
    public Guid CriterionId { get; set; }
    public Criterion Criterion { get; set; } = null!;
    //public virtual List<Scale> Scales { get; set; } = new();
    //public virtual List<CriterionItemScale> CriterionItemScales { get; set; } = new();
}