using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.TermsAndConditionsModel; 

public class TermAndCondition: AuditableEntity {
    public Guid Id { get; set; } 
   // arabic title of the term
    public string ArabicTitle { get; set; } = string.Empty;
   // english title of the term
    public string EnglishTitle { get; set; } = string.Empty;
   // arabic description of the terms 
    public string ArabicDescription { get; set; } = string.Empty;
   // english description of the term
    public string EnglishDescription { get; set; } = string.Empty;
    public bool? IsSpecial { get; set; } = false;
    // need attachment or not 
    public bool NeedAttachment { get; set; } = false;
   // number of required attachment 
    public int? RequiredAttachmentNumber { get; set; }
    public AttachmentType? AttachmentType { get; set; }
    public int? SizeOfAttachmentInKB { get; set; }
    public bool IsAgree { get; set; } = false;
    // navigation property to the category 
    [ForeignKey(nameof(Category))]
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public List<ConditionsAttachment> Attachments { get; set; } = null!;

}