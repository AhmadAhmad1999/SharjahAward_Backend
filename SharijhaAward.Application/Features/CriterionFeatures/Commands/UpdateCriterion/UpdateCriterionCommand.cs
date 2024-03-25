using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.UpdateCriterion
{
    public class UpdateCriterionCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public string? lang { get; set; }
    }
}
