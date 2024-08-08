using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Cycles.Queries.GetActiveCycle
{
    public class GetActiveCycleQuery : IRequest<BaseResponse<bool>>
    {
        public string? lang { get; set; }
    }
}
