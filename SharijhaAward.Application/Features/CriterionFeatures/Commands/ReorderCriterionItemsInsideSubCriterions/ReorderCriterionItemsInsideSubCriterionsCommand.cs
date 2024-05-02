using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.ReorderCriterionItemsInsideSubCriterions
{
    public class ReorderCriterionItemsInsideSubCriterionsCommand : IRequest<BaseResponse<object>>
    {
        public List<MainCriterionsDto> MainCriterionsDtos { get; set; } = new List<MainCriterionsDto>();
        public string? lang { get; set; }
    }
}
