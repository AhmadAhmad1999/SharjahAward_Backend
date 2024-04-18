using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetEducationalInstitutionById
{
    public class GetEducationalInstitutionByIdQuery : IRequest<BaseResponse<GetEducationalInstitutionByIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
