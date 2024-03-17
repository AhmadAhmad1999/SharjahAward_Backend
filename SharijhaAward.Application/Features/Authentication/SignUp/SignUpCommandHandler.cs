using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
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
            Domain.Entities.IdentityModels.User User = _mapper.Map<Domain.Entities.IdentityModels.User>(request);
            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            User.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: User.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

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
            await _userRepository.AsignRole(User.Id, role.RoleId);
            var data = await _userRepository.AddAsync(User);
            string token = await _userRepository.RegisterAsync(data);
            return new AuthenticationResponse() 
            {
                token = token,
                // user = User,
                message = "User has been Created"
            };
        }
    }
}
