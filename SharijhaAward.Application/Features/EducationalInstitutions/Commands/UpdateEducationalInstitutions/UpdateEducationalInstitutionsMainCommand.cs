using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalInstitutions.Commands.UpdateEducationalInstitutions
{
    public class UpdateEducationalInstitutionsMainCommand : IRequest<BaseResponse<object>>
    {
        public string? lang { get; set; }
        public List<UpdateEducationalInstitutionsCommand> UpdateEducationalInstitutionsCommand { get; set; } = new List<UpdateEducationalInstitutionsCommand>();
    }
}
