using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.AssignUserToCategories
{
    public class AssignUserToCategoriesHandler
        : IRequestHandler<AssignUserToCategoriesCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<UserCategory> _UserCategoryRepository;

        public AssignUserToCategoriesHandler(IAsyncRepository<UserRole> _UserRoleRepository,
            IAsyncRepository<UserCategory> _UserCategoryRepository)
        {
            this._UserRoleRepository = _UserRoleRepository;
            this._UserCategoryRepository = _UserCategoryRepository;
        }
        public async Task<BaseResponse<object>> Handle(AssignUserToCategoriesCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            UserRole? CheckIfUserHasRole = await _UserRoleRepository
                .FirstOrDefaultAsync(x => x.UserId == Request.UserId &&
                    x.RoleId == Request.RoleId);

            if (CheckIfUserHasRole is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User role is not found"
                    : "المستخدم لا يملك هذا الدور";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<UserCategory> OldUserCategoryEntities = await _UserCategoryRepository
                .Where(x => x.UserRoleId == CheckIfUserHasRole.Id)
                .ToListAsync();

            List<UserCategory> NewUserCategoryEntitites = Request.CategoriesIds
                .Select(x => new UserCategory()
                {
                    CategoryId = x,
                    UserRoleId = CheckIfUserHasRole.Id
                }).ToList();

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
                    if (OldUserCategoryEntities.Any())
                        await _UserCategoryRepository.DeleteListAsync(OldUserCategoryEntities);

                    if (NewUserCategoryEntitites.Any())
                        await _UserCategoryRepository.AddRangeAsync(NewUserCategoryEntitites);

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم ربط المستخدم مع دوره بالفئات بنجاح";

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
