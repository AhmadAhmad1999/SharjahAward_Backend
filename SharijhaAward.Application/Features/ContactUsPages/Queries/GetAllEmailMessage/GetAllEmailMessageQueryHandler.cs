using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage
{
    public class GetAllEmailMessageQueryHandler
        : IRequestHandler<GetAllEmailMessageQuery, BaseResponse<List<EmailMessageListVM>>>
    {
        private readonly IAsyncRepository<EmailMessage> _emailMessageRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IMapper _mapper;

        public GetAllEmailMessageQueryHandler(IAsyncRepository<EmailMessage> emailMessageRepository, IJwtProvider jwtProvider, IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository, IMapper mapper)
        {
            _emailMessageRepository = emailMessageRepository;
            _jwtProvider = jwtProvider;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<EmailMessageListVM>>> Handle(GetAllEmailMessageQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));
            if(User == null)
            {
                return new BaseResponse<List<EmailMessageListVM>>("There is no User", false, 401);
            }
            var EmailMessages = await _emailMessageRepository.WhereThenInclude(m=>m.From == User.Email || m.To == User.Email , m => m.Attachments!).ToListAsync();
            var data = _mapper.Map<List<EmailMessageListVM>>(EmailMessages);
            
            for(int i = 0; i < data.Count(); i++)
            {
                data[i].Attachments = _mapper.Map <List<EmailAttachmentListVm>>(EmailMessages[i].Attachments);
                data[i].IsReplay = data[i].MessageId == null? false : true;
            }
            return new BaseResponse<List<EmailMessageListVM>>("", true, 200, data);
        }
    }
}
