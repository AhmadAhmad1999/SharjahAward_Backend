using AutoMapper;
using MediatR;
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

        public LoginCommandHandler(IUserRepository userRepository , IMapper mapper, IAsyncRepository<Role> roleRepository,
            IAsyncRepository<Cycle> CycleRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _roleRepository = roleRepository;
            _CycleRepository = CycleRepository;
        }
        public async Task<AuthenticationResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            Cycle? ActiveCycleEntity = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

            var user =  _mapper.Map<Domain.Entities.IdentityModels.User>(request);
         
            var response = await _userRepository.LogInAsync(user, request.lang, request.intoAdminDashboard);

            response.ActiveCycleId = ActiveCycleEntity?.Id;

            return response;
        }
    }
}
