using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.UpdateCriterionItem
{
    public class UpdateCriterionItemCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public int MaxAttachmentNumber { get; set; }
        public string? lang { get; set; }
    }
}
