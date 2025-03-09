using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetActiveCycleData
{
    public class GetActiveCycleDataQuery : IRequest<BaseResponse<GetActiveCycleDataDto>>
    {
        public string? lang { get; set; }
    }
}
