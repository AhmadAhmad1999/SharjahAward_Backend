using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class GetCoordinatorByIdQuery : IRequest<BaseResponse<GetCoordinatorByIdResponse>>
    {
        public Guid CoordinatorId { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
