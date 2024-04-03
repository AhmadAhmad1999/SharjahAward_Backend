using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorInstitution
{
    public class CreateCoordinatorInstitutionCommand : IRequest<BaseResponse<object>>
    {
        public Guid CoordinatorId { get; set; }
        public Guid EducationalInstitutionId { get; set; }
        public string? lang { get; set; }
    }
}
