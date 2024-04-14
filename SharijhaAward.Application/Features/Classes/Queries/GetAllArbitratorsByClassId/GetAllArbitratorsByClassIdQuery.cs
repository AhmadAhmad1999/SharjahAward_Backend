using MediatR;
using SharijhaAward.Application.Features.Arbitrators.Queries.GetAllArbitrators;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Classes.Queries.GetAllArbitratorsByClassId
{
    public class GetAllArbitratorsByClassIdQuery : IRequest<BaseResponse<List<GetAllArbitratorsListVM>>>
    {
        public int EducationalClassId { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public string? lang { get; set; }
    }
}
