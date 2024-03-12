using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ScaleModel;

namespace SharijhaAward.Domain.Entities.CriterionItemScaleModel;

public class CriterionItemScale : AuditableEntity
{
    public Guid Id {  get; set; }
    public Guid ScalesId { get; set; }
    public Scale Scale { get; set; } = null!;
    public Guid CriterionItemsId { get; set; }
    public CriterionItem CriterionItem { get; set; } = null!;
    public string ArabicDescription { get; set; } = string.Empty;
    public string EnglishDescription { get; set; } = string.Empty;
}