using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class GetInitialArbitrationByArbitrationIdQuery : IRequest<BaseResponse<List<MainCriterionDto>>>
    {
        public int ArbitrationId { get; set; }
        public string? lang { get; set; }
    }
}
