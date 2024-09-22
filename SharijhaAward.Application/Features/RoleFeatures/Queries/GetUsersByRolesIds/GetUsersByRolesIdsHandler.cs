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
        private readonly IUserRepository _UserRepository;
        public GetUsersByRolesIdsHandler(IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IUserRepository UserRepository)
        {
            _UserRoleRepository = UserRoleRepository;
            _UserTokenRepository = UserTokenRepository;
            _UserRepository = UserRepository;
        }

        public async Task<BaseResponse<List<UsersInRoleDto>>> Handle(GetUsersByRolesIdsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            var UserRolesIds = await _UserRoleRepository
                .Where(x => Request.RolesIds.Contains(x.RoleId))
                .Select(x => new 
                {
                    x.UserId,
                    x.Role!.EnglishName
                }).ToListAsync();

            List<int> SubscribersIds = UserRolesIds
                .Where(x => x.EnglishName != "Arbitrator" &&
                    x.EnglishName != "Coordinator")
                .Select(x => x.UserId)
                .Distinct()
                .ToList();

            List<UsersInRoleDto> SubscriberInRoleDtos = _UserRepository
                .Where(x => SubscribersIds.Contains(x.Id) && x.isValidAccount)
                .AsEnumerable()
                .Select(x => new UsersInRoleDto()
                {
                    Id = x.Id,
                    Email = x.Email
                }).ToList();

            List<int> NotSubscribersIds = UserRolesIds
                .Where(x => !SubscribersIds.Contains(x.UserId))
                .Select(x => x.UserId)
                .Distinct()
                .ToList();

            List<UsersInRoleDto> NotSubscriberInRoleDtos = _UserRepository
                .Where(x => NotSubscribersIds.Contains(x.Id) && x.isValidAccount)
                .AsEnumerable()
                .Select(x => new UsersInRoleDto()
                {
                    Id = x.Id,
                    Email = x.Email,
                    ArabicName = x.ArabicName
                }).ToList();

            SubscriberInRoleDtos.AddRange(NotSubscriberInRoleDtos);

            return new BaseResponse<List<UsersInRoleDto>>(ResponseMessage, true, 200, SubscriberInRoleDtos);
        }
    }
}
