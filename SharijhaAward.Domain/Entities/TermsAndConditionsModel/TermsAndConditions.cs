using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Model.CategoryModel;
using SharijhaAward.Domain.Model.Common;
using SharijhaAward.Domain.Model.IdentityModels;

namespace SharijhaAward.Domain.Model.TermsAndConditionsModel; 

public class TermsAndConditions: AuditInformation<User> {
   public Guid Id { get; set; } 
   // arabic title of the term
   public string ArabicTitle { get; set; } = string.Empty;
   // english title of the term
   public string EnglishTitle { get; set; } = string.Empty;
   // arabic description of the terms 
   public string ArabicDescription { get; set; } = string.Empty;
   // english description of the term
   public string EnglishDescription { get; set; } = string.Empty;
   // need attachment or not 
   public bool NeedAttachment { get; set; }
   // number of required attachment 
   public int RequiredAttachmentNumber { get; set; }
   
   // navigation property to the category 
   [ForeignKey(nameof(Category))]
   public Guid CategoryId { get; set; }
   public Category Category { get; set; } = null!;

}