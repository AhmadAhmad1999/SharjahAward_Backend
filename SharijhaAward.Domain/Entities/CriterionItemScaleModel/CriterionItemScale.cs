using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ScaleModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Domain.Entities.CriterionItemScaleModel;

// the pivot table between the scale and criterion-item
public class CriterionItemScale : AuditInformation<User> {
    [Key]
    public Guid Id {  get; set; }
    // navigation property to the scale
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public Scale Scale { get; set; } = null!;
    [ForeignKey(nameof(Scale))]
    public Guid ScalesId { get; set; }
    
    // navigation property to the criterion item
    [DeleteBehavior(DeleteBehavior.NoAction)]
    public CriterionItem CriterionItem { get; set; } = null!;
    [ForeignKey(nameof(CriterionItem))]
    public Guid CriterionItemsId { get; set; }
    
    // the arabic description 
    public string ArabicDescription { get; set; } = string.Empty;
    
    // the english description 
    public string EnglishDescription { get; set; } = string.Empty;

}