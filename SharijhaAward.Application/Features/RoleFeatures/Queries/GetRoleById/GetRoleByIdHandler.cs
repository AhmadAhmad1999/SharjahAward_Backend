using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetRoleById
{
    public class GetRoleByIdHandler : IRequestHandler<GetRoleByIdQuery, BaseResponse<GetRoleByIdDto>>
    {
        private readonly IAsyncRepository<Role> _RoleRepository;
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;
        public GetRoleByIdHandler(IAsyncRepository<Role> RoleRepository,
            IAsyncRepository<RolePermission> RolePermissionRepository)
        {
            _RoleRepository = RoleRepository;
            _RolePermissionRepository = RolePermissionRepository;
        }
        public async Task<BaseResponse<GetRoleByIdDto>> Handle(GetRoleByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Role? RoleEntity = await _RoleRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (RoleEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Role is not Found"
                    : "الدور غير موجود";

                return new BaseResponse<GetRoleByIdDto>(ResponseMessage, false, 404);
            }

            List<int> PermissionsIds = await _RolePermissionRepository
                .Where(x => x.RoleId == Request.Id)
                .Select(x => x.PermissionId)
                .OrderByDescending(x => x)
                .ToListAsync();

            GetRoleByIdDto Response = new GetRoleByIdDto()
            {
                Id = RoleEntity.Id,
                ArabicName = RoleEntity.ArabicName,
                EnglishName = RoleEntity.EnglishName,
                PermissionsIds = PermissionsIds
            };

            return new BaseResponse<GetRoleByIdDto>(ResponseMessage, true, 200, Response);
        }
    }
}
