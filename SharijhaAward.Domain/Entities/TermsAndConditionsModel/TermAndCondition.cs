using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Domain.Entities.TermsAndConditionsModel;

public class TermAndCondition: AuditableEntity {
    public Guid Id { get; set; } 
    public string ArabicTitle { get; set; } = string.Empty;
    public string EnglishTitle { get; set; } = string.Empty;
    public string ArabicDescription { get; set; } = string.Empty;
    public string EnglishDescription { get; set; } = string.Empty;
    public bool NeedAttachment { get; set; } = false;
    public int? RequiredAttachmentNumber { get; set; }
    public AttachmentType? AttachmentType { get; set; }
    public int? SizeOfAttachmentInKB { get; set; }
    public bool IsAgree { get; set; } = false;

    [ForeignKey(nameof(Category))]
    public Guid CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public List<ConditionsProvidedForms> ConditionAttachments { get; set; } = null!;

}