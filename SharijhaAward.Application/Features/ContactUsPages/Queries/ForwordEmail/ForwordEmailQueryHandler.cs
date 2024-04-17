using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.ForwordEmail
{
    public class ForwordEmailQueryHandler
        : IRequestHandler<ForwordEmailQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EmailMessage> _emailMessageRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IUserRepository _userRepository;
        public ForwordEmailQueryHandler(IUserRepository userRepository, IJwtProvider jwtProvider, IAsyncRepository<EmailMessage> emailMessageRepository)
        {
            _emailMessageRepository = emailMessageRepository;
            _jwtProvider = jwtProvider;
            _userRepository = userRepository;
        }

        public async Task<BaseResponse<object>> Handle(ForwordEmailQuery request, CancellationToken cancellationToken)
        {
            var Message = await _emailMessageRepository.GetByIdAsync(request.MsgId);
            if(Message == null)
            {
                return new BaseResponse<object>("", false, 404);
            }

            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));
            if (User == null)
            {
                return new BaseResponse<object>("", false, 401);
            }

            Message.To = request.To;
            Message.From = User.Email;

            await _emailMessageRepository.AddAsync(Message);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
