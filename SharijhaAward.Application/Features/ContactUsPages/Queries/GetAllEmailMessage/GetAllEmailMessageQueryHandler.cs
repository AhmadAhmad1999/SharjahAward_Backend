using Aspose.Pdf.Plugins;
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
        private readonly IAsyncRepository<MessageType> _messageTypeRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IMapper _mapper;

        public GetAllEmailMessageQueryHandler(IAsyncRepository<MessageType> messageTypeRepository, IAsyncRepository<EmailMessage> emailMessageRepository, IJwtProvider jwtProvider, IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository, IMapper mapper)
        {
            _emailMessageRepository = emailMessageRepository;
            _messageTypeRepository = messageTypeRepository;
            _jwtProvider = jwtProvider;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<EmailMessageListVM>>> Handle(GetAllEmailMessageQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));
            if (User == null)
            {
                string msg = request.lang == "en"
                         ? "Un Authorize"
                         : "إنتهت صلاحية الجلسة";

                return new BaseResponse<List<EmailMessageListVM>>(msg, false, 401);
            }

            var EmailMessages = await _emailMessageRepository.WhereThenIncludeThenPagination(m => m.From == User.Email || m.To == User.Email && m.MessageId == m.Id, request.page, request.pageSize, m => m.Attachments!)
                .OrderByDescending(x => x.CreatedAt).ToListAsync();
            if (request.filter == 1)
            {
                EmailMessages = EmailMessages.Where(m => m.From == User.Email).ToList();
            }

            if (request.filter == 2)
            {
                EmailMessages = EmailMessages.Where(m => m.To == User.Email).ToList();
            }
            if (request.query != null)
        
            {
                EmailMessages = EmailMessages.Where(m => m.Body.Contains(request.query)).OrderByDescending(x => x.CreatedAt).ToList();
            }
                var data = _mapper.Map<List<EmailMessageListVM>>(EmailMessages);
                int UnReadingMessages = _emailMessageRepository.GetCount(m => !m.IsRead);
            for (int i = 0; i < data.Count(); i++)
            {
                   
                var Type = await _messageTypeRepository.GetByIdAsync(EmailMessages[i].TypeId);
                    
                var Sender = await _userRepository.GetByIdAsync(EmailMessages[i].UserId);

                data[i].TypeName = Type!.Type;
                data[i].Attachments = _mapper.Map<List<EmailAttachmentListVm>>(EmailMessages[i].Attachments);                    data[i].IsReplay = data[i].MessageId == null ? false : true;
                data[i].PersonalPhotoUrl = Sender.ImageURL!;
                data[i].Gender = Sender.Gender;
                data[i].CountOfUnReadingMessages = UnReadingMessages;  
            }
            
            int Count = _emailMessageRepository.GetCount(m => m.To == User.Email || m.From == User.Email);
            
            Pagination pagination = new Pagination(request.page,request.pageSize, Count);
               
            return new BaseResponse<List<EmailMessageListVM>>("", true, 200, data);
            
        }
    }

}