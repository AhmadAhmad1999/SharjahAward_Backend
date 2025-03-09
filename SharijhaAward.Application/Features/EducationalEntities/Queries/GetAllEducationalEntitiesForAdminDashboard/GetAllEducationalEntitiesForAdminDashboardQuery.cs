using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetAllEducationalEntitiesForAdminDashboard
{
    public class GetAllEducationalEntitiesForAdminDashboardQuery : IRequest<BaseResponse<List<GetAllEducationalEntitiesForAdminDashboardListVM>>>
    {
        public int? CycleId { get; set; }
        public string? lang { get; set; }
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
    }
}
