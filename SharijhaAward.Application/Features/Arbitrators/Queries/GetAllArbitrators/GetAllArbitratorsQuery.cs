using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators
{
    public class GetAllArbitratorsQuery : IRequest<BaseResponse<List<GetAllArbitratorsListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
