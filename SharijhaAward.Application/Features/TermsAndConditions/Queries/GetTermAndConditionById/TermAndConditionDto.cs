using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetTermAndConditionById
{
    public class TermAndConditionDto
    {
        public int Id { get; set; }
        public string? Description { get; set; } 
        public string? ArabicDescription { get; set; }
        public string? EnglishDescription { get; set; }
        public bool? IsSpecial { get; set; } = false;
        public bool NeedAttachment { get; set; } = false;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public bool IsAgree { get; set; }
        public int CategoryId { get; set; }
    }
}
