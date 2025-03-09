using MediatR;
using SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetAllChairmanArbitrators;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetAllOfficerArbitrators
{
    public class GetAllOfficerArbitratorsQuery : IRequest<BaseResponse<List<GetAllChairmanArbitratorsListVM>>>
    {
        public string? lang { get; set; }
    }
}
