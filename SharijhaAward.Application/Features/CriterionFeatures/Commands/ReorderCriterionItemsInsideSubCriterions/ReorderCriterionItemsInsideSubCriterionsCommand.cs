using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.ReorderCriterionItemsInsideSubCriterions
{
    public class ReorderCriterionItemsInsideSubCriterionsCommand : IRequest<BaseResponse<object>>
    {
        public List<SubCriterionItemsDto> SubCriterionItemsDto { get; set; } = new List<SubCriterionItemsDto>();
        public string? lang { get; set; }
    }
}
