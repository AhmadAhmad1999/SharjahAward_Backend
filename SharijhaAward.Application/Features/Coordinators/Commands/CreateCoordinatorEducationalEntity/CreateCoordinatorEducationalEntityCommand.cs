using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorEducationalEntity
{
    public class CreateCoordinatorEducationalEntityCommand : IRequest<BaseResponse<object>>
    {
        public Guid CoordinatorId { get; set; }
        public Guid EducationalEntityId { get; set; }
        public DateTime RelatedDate { get; set; }
        public string? lang { get; set; }
    }
}
