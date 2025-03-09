using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUserRoleCategoriesByUserId
{
    public class GetAllUserRoleCategoriesByUserIdHandler 
        : IRequestHandler<GetAllUserRoleCategoriesByUserIdQuery, BaseResponse<List<GetAllUserRoleCategoriesByUserIdListVM>>>
    {
        private readonly IAsyncRepository<UserCategory> _UserCategoryRepository;

        public GetAllUserRoleCategoriesByUserIdHandler(IAsyncRepository<UserCategory> _UserCategoryRepository)
        {
            this._UserCategoryRepository = _UserCategoryRepository;
        }

        public async Task<BaseResponse<List<GetAllUserRoleCategoriesByUserIdListVM>>> 
            Handle(GetAllUserRoleCategoriesByUserIdQuery Request, CancellationToken cancellationToken)
        {
            List<UserCategory> UserCategoryEntities = await _UserCategoryRepository
                .Where(x => x.UserRole!.UserId == Request.UserId)
                .ToListAsync();

            List<IGrouping<int, UserCategory>> GroupedUserCategoryEntities = UserCategoryEntities
                .GroupBy(x => x.UserRole!.RoleId)
                .ToList();

            List<GetAllUserRoleCategoriesByUserIdListVM> Response = GroupedUserCategoryEntities
                .Where(x => x.ToList().Any()
                    ? x.ToList().FirstOrDefault() != null
                    : false)
                .Select(x =>
                {
                    return new GetAllUserRoleCategoriesByUserIdListVM()
                    {
                        RoleId = x.ToList().FirstOrDefault()!.UserRole!.Role!.Id,
                        RoleName = Request.lang == "en"
                            ? x.ToList().FirstOrDefault()!.UserRole!.Role!.EnglishName
                            : x.ToList().FirstOrDefault()!.UserRole!.Role!.ArabicName,
                        CategoriesDto = x.ToList()
                            .Select(y => new CategoriesDto()
                            {
                                CategoryId = y.CategoryId,
                                CategoryName = Request.lang == "en"
                                    ? y.Category!.EnglishName
                                    : y.Category!.ArabicName
                            }).ToList()
                    };
                }).ToList();

            return new BaseResponse<List<GetAllUserRoleCategoriesByUserIdListVM>>(string.Empty, true, 200, Response);
        }
    }
}
