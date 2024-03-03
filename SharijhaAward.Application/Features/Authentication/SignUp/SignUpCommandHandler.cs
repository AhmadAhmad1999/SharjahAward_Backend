using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Authentication.SignUp
{
    public class SignUpCommandHandler
        : IRequestHandler<SignUpCommand, AuthenticationResponse>
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

        public async Task<AuthenticationResponse> Handle(SignUpCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Domain.Entities.IdentityModels.User>(request);

            string token = await _userRepository.RegisterAsync(user);
            
                var role = request.RoleName != null 
                    ? await _roleRepository.GetByName(request.RoleName)
                    : await _roleRepository.GetByName("User");

                if (role == null)
                {
                    return new AuthenticationResponse()
                    {
                        message = "the User is not Created , Role dose not Exsist"
                    };
                }
            await _userRepository.AsignRole(user.Id, role.RoleId);
            await _userRepository.AddAsync(user);

            return new AuthenticationResponse() 
            {
                token = token,
                user = user,
                message = "User has been Created"
            };
        }
    }
}
