using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.DeleteRolePermission
{
    public class DeleteRolePermissionCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}