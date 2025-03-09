using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.CycleConditions.Commands.CreateCycleCondition
{
    public class CreateCycleConditionCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicDescription { get; set; } = string.Empty;
        public string EnglishDescription { get; set; } = string.Empty;
        public bool NeedAttachment { get; set; } = false;
        public int? RequiredAttachmentNumber { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public List<AttachmentType> AttachmentType { get; set; } = new List<AttachmentType>();
        public bool IsAgree { get; set; } = false;
        public int CycleId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
