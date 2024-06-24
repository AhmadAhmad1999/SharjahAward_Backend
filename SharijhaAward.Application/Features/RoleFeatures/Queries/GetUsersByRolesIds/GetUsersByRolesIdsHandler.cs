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

            var UserRolesIds = await _UserRoleRepository
                .Where(x => Request.RolesIds.Contains(x.RoleId))
                .Include(x => x.Role!)
                .Select(x => new 
                {
                    x.UserId,
                    x.Role!.EnglishName
                }).ToListAsync();

            List<int> SubscribersIds = UserRolesIds
                .Where(x => x.EnglishName != "Arbitrator" ||
                    x.EnglishName != "Coordinator")
                .Select(x => x.UserId)
                .Distinct()
                .ToList();

            List<UsersInRoleDto> SubscriberInRoleDtos = await _UserTokenRepository
                .Include(x => x.User!)
                .Where(x => SubscribersIds.Contains(x.UserId) && x.User!.isValidAccount)
                .DistinctBy(x => x.UserId)
                .Select(x => new UsersInRoleDto()
                {
                    Id = x.UserId,
                    Email = x.User!.Email
                }).ToListAsync();

            List<int> NotSubscribersIds = UserRolesIds
                .Where(x => x.EnglishName == "Arbitrator" ||
                    x.EnglishName == "Coordinator")
                .Select(x => x.UserId)
                .Distinct()
                .ToList();

            List<UsersInRoleDto> NotSubscriberInRoleDtos = await _UserTokenRepository
                .Include(x => x.User!)
                .Where(x => NotSubscribersIds.Contains(x.UserId) && x.User!.isValidAccount)
                .DistinctBy(x => x.UserId)
                .Select(x => new UsersInRoleDto()
                {
                    Id = x.UserId,
                    Email = x.User!.Email,
                    ArabicName = x.User!.ArabicName
                }).ToListAsync();

            SubscriberInRoleDtos.AddRange(NotSubscriberInRoleDtos);

            return new BaseResponse<List<UsersInRoleDto>>(ResponseMessage, true, 200, SubscriberInRoleDtos);
        }
    }
}
