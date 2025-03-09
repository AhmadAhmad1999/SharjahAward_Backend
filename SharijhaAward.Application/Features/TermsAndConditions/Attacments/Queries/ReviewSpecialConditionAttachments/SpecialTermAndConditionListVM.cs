using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.TermsAndConditions.Attacments.Queries.ReviewSpecialConditionAttachments
{
    public class SpecialTermAndConditionListVM
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? ArabicDescription { get; set; }
        public string? EnglishDescription { get; set; }
        public bool NeedAttachment { get; set; } = false;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public AttachmentType? AttachmentType { get; set; }
        public bool? IsSpecial { get; set; } = false;
        public int CategoryId { get; set; }
        public DateTime CreateAt { get; set; }
        public ConditionProvidedFormListVm? Acceptance { get; set; }
        public List<AttachmentListVM>? Attachments { get; set; } = null!;
    }
}
