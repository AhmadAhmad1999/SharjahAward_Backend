using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Entities.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;

namespace SharijhaAward.Domain.Entities.CycleConditionModel; 

public class CycleCondition : AuditableEntity
{
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
    public Cycle Cycle { get; set; } = null!;
    [ForeignKey(nameof(Cycle))]
    public Guid CycleId { get; set; }

    public List<CycleConditionsProvidedForm> ConditionAttachments { get; set; } = null!;
}