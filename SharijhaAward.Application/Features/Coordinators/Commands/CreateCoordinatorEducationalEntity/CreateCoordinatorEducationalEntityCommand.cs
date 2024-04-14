using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinatorEducationalEntity
{
    public class CreateCoordinatorEducationalEntityCommand : IRequest<BaseResponse<object>>
    {
        public int CoordinatorId { get; set; }
        public int EducationalEntityId { get; set; }
        public DateTime RelatedDate { get; set; }
        public string? lang { get; set; }
    }
}
