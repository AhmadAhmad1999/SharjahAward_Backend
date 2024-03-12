using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Coordinators.Queries.SearchForCoordinator
{
    public class SearchForCoordinatorQuery : IRequest<BaseResponse<List<CoordinatorSearchListVM>>>
    {
        public string? EducationalEntityName { get; set; } = string.Empty;
        public EducationType? EducationType { get; set; }
        public string? ShcoolName { get; set; } = string.Empty;
        public Emirates? Emirates { get; set; }
        public string lang { get; set;} = string.Empty;
    }
}
