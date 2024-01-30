using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Model.IdentityModels;
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
        private readonly IMapper _mapper;
        public SignUpCommandHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<string> Handle(SignUpCommand request, CancellationToken cancellationToken)
        {
            User user = _mapper.Map<User>(request);

            await _userRepository.AddAsync(user);

            string token = await _userRepository.RegisterAsync(user);

            return token;
        }
    }
}
