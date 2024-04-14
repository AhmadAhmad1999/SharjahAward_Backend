using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorInstitution
{
    public class CreateCoordinatorInstitutionCommand : IRequest<BaseResponse<object>>
    {
        public int CoordinatorId { get; set; }
        public int EducationalInstitutionId { get; set; }
        public string? lang { get; set; }
    }
}
