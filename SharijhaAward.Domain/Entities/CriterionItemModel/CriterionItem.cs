using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.CriterionItemScaleModel;
using SharijhaAward.Domain.Model.CriterionModel;
using SharijhaAward.Domain.Model.IdentityModels;
using SharijhaAward.Domain.Model.ScaleModel;

namespace SharijhaAward.Domain.Model.CriterionItemModel; 

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