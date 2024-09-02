using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.DeleteRolePermission
{
    public class DeleteRolePermissionHandler : IRequestHandler<DeleteRolePermissionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;

        public DeleteRolePermissionHandler(IAsyncRepository<RolePermission> RolePermissionRepository)
        {
            _RolePermissionRepository = RolePermissionRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteRolePermissionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            RolePermission? RolePermissionEntityToDelete = await _RolePermissionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (RolePermissionEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Role's permission is not found"
                    : "صلاحية الدور غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _RolePermissionRepository.DeleteAsync(RolePermissionEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Role's permission has been deleted successfully"
                : "تم حذف صلاحية الدور بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
