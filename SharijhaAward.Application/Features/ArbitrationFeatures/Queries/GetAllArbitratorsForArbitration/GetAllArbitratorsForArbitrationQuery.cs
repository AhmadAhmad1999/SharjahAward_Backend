using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllArbitratorsForArbitration
{
    public class GetAllArbitratorsForArbitrationQuery : IRequest<BaseResponse<List<GetAllArbitratorsForArbitrationListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
