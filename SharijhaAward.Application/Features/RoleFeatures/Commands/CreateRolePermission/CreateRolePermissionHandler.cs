using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.CreateRolePermission
{
    public class CreateRolePermissionHandler : IRequestHandler<CreateRolePermissionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;

        public CreateRolePermissionHandler(IAsyncRepository<RolePermission> RolePermissionRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<UserToken> UserTokenRepository)
        {
            _RolePermissionRepository = RolePermissionRepository;
            _UserRoleRepository = UserRoleRepository;
            _UserTokenRepository = UserTokenRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateRolePermissionCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<UserRole> UserRoleEntitiesToDelete = await _UserRoleRepository
                .Where(x => x.RoleId == Request.RoleId)
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

                    await _UserRoleRepository.DeleteListAsync(UserRoleEntitiesToDelete);

                    await _UserTokenRepository.DeleteListAsync(UserTokenEntitiesToDelete);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إضافة الصلاحية لهذا الدور بنجاح";

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
