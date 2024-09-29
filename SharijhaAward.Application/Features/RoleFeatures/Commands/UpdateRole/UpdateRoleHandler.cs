using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.UpdateRole
{
    public class UpdateRoleHandler : IRequestHandler<UpdateRoleCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Role> _RoleRepository;
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public UpdateRoleHandler(IMapper Mapper,
            IAsyncRepository<Role> RoleRepository,
            IAsyncRepository<RolePermission> RolePermissionRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _RoleRepository = RoleRepository;
            _Mapper = Mapper;
            _RolePermissionRepository = RolePermissionRepository;
            _UserTokenRepository = UserTokenRepository;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateRoleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Role? RoleEntityToUpdate = await _RoleRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (RoleEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Role is not found"
                    : "الدور غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Role? CheckRoleNameIfUnique = await _RoleRepository
                .FirstOrDefaultAsync(x => (x.ArabicName.ToLower() == Request.ArabicName.ToLower() ||
                    x.EnglishName.ToLower() == Request.EnglishName.ToLower()) &&
                    x.Id != Request.Id);

            if (CheckRoleNameIfUnique is not null)
            {
                if (CheckRoleNameIfUnique.ArabicName.ToLower() == Request.ArabicName.ToLower())
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Role's arabic name is already used, please insert a different name"
                        : "اسم الدور باللغة العربية مستخدم مسبقاً, الرجاء إدخال اسم مختلف";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
                else if (CheckRoleNameIfUnique.EnglishName.ToLower() == Request.EnglishName.ToLower())
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Role's english name is already used, please insert a different name"
                        : "اسم الدور باللغة الإنكليزية مستخدم مسبقاً, الرجاء إدخال اسم مختلف";

                    return new BaseResponse<object>(ResponseMessage, false, 400);
                }
            }

            List<int> AlreadyExistPermissionIds = await _RolePermissionRepository
                .Where(x => x.RoleId == Request.Id)
                .Select(x => x.PermissionId)
                .ToListAsync();

            List<int> IntersectPermissionIds = AlreadyExistPermissionIds
                .Intersect(Request.PermissionsIds).ToList();

            List<int> NewPermissionIds = Request.PermissionsIds
                .Where(x => !IntersectPermissionIds.Contains(x))
                .ToList();

            List<int> DeletePermissionIds = AlreadyExistPermissionIds
                .Where(x => !IntersectPermissionIds.Contains(x))
                .ToList();

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
                    _Mapper.Map(Request, RoleEntityToUpdate, typeof(UpdateRoleCommand), typeof(Role));

                    await _RoleRepository.UpdateAsync(RoleEntityToUpdate);

                    IQueryable<RolePermission> DeleteRolePermissionEntites = _RolePermissionRepository
                        .Where(x => x.RoleId == Request.Id &&
                            DeletePermissionIds.Contains(x.PermissionId));

                    if (DeleteRolePermissionEntites.Count() > 0)
                        await _RolePermissionRepository.DeleteListAsync(DeleteRolePermissionEntites);

                    IEnumerable<RolePermission> NewRolePermissionEntites = NewPermissionIds
                        .Select(x => new RolePermission()
                        {
                            RoleId = Request.Id,
                            PermissionId = x,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null
                        });

                    if (NewPermissionIds.Any() || DeletePermissionIds.Any() ||
                        Request.HaveFullAccess != RoleEntityToUpdate.HaveFullAccess)
                    {
                        await _RolePermissionRepository.AddRangeAsync(NewRolePermissionEntites);

                        List<int> UsersIds = await _UserRoleRepository
                            .Where(x => x.RoleId == Request.Id)
                            .Select(x => x.UserId)
                            .ToListAsync();

                        List<UserToken> UserTokenEntitiesToDelete = await _UserTokenRepository
                            .Where(x => UsersIds.Contains(x.UserId))
                            .ToListAsync();

                        await _UserTokenRepository.DeleteListAsync(UserTokenEntitiesToDelete);
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Role has been updated successfully"
                        : "تم تعديل الدور بنجاح";

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
