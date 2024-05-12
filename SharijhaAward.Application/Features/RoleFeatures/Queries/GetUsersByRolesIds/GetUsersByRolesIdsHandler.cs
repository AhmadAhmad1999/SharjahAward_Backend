using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.RoleFeatures.Queries.GetUsersByRolesIds
{
    public class GetUsersByRolesIdsHandler : IRequestHandler<GetUsersByRolesIdsQuery, BaseResponse<List<UsersInRoleDto>>>
    {
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        public GetUsersByRolesIdsHandler(IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<UserToken> UserTokenRepository)
        {
            _UserRoleRepository = UserRoleRepository;
            _UserTokenRepository = UserTokenRepository;
        }

        public async Task<BaseResponse<List<UsersInRoleDto>>> Handle(GetUsersByRolesIdsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<int> UserIds = await _UserRoleRepository
                .Where(x => Request.RolesIds.Contains(x.RoleId))
                .Select(x => x.UserId)
                .Distinct()
                .ToListAsync();

            List<UsersInRoleDto> UsersInRoleDtos = await _UserTokenRepository
                .Include(x => x.User!)
                .Where(x => UserIds.Contains(x.UserId) && x.User!.isValidAccount)
                .DistinctBy(x => x.UserId)
                .Select(x => new UsersInRoleDto()
                {
                    Id = x.UserId,
                    Email = x.User!.Email
                }).ToListAsync();

            return new BaseResponse<List<UsersInRoleDto>>(ResponseMessage, true, 200, UsersInRoleDtos);
        }
    }
}
