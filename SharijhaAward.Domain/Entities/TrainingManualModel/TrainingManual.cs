using SharijhaAward.Domain.Model.CategoryModel;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;

namespace SharijhaAward.Domain.Model.TrainingManualModel; 

public class TrainingManual : AuditInformation<User> {
    public Guid Id { get; set; }
    // arabic title of the Training Manual
    public string ArabicTitle { get; set; } = string.Empty;
    
    // english title of the Training Manual
    public string EnglishTitle { get; set; } = string.Empty;
   
    // the arabic version of the Guide => file
    public string ArabicGuide { get; set; } = string.Empty;
    
    // the english version of the Guide => file
    public string EnglishGuide { get; set; } = string.Empty;
    
   // navigation property to the category 
   public Guid CategoryId { get; set; }
   public Category Category { get; set; } = null!;

}