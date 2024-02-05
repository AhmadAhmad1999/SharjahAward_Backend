using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionItemScaleModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.ScaleModel; 

public class Scale : AuditInformation<User> {
    public Guid Id { get; set; }
    // the arabic title of the score 
    public string ArabicName { get; set; } = string.Empty;
    // the english title of the score
    public string EnglishName { get; set; } = string.Empty;
    // the min-score of the scale 
    public int MinScore { get; set; }
    // the max-score of the scale
    public int MaxScore { get; set; }
   
    // navigation property to the criterion
    public Criterion Criterion { get; set; } = null!;
    [ForeignKey(nameof(Criterion))]
    public Guid CriterionId { get; set;  }
    
    
    // navigation property to the criterion-item => many-to-many relation 
    public virtual List<CriterionItem> CriterionItems { get; set; } = new();
    public virtual List<CriterionItemScale> CriterionItemScales { get; set; } = new();
}