using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilitiesByUserId
{
    public class GetAllResponsibilitiesByUserIdQuery : IRequest<BaseResponse<List<GetAllResponsibilitiesByUserIdListVM>>>
    {
        public int? UserId { get; set; }
        public string? UserToken { get; set; }
        public string? lang { get; set; }

    }
}
