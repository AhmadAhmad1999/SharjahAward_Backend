using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.UserFeatures.Queries.GetAllUsersByRoleId
{
    public class GetAllUsersByRoleIdHandler 
        : IRequestHandler<GetAllUsersByRoleIdQuery, BaseResponse<List<GetAllUsersByRoleIdListVM>>>
    {
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public GetAllUsersByRoleIdHandler(IAsyncRepository<UserRole> UserRoleRepository)
        {
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<List<GetAllUsersByRoleIdListVM>>> 
            Handle(GetAllUsersByRoleIdQuery Request, CancellationToken cancellationToken)
        {
            string RoleName = Request.RoleEnglishName;

            var xx = await _UserRoleRepository
                .Where(x => x.Role!.EnglishName.ToLower() == RoleName.ToLower())
                .ToListAsync();

            List<GetAllUsersByRoleIdListVM> Response = xx
                .Select(x => new GetAllUsersByRoleIdListVM()
                {
                    UserId = x.UserId,
                    UserName = Request.lang == "en"
                        ? x.User!.EnglishName
                        : x.User!.ArabicName
                }).ToList();

            return new BaseResponse<List<GetAllUsersByRoleIdListVM>>(string.Empty, true, 200, Response);
        }
    }
}
