using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.CreateRole
{
    public class CreateRoleHandler : IRequestHandler<CreateRoleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Role> _RoleRepository;
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;

        public CreateRoleHandler(IAsyncRepository<Role> RoleRepository,
            IAsyncRepository<RolePermission> RolePermissionRepository)
        {
            _RoleRepository = RoleRepository;
            _RolePermissionRepository = RolePermissionRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateRoleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Role? CheckRoleNameIfUnique = await _RoleRepository
                .FirstOrDefaultAsync(x => (x.ArabicName.ToLower() == Request.ArabicName.ToLower() ||
                    x.EnglishName.ToLower() == Request.EnglishName.ToLower()));

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
                    Role NewRoleEntity = new Role()
                    {
                        ArabicName = Request.ArabicName,
                        EnglishName = Request.EnglishName,
                        HaveFullAccess = Request.HaveFullAccess
                    };

                    await _RoleRepository.AddAsync(NewRoleEntity);

                    List<RolePermission> NewRolePermissionsEntities = Request.PermissionsIds
                        .Select(x => new RolePermission()
                        {
                            PermissionId = x,
                            RoleId = NewRoleEntity.Id
                        }).ToList();

                    await _RolePermissionRepository.AddRangeAsync(NewRolePermissionsEntities);

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الدور بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200, NewRoleEntity.Id);
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
