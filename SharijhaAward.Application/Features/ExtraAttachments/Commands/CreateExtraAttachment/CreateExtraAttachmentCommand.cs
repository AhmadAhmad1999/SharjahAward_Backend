using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.ExtraAttachments.Commands.CreateExtraAttachment
{
    public class CreateExtraAttachmentCommand : IRequest<BaseResponse<int>>
    {
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public int RequiredAttachmentNumber { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public int SizeOfAttachmentInKB { get; set; }
        public int ProvidedFormId { get; set; }
        public string lang { get; set; } = string.Empty;

        public bool FromArbitrationStep { get; set; }
    }
}
