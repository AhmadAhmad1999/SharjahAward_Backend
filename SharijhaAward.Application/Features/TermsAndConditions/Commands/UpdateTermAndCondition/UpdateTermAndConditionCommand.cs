using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.TermsAndConditions.Commands.UpdateTermAndCondition
{
    public class UpdateTermAndConditionCommand :IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public bool NeedAttachment { get; set; } = false;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public bool? IsSpecial { get; set; } = false;
        public int CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
