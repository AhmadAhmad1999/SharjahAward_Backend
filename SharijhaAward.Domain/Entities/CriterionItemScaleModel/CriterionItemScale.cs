using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.CriterionItemModel;
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.ScaleModel;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Domain.Model.CriterionItemScaleModel;

// the pivot table between the scale and criterion-item
public class CriterionItemScale : AuditInformation<User> {
    [Key]
    public int Id {  get; set; }
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