using SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachmentByFormId;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.ExtraAttachments.Queries.GetAllExtraAttachment
{
    public class ExtraAttachmentListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public int RequiredAttachmentNumber { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public bool? Rejected { get; set; } = false;
        public int SizeOfAttachmentInKB { get; set; }
        public List<AttachmentDto>? AttachmentList { get; set; }
    }
}
