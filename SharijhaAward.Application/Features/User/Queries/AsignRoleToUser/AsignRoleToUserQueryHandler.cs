using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.AsignRoleToUser
{
    public class AsignRoleToUserQueryHandler : IRequestHandler<AsignRoleToUserQuery , Unit>
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;

        public AsignRoleToUserQueryHandler(IUserRepository userRepository, IRoleRepository roleRepository ,IMapper mapper)
        {
            _userRepository = userRepository;
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(AsignRoleToUserQuery request, CancellationToken cancellationToken)
        {
            var User = await _userRepository.GetByIdAsync(request.userId);
            var Role = await _roleRepository.GetByIdAsync(request.roleId);

            if (User == null || Role == null) 
            {
                throw new OpenQA.Selenium.NotFoundException("User Or Role Not Found");
            }
            await _userRepository.AsignRole(User.Id, Role.RoleId);

            return Unit.Value;

        }
    }
}
