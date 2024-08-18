using MediatR;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllArbitratorsByClassId
{
    public class GetAllArbitratorsByClassIdQuery : IRequest<BaseResponse<List<ArbitratorsListVM>>>
    {
        public int EducationalClassId { get; set; }
        public List<Filter>? filters { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? lang { get; set; }
    }
}
