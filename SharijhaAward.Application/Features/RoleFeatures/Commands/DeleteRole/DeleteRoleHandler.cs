using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.DeleteRole
{
    public class DeleteRoleHandler : IRequestHandler<DeleteRoleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Role> _RoleRepository;
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        public DeleteRoleHandler(IAsyncRepository<Role> RoleRepository,
            IAsyncRepository<RolePermission> RolePermissionRepository,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _RoleRepository = RoleRepository;
            _RolePermissionRepository = RolePermissionRepository;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteRoleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    Role? RoleEntityToDelete = await _RoleRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.Id);

                    if (RoleEntityToDelete == null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Role is not found"
                            : "الدور غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    await _RoleRepository.DeleteAsync(RoleEntityToDelete);

                    List<RolePermission> RolePermissionsToDelete = await _RolePermissionRepository
                        .Where(x => x.RoleId == Request.Id)
                        .ToListAsync();

                    await _RolePermissionRepository.DeleteListAsync(RolePermissionsToDelete);

                    List<UserRole> UserRolesToDelete = await _UserRoleRepository
                        .Where(x => x.RoleId == Request.Id)
                        .ToListAsync();

                    await _UserRoleRepository.DeleteListAsync(UserRolesToDelete);

                    ResponseMessage = Request.lang == "en"
                        ? "Role has been deleted successfully"
                        : "تم حذف الدور بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}