using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.CreateRolePermission
{
    public class CreateRolePermissionCommand : IRequest<BaseResponse<object>>
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }
        public string? lang { get; set; }
    }
}
