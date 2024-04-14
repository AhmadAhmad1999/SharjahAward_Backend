using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateSubCriterion
{
    public class CreateSubCriterionCommand : IRequest<BaseResponse<int>>
    {
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public int ParentId { get; set; }
        public string? lang { get; set; }
    }
}
