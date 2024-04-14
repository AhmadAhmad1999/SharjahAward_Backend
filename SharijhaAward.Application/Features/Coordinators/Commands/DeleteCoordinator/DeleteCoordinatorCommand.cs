using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinator
{
    public class DeleteCoordinatorCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
