using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class GetFinalArbitrationByIdQuery : IRequest<BaseResponse<List<MainCriterionForFinalArbitrationScoreDto>>>
    {
        public int FormId { get; set; }
        public string? lang { get; set; }
    }
}
