using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.DeleteRolePermission
{
    public class DeleteRolePermissionHandler : IRequestHandler<DeleteRolePermissionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;

        public DeleteRolePermissionHandler(IAsyncRepository<RolePermission> RolePermissionRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<UserToken> UserTokenRepository)
        {
            _RolePermissionRepository = RolePermissionRepository;
            _UserRoleRepository = UserRoleRepository;
            _UserTokenRepository = UserTokenRepository;
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

            List<UserRole> UserRoleEntitiesToDelete = await _UserRoleRepository
                .Where(x => x.RoleId == Request.Id)
                .ToListAsync();

            List<UserToken> UserTokenEntitiesToDelete = await _UserTokenRepository
                .Where(x => UserRoleEntitiesToDelete.Select(y => y.UserId).Contains(x.UserId))
                .ToListAsync();

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
                    await _RolePermissionRepository.DeleteAsync(RolePermissionEntityToDelete);

                    await _UserRoleRepository.DeleteListAsync(UserRoleEntitiesToDelete);

                    await _UserTokenRepository.DeleteListAsync(UserTokenEntitiesToDelete);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Role's permission has been deleted successfully"
                        : "تم حذف صلاحية الدور بنجاح";

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
