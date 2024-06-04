using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.CreateEducationalInstitution
{
    public class CreateEducationalInstitutionMainCommand : IRequest<BaseResponse<object>>
    {
        public int EducationalEntityId { get; set; }
        public string? lang { get; set; }
        public List<CreateEducationalInstitutionCommand> CreateEducationalInstitutionCommand { get; set; } = new List<CreateEducationalInstitutionCommand>();
    }
}
