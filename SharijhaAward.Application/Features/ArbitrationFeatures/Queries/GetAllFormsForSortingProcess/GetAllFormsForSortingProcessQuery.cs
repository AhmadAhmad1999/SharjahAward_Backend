using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllFormsForSortingProcess
{
    public class GetAllFormsForSortingProcessQuery : IRequest<BaseResponse<List<GetAllFormsForSortingProcessListVM>>>
    {
        public string? token { get; set; }
        public GetAllFormsForSortingProcessFilter? Filter { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
