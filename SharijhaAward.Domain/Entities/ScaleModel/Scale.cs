using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionItemScaleModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.ScaleModel; 

public class Scale : AuditableEntity
{
    public Guid Id { get; set; }
    public string ArabicName { get; set; } = string.Empty;
    public string EnglishName { get; set; } = string.Empty;
    public int MinScore { get; set; }
    public int MaxScore { get; set; }
    public Guid CriterionId { get; set;  }
    public Criterion Criterion { get; set; } = null!;
    public virtual List<CriterionItem> CriterionItems { get; set; } = new();
    public virtual List<CriterionItemScale> CriterionItemScales { get; set; } = new();
}