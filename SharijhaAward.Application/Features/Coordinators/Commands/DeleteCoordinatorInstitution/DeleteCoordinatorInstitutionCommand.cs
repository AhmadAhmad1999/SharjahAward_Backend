using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinatorInstitution
{
    public class DeleteCoordinatorInstitutionCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string? lang { get; set; }
    }
}
