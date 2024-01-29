
using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Model.IdentityModels;

namespace SharijhaAward.Application.Features.Authentication.Login
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public LoginCommandHandler(IUserRepository userRepository ,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            User user = await _userRepository.GetByEmailAsync(request.Email);
            if (user == null)
            {
                throw new OpenQA.Selenium.NotFoundException();
            }

            string token = await _userRepository.LogInAsync(user);

            return token;
            
        }
    }
}
