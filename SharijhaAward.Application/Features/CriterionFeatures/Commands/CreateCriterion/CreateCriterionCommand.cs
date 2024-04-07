using MediatR;
using SharijhaAward.Application.Responses;
namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.CreateCriterion
{
    public class CreateCriterionCommand : IRequest<BaseResponse<Guid>>
    {
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public int Score { get; set; }
        public int? SizeOfAttachmentInKB { get; set; }
        public Guid CategoryId { get; set; }
        public List<CreateSubCriterionDto> CreateSubCriterionDto { get; set; } = new List<CreateSubCriterionDto>();
        public string? lang { get; set; }
    }
}
