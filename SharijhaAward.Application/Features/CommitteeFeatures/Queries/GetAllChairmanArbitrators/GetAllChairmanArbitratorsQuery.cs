using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetAllChairmanArbitrators
{
    public class GetAllChairmanArbitratorsQuery : IRequest<BaseResponse<List<GetAllChairmanArbitratorsListVM>>>
    {
        public string? lang { get; set; }
    }
}
