using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutionsWithPagination
{
    public class GetAllEducationalInstitutionsWithPaginationQuery : IRequest<BaseResponse<List<EducationalInstitutionListVM>>>
    {
        public int EducationalEntityId { get; set; }
        public string? lang { get; set; }
        public int page { get; set; }
        public int perPage { get; set; }
    }
}
