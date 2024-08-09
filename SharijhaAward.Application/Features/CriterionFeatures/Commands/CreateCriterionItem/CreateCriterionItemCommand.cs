using MediatR;
using SharijhaAward.Application.Helpers.ArabicNameValidationAttributeHelper;
using SharijhaAward.Application.Helpers.EnglishNameValidationAttributeHelper;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionItem
{
    public class CreateCriterionItemCommand : IRequest<BaseResponse<object>>
    {
        // [ArabicNameValidation(ErrorMessage = "Arabic name must only contain Arabic characters.")]
        public string ArabicName { get; set; } = string.Empty;
        // [EnglishNameValidation(ErrorMessage = "English name must only contain English characters.")]
        public string EnglishName { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public int CriterionId { get; set; }
        public int MaxAttachmentNumber { get; set; }
        public AttachmentType AttachmentType { get; set; }
        public string? lang { get; set; }
    }
}
