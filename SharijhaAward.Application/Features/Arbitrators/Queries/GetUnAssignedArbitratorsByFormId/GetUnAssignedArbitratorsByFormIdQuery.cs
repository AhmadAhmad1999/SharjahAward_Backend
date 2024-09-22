using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetUnAssignedArbitratorsByFormId
{
    public class GetUnAssignedArbitratorsByFormIdQuery : IRequest<BaseResponse<List<GetUnAssignedArbitratorsByFormIdListVM>>>
    {
        public int ProvidedFormId { get; set; }
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? lang { get; set; }
    }
}
