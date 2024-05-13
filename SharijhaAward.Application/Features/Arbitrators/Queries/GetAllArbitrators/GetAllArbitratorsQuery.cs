using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators
{
    public class GetAllArbitratorsQuery : IRequest<BaseResponse<List<GetAllArbitratorsListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public List<Filter>? filters { get; set; }
    }
}
