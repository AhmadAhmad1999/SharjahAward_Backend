using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
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
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public ShowAsSubscriberQueryHandler(IUserRepository userRepository, IJwtProvider jwtProvider)
        {
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
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

            var response = await _userRepository.LogInAsync(User, request.lang, false);

            return response;
        }
    }
}
