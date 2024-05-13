using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.CommitteeFeatures.Queries.GetAllCommittees
{
    public class GetAllCommitteesQuery : IRequest<BaseResponse<List<GetAllCommitteesListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public List<Filter>? filters { get; set; }
    }
}
