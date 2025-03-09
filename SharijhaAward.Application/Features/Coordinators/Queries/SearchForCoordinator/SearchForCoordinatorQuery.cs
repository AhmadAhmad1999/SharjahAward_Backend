using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator
{
    public class SearchForCoordinatorQuery : IRequest<BaseResponse<List<CoordinatorSearchListVM>>>
    {
        public int? EducationalEntity { get; set; } 
        public EducationType? EducationType { get; set; }
        public int? School { get; set; } 
        public Emirates? Emirates { get; set; }
        public string lang { get; set;} = string.Empty;
    }
}
