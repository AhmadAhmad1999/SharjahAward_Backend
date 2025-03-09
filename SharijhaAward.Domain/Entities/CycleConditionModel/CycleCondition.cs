using System.ComponentModel.DataAnnotations.Schema;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Domain.Entities.CycleConditionModel; 

public class CycleCondition : AuditableEntity
{
    public int Id { get; set; }
    public string ArabicDescription { get; set; } = string.Empty;
    public string EnglishDescription { get; set; } = string.Empty;
    public bool NeedAttachment { get; set; } = false;
    public int? RequiredAttachmentNumber { get; set; }
    public int? SizeOfAttachmentInKB { get; set; }
    public bool IsAgree { get; set; } = false;
    public Cycle Cycle { get; set; } = null!;
    [ForeignKey(nameof(Cycle))]
    public int CycleId { get; set; }

    //public List<CycleConditionsProvidedForm> ConditionAttachments { get; set; } = null!;
}