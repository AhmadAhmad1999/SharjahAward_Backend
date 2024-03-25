using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Authentication.Login;
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
        private readonly IUserRepository _UserRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        public SignUpCommandHandler(IUserRepository userRepository,IRoleRepository roleRepository ,IMapper mapper)
        {
            _roleRepository = roleRepository;
            _UserRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<AuthenticationResponse> Handle(SignUpCommand Request, CancellationToken cancellationToken)
        {
            Domain.Entities.IdentityModels.User? CheckEmail = await _UserRepository
                .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower() && x.isValidAccount);

            if (CheckEmail is not null)
            {
                return new AuthenticationResponse()
                {
                    message = "This email is already used",
                    isSucceed = false
                };
            }

            Domain.Entities.IdentityModels.User User = _mapper.Map<Domain.Entities.IdentityModels.User>(Request);
            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            User.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: User.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            User.isValidAccount = false;

            Role? CheckRoleId = Request.RoleName != null 
                ? await _roleRepository.GetByName(Request.RoleName)
                : await _roleRepository.GetByName("User");

            if (CheckRoleId == null)
            {
                return new AuthenticationResponse()
                {
                    message = "The user is not created , Role does not exist"
                };
            }

            User.RoleId = CheckRoleId.RoleId;

            await _UserRepository.AsignRole(User.Id, CheckRoleId.RoleId);

            Domain.Entities.IdentityModels.User UserEntityAfterAdd = await _UserRepository.AddAsync(User);

            string Token = await _UserRepository.RegisterAsync(UserEntityAfterAdd);
            return new AuthenticationResponse() 
            {
                // token = Token,
                isSucceed = true,
                message = "User has been created",
                user = _mapper.Map<UserDataResponse>(User)
            };
        }
    }
}
