using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.CreateRolePermission
{
    public class CreateRolePermissionHandler : IRequestHandler<CreateRolePermissionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;

        public CreateRolePermissionHandler(IAsyncRepository<RolePermission> RolePermissionRepository)
        {
            _RolePermissionRepository = RolePermissionRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateRolePermissionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            RolePermission NewRolePermissionEntity = new RolePermission()
            {
                isDeleted = false,
                DeletedAt = null,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                RoleId = Request.RoleId,
                PermissionId = Request.PermissionId
            };

            await _RolePermissionRepository.AddAsync(NewRolePermissionEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إضافة الصلاحية لهذا الدور بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
