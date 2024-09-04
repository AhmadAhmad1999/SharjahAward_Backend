using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetArbitrationScaleById
{
    public class GetArbitrationScaleByIdQuery : IRequest<BaseResponse<GetArbitrationScaleByIdListVM>>
    {
        public int? CriterionId { get; set; }
        public int? CriterionItemId { get; set; }
        public string? lang { get; set; }
    }
}
