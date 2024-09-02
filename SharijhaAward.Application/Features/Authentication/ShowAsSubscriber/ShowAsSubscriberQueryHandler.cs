using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Authentication.ShowAsSubscriber
{
    public class ShowAsSubscriberQueryHandler
        : IRequestHandler<ShowAsSubscriberQuery, AuthenticationResponse>
    {
        private readonly IAsyncRepository<UserToken> _userTokenRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;
        public ShowAsSubscriberQueryHandler(IAsyncRepository<UserToken> userTokenRepository,  IMapper mapper, IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _userTokenRepository = userTokenRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;

        }
        public async Task<AuthenticationResponse> Handle(ShowAsSubscriberQuery request, CancellationToken cancellationToken)
        {
            var AdminId = _jwtProvider.GetUserIdFromToken(request.token);
            var Admin = await _userRepository.GetByIdAsync(int.Parse(AdminId));

            if (Admin == null)
            {
                return new AuthenticationResponse()
                {
                    isSucceed = false,
                    message = request.lang == "en"
                    ? "This User is Not Auth"
                    : "المستخدم غير موجود"
                };
            }

            var User = await _userRepository.GetByIdAsync(request.UserId);
            if (User == null)
            {
                return new AuthenticationResponse()
                {
                    isSucceed = false,
                    message = request.lang == "en"
                        ? "Subscriber Not Found"
                        : "المستخدم غير موجود"
                };
            }

            var token = _jwtProvider.Generate(User);

            var userToken = new UserToken()
            {
                Token = token,
                UserId = User.Id,
                AppLanguage = "ar",
                Platform = PlatformType.Web
            };

            await _userTokenRepository.AddAsync(userToken);

            var response = new AuthenticationResponse()
            {
                token = token,
                user = _mapper.Map<UserDataResponse>(User),
                message = request.lang == "en"
                    ? "You can Show As Subscriber"
                    : "يمكنك الدخول كمشترك",

                isSucceed = true,
            };
            

            return response;
        }
    }
}
