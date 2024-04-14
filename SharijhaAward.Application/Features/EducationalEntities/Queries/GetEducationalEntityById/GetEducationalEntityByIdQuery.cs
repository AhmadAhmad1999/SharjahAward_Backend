using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.EducationalEntities.Queries.GetEducationalEntityById
{
    public class GetEducationalEntityByIdQuery : IRequest<BaseResponse<GetEducationalEntityByIdDto>>
    {
        public int EducationEntityId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
