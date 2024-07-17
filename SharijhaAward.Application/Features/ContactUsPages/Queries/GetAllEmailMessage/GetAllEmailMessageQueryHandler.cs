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
            var UserId = _jwtProvider.GetUserIdFromToken(request.token!);
            
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));
            
            if (User == null)
            {
                string msg = request.lang == "en"
                         ? "Un Authorize"
                         : "إنتهت صلاحية الجلسة";

                return new BaseResponse<List<EmailMessageListVM>>(msg, false, 401);
            }

            var EmailMessages = new List<EmailMessage>();

            var MainEmails = await _emailMessageRepository
                .Where(e => e.Id == e.MessageId)
                .ToListAsync();

            foreach(var email in MainEmails)
            {
                var emailMessage = await _emailMessageRepository
                    .WhereThenInclude(m=> m.MessageId == email.Id && m.Id != email.Id, m => m.Attachments!)
                    .OrderByDescending(x => x.CreatedAt)
                    .FirstOrDefaultAsync();

                if(emailMessage == null)
                {
                    EmailMessages.Add(email);
                }

                else
                {
                    EmailMessages.Add(emailMessage);
                }
            }

            if (request.filter == 1)
            {
                EmailMessages = EmailMessages
                  .Where(m => m.From == User.Email)
                  .OrderByDescending(x => x.CreatedAt)
                  .Skip((request.page - 1) * request.perPage)
                  .Take(request.perPage)
                  .ToList();
            }

            if (request.filter == 2)
            {
                EmailMessages = EmailMessages
                   .Where(m => m.To == User.Email)
                   .OrderByDescending(x => x.CreatedAt)
                   .Skip((request.page - 1) * request.perPage)
                   .Take(request.perPage)
                   .ToList();
            }

            if (request.query != null)
            {
                EmailMessages = _emailMessageRepository.WhereThenInclude(m => m.Body.Contains(request.query), m => m.Attachments!).OrderByDescending(x => x.CreatedAt).ToList();
            }
          
            var data = _mapper.Map<List<EmailMessageListVM>>(EmailMessages);
            
            int UnReadingMessages = _emailMessageRepository.GetCount(m => !m.IsRead && m.To == User.Email);
           
            for (int i = 0; i < data.Count(); i++)
            {
                   
                var Type = await _messageTypeRepository.GetByIdAsync(EmailMessages[i].TypeId);
                    
                var Sender = await _userRepository.GetByIdAsync(EmailMessages[i].UserId);

                data[i].TypeName = request.lang == "en" ? Type!.EnglishType : Type!.ArabicType;
                data[i].Attachments = _mapper.Map<List<EmailAttachmentListVm>>(EmailMessages[i].Attachments);   
                data[i].IsReplay = data[i].MessageId == data[i].Id ? false : true;
                data[i].PersonalPhotoUrl = Sender.ImageURL!;
                data[i].Gender = Sender.Gender;
                data[i].IsOutComing = User.Email == data[i].From ? true : false;
            }
            
            int Count = _emailMessageRepository.GetCount(m => m.To == User.Email || m.From == User.Email && m.MessageId == m.Id);
            
            Pagination pagination = new Pagination(request.page,request.perPage, Count);
               
            return new BaseResponse<List<EmailMessageListVM>>("", true, 200, data, pagination,UnReadingMessages);
            
        }
    }

}