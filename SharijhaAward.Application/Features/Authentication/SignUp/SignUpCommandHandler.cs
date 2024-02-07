using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Authentication.SignUp
{
    public class SignUpCommandHandler : IRequestHandler<SignUpCommand, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public SignUpCommandHandler(IUserRepository userRepository,IRoleRepository roleRepository ,IMapper mapper)
        {
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<string> Handle(SignUpCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Domain.Entities.IdentityModels.User>(request);

            await _userRepository.AddAsync(user);

            string token = await _userRepository.RegisterAsync(user);
            
                var role = request.RoleName != null 
                    ? await _roleRepository.GetByName(request.RoleName)
                    : await _roleRepository.GetByName("User");

                if (role == null)
                {
                    throw new OpenQA.Selenium.NotFoundException("Role dose not Exsist");
                }
                await _userRepository.AsignRole(user.Id, role.RoleId);
            
            
            return token;
        }
    }
}
