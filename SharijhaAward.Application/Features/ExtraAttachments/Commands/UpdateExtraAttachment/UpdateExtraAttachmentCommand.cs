using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.ExtraAttachments.Commands.UpdateExtraAttachment
{
    public class UpdateExtraAttachmentCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public int RequiredAttachmentNumber { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public int SizeOfAttachmentInKB { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
