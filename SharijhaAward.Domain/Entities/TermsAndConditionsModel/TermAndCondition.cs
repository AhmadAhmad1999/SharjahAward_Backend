using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;

namespace SharijhaAward.Domain.Entities.TermsAndConditionsModel;

public class TermAndCondition : AuditableEntity {
    public int Id { get; set; } 
    public string? ArabicDescription { get; set; } = string.Empty;
    public string? EnglishDescription { get; set; } = string.Empty;
    public bool NeedAttachment { get; set; } = false;
    public int? RequiredAttachmentNumber { get; set; }
    public int? SizeOfAttachmentInKB { get; set; }
    public bool IsAgree { get; set; } = false;

    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;
}