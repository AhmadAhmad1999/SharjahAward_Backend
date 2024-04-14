using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CriterionFeatures.Queries.GetCriterionItemById
{
    public class GetCriterionItemByIdQuery : IRequest<BaseResponse<GetCriterionItemByIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
