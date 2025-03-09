using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.GeneralWorkshops.Queries.GetAllGeneralWorkshops
{
    public class GetAllGeneralWorkshopsQuery : IRequest<BaseResponse<List<GeneralWorkshopsListVM>>>
    {
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string lang { get; set; } = string.Empty;
        public string query { get; set; } = string.Empty;
        public List<Filter>? filters { get; set; }
    }
}
