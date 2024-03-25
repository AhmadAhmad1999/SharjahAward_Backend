using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterionItem
{
    public class CreateCriterionItemCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicName { get; set; } = string.Empty;
        public string EnglishName { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public Guid CriterionId { get; set; }
        public string? lang { get; set; }
    }
}
