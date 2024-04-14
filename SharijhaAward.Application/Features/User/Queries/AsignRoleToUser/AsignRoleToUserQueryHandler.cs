using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.User.Queries.AsignRoleToUser
{
    public class AsignRoleToUserQueryHandler : IRequestHandler<AsignRoleToUserQuery , Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public AsignRoleToUserQueryHandler(IUserRepository userRepository, IRoleRepository roleRepository,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<Unit> Handle(AsignRoleToUserQuery request, CancellationToken cancellationToken)
        {
            var User = await _userRepository.GetByIdAsync(request.userId);
            var Role = await _roleRepository.GetByIdAsync(request.roleId);

            if (User == null || Role == null) 
            {
                throw new OpenQA.Selenium.NotFoundException("User Or Role Not Found");
            }

            UserRole NewUserRoleEntity = new UserRole()
            {
                UserId = User.Id,
                RoleId = Role.Id
            };

            await _UserRoleRepository.AddAsync(NewUserRoleEntity);

            return Unit.Value;
        }
    }
}
