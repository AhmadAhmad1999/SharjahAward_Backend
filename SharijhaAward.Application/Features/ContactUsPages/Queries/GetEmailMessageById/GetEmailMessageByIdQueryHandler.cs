using AutoMapper;
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

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetEmailMessageById
{
    public class GetEmailMessageByIdQueryHandler
        : IRequestHandler<GetEmailMessageByIdQuery, BaseResponse<EmailMessageDto>>
    {
        private readonly IAsyncRepository<EmailMessage> _emailMessageRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;
        public async Task<BaseResponse<EmailMessageDto>> Handle(GetEmailMessageByIdQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));

            if(User == null)
            {
                return new BaseResponse<EmailMessageDto>("There is no User", false, 401);
            }

            var message = await _emailMessageRepository.GetByIdAsync(request.Id);
            if(message == null)
            {
                return new BaseResponse<EmailMessageDto>("There is no Message", false, 404);
            }

            message.IsRead = true;
            await _emailMessageRepository.UpdateAsync(message);

            var data = _mapper.Map<EmailMessageDto>(message);

            return new BaseResponse<EmailMessageDto>("", true, 200, data);
          
        }
    }
}
