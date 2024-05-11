using MediatR;
using SharijhaAward.Application.Features.RoleFeatures.Queries.GetRoleById;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetUsersByRolesIds
{
    public class GetUsersByRolesIdsQuery : IRequest<BaseResponse<List<UsersInRoleDto>>>
    {
        public List<int> RolesIds { get; set; } = new List<int>();
        public string? lang { get; set; }
    }
}
