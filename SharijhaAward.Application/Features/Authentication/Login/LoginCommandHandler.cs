using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.Authentication.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, AuthenticationResponse>
    {
        private readonly IAsyncRepository<ResponsibilityUser> _responsibilityUserRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;

        public LoginCommandHandler(
            IUserRepository userRepository, 
            IMapper mapper,
            IAsyncRepository<Role> roleRepository,
            IAsyncRepository<Cycle> CycleRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<RolePermission> RolePermissionRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IAsyncRepository<ResponsibilityUser> responsibilityUserRepository,
            IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<Coordinator> CoordinatorRepository,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _roleRepository = roleRepository;
            _CycleRepository = CycleRepository;
            _UserRoleRepository = UserRoleRepository;
            _RolePermissionRepository = RolePermissionRepository;
            _UserTokenRepository = UserTokenRepository;
            _responsibilityUserRepository = responsibilityUserRepository;
            _ArbitratorRepository = ArbitratorRepository;
            _CoordinatorRepository = CoordinatorRepository;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }
        public async Task<AuthenticationResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            Cycle? ActiveCycleEntity = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            var user =  _mapper.Map<Domain.Entities.IdentityModels.User>(request);
            
            var response = await _userRepository.LogInAsync(user, request.lang, request.intoAdminDashboard);

            int? ForUseUserId = response.ActiveCycleId;

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

            response.ActiveCycleId = ActiveCycleEntity!.Id;
            response.CycleName = request.lang == "en" ? ActiveCycleEntity!.EnglishName : ActiveCycleEntity!.ArabicName;
            response.CycleNumber = ActiveCycleEntity!.CycleNumber;

            if (response.user is not null)
            {
                var responsibilities = await _responsibilityUserRepository
                    .Where(r => r.UserId == response.user.Id)
                    .ToListAsync();

                if (responsibilities.Any(r => r.IsAccept == false))
                {
                    response.user.AcceptOnResponsibilities = false;
                }
                else
                {
                    response.user.AcceptOnResponsibilities = true;
                }

                List<int> UserRolesIds = await _UserRoleRepository
                    .Where(x => x.UserId == response.user.Id)
                    .Select(x => x.RoleId)
                    .ToListAsync();
                
                List<string> UserRolesNames = await _UserRoleRepository
                    .Where(x => x.UserId == response.user.Id)
                    .Include(x=>x.Role)
                    .Select(x => x.Role!.EnglishName)
                    .ToListAsync();

                response.user.RoleId = UserRolesIds;
                response.user.RoleName = UserRolesNames;

                response.UserPermissions = await _RolePermissionRepository
                    .Where(x => UserRolesIds.Contains(x.RoleId))
                    .Include(x => x.Permission!)
                    .Include(x => x.Permission!.PermissionHeader!)
                    .Select(x => new UserPermissionsDto()
                    {
                        Action = x.Permission!.Action,
                        Subject = x.Permission!.PermissionHeader!.EnglishName
                    }).ToListAsync();
            }

            if (response.user == null && ForUseUserId != null)
                response.OutUserId = ForUseUserId!.Value;

            if (response.user != null)
            {
                Arbitrator? CheckIfLogInUserIsArbitrator = await _ArbitratorRepository
                    .FirstOrDefaultAsync(x => x.Id == response.user.Id);

                if (CheckIfLogInUserIsArbitrator is not null)
                {
                    response.isChairman = CheckIfLogInUserIsArbitrator.isChairman;
                    response.user.isChairman = CheckIfLogInUserIsArbitrator.isChairman;

                    List<DynamicAttributeSection> DynamicAttributeSectionEntities = await _DynamicAttributeSectionRepository
                        .Where(x => x.AttributeTableNameId == 3)
                        .ToListAsync();

                    if (DynamicAttributeSectionEntities.Any())
                    {
                        List<DynamicAttribute> DynamicAttributeEntities = await _DynamicAttributeRepository
                            .Where(x => x.IsRequired && 
                                DynamicAttributeSectionEntities.Select(y => y.Id).Contains(x.DynamicAttributeSectionId))
                            .ToListAsync();

                        if (DynamicAttributeEntities.Any())
                        {
                            List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                                .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                                .ToListAsync();

                            if (DynamicAttributeValueEntities.Count() != DynamicAttributeEntities.Count())
                                response.DoesContainsRequiredFields = true;
                        }
                    }
                }
                else
                {
                    Coordinator? CheckIfLogInUserIsCoordinator = await _CoordinatorRepository
                        .FirstOrDefaultAsync(x => x.Id == response.user.Id);

                    if (CheckIfLogInUserIsCoordinator is not null)
                    {
                        List<DynamicAttributeSection> DynamicAttributeSectionEntities = await _DynamicAttributeSectionRepository
                            .Where(x => x.AttributeTableNameId == 2)
                            .ToListAsync();

                        if (DynamicAttributeSectionEntities.Any())
                        {
                            List<DynamicAttribute> DynamicAttributeEntities = await _DynamicAttributeRepository
                                .Where(x => x.IsRequired &&
                                    DynamicAttributeSectionEntities.Select(y => y.Id).Contains(x.DynamicAttributeSectionId))
                                .ToListAsync();

                            if (DynamicAttributeEntities.Any())
                            {
                                List<DynamicAttributeValue> DynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                                    .Where(x => DynamicAttributeEntities.Select(y => y.Id).Contains(x.DynamicAttributeId))
                                    .ToListAsync();

                                if (DynamicAttributeValueEntities.Count() != DynamicAttributeEntities.Count())
                                    response.DoesContainsRequiredFields = true;
                            }
                        }
                    }
                }
            }

            return response;
        }
    }
}
