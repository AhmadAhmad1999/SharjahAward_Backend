using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Queries.GetAllFormsForSortingProcess
{
    public class GetAllFormsForSortingProcessQuery : IRequest<BaseResponse<List<GetAllFormsForSortingProcessListVM>>>
    {
        public string? token { get; set; }
        public bool? AsChairman { get; set; }
        public bool AsFullAccess { get; set; }
        public GetAllFormsForSortingProcessFilter? filter { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
    }
}
