using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CriterionItemScaleModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ScaleModel;

namespace SharijhaAward.Domain.Entities.CriterionItemModel; 

public class CriterionItem : AuditInformation<User> {
   public Guid Id { get; set; }
   // the arabic name of the criterion item
   public string ArabicName { get; set; } = string.Empty;
   // the english name of the criterion item
   public string EnglishName { get; set; } = string.Empty;
   // the score of the criterion item
   public int Score { get; set; }
   // the actual score of the criterion item
   public int ActualScore { get; set; }
   // navigation property to the criterion item
   public Criterion Criterion { get; set; } = null!;
   public Guid CriterionId { get; set; }
   
   
    // navigation property to the scale => many-to-many relation 
    public virtual List<Scale> Scales { get; set; } = new();
    public virtual List<CriterionItemScale> CriterionItemScales { get; set; } = new();
}