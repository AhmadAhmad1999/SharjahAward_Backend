using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetCommitteeById
{
    public class GetCommitteeByIdQuery : IRequest<BaseResponse<GetCommitteeByIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
