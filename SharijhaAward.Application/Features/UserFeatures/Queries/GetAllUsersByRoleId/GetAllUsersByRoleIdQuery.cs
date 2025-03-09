using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUsersByRoleId
{
    public class GetAllUsersByRoleIdQuery : IRequest<BaseResponse<List<GetAllUsersByRoleIdListVM>>>
    {
        public string RoleEnglishName { get; set; } = null!;
        public string? lang { get; set; }
    }
}
