using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUserRoleCategoriesByUserId
{
    public class GetAllUserRoleCategoriesByUserIdQuery : IRequest<BaseResponse<List<GetAllUserRoleCategoriesByUserIdListVM>>>
    {
        public int UserId { get; set; }
        public string? lang { get; set; }
    }
}
