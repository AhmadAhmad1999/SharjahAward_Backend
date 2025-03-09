using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.TermsAndConditions.Commands.CreateTermAndCondition
{
    public class CreateTermAndConditionCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public bool NeedAttachment { get; set; } = false;
        public bool? IsSpecial { get; set; } = true;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public bool IsAgree { get; set; } = false;
        public int CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
