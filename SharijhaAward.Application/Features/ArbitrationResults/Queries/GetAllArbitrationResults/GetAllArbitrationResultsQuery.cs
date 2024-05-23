using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.GetAllArbitrationResults
{
    public class GetAllArbitrationResultsQuery : IRequest<BaseResponse<List<GetAllArbitrationResultsListVM>>>
    {
        public string? lang { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
    }
}
