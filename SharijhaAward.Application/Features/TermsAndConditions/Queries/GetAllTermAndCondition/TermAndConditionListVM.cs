using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition
{
    public class TermAndConditionListVM
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? ArabicDescription { get; set; }
        public string? EnglishDescription { get; set; }
        public bool NeedAttachment { get; set; } = false;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public bool? Rejected { get; set; } = false;
        public bool? IsSpecial { get; set; } = false;
        public int CategoryId { get; set; }
        public DateTime CreateAt {  get; set; }
        public ConditionProvidedFormListVm? ConditionsAttachments { get; set; }
    }
}
