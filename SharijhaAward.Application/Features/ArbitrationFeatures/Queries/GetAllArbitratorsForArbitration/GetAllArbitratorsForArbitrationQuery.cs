using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllArbitratorsForArbitration
{
    public class GetAllArbitratorsForArbitrationQuery : IRequest<BaseResponse<List<GetAllArbitratorsForArbitrationListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
