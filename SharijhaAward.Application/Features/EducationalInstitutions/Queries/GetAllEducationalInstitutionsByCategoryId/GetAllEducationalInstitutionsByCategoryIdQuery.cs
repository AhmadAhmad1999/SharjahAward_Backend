using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutionsByCategoryId
{
    public class GetAllEducationalInstitutionsByCategoryIdQuery 
        : IRequest<BaseResponse<List<GetAllEducationalInstitutionsByCategoryIdListVM>>>
    {
        public int CategoryId { get; set; }
        public EducationType? EducationType { get; set; }
        public Emirates? Emirates { get; set; }
        public string? lang { get; set; }
    }
}
