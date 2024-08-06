using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorEntity
{
    public class CreateCoordinatorEntityCommand : IRequest<BaseResponse<object>>
    {
        public int CoordinatorId { get; set; }
        public int EducationalEntityId { get; set; }
        public string? lang { get; set; }
    }
}
