using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Authentication.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, AuthenticationResponse>
    {
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;

        public LoginCommandHandler(IUserRepository userRepository , IMapper mapper, IAsyncRepository<Role> roleRepository,
            IAsyncRepository<Cycle> CycleRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<RolePermission> RolePermissionRepository,
            IAsyncRepository<UserToken> UserTokenRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _roleRepository = roleRepository;
            _CycleRepository = CycleRepository;
            _UserRoleRepository = UserRoleRepository;
            _RolePermissionRepository = RolePermissionRepository;
            _UserTokenRepository = UserTokenRepository;
        }
        public async Task<AuthenticationResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            Cycle? ActiveCycleEntity = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            var user =  _mapper.Map<Domain.Entities.IdentityModels.User>(request);
         
            var response = await _userRepository.LogInAsync(user, request.lang, request.intoAdminDashboard);

            if (!string.IsNullOrEmpty(response.token) && !string.IsNullOrWhiteSpace(response.token) && 
                request.Platform != null)
            {
                UserToken? CheckIfAlreadyExistUserToken = await _UserTokenRepository
                    .FirstOrDefaultAsync(x => x.UserId == response.user.Id);

                if (CheckIfAlreadyExistUserToken is not null)
                {
                    CheckIfAlreadyExistUserToken.Token = response.token;
                    CheckIfAlreadyExistUserToken.AppLanguage = request.lang!;
                    CheckIfAlreadyExistUserToken.DeviceToken = request.DeviceToken;

                    await _UserTokenRepository.UpdateAsync(CheckIfAlreadyExistUserToken);
                }
                else
                {
                    UserToken NewUserTokenEntity = new UserToken()
                    {
                        Token = response.token,
                        UserId = response.user.Id,
                        AppLanguage = request.lang!,
                        DeviceToken = request.DeviceToken,
                        Platform = request.Platform!.Value
                    };

                    await _UserTokenRepository.AddAsync(NewUserTokenEntity);
                }
            }

            response.ActiveCycleId = ActiveCycleEntity?.Id;

            if (response.user is not null)
            {
                List<int> UserRolesIds = await _UserRoleRepository
                    .Where(x => x.UserId == response.user.Id)
                    .Select(x => x.RoleId)
                    .ToListAsync();

                response.UserPermissions = await _RolePermissionRepository
                    .Where(x => UserRolesIds.Contains(x.RoleId))
                    .Include(x => x.Permission!)
                    .Include(x => x.Permission!.PermissionHeader!)
                    .Select(x => new UserPermissionsDto()
                    {
                        Action = x.Permission!.Name,
                        Subject = x.Permission!.PermissionHeader!.Name
                    }).ToListAsync();
            }

            return response;
        }
    }
}
