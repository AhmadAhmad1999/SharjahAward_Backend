using SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionByCycleId;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetAllCycleConditions
{
    public class CycleConditionListVM
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public bool NeedAttachment { get; set; } = false;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public int CycleId { get; set; }
        public DateTime CreatedAt { get; set; }
        public CycleConditionProvidedFormListVm? Acceptance { get; set; }
        public List<CycleConditionAttachmentListVm> Attachments { get; set; } = null!;
    }
}
