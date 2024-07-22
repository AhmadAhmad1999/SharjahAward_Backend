using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
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
        private readonly IAsyncRepository<EmailAttachment> _emailAttachmentRepository;
        private readonly IAsyncRepository<MessageType> _messageTypeRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetEmailMessageByIdQueryHandler(IAsyncRepository<MessageType> messageTypeRepository, IAsyncRepository<EmailMessage> emailMessageRepository, IAsyncRepository<EmailAttachment> emailAttachmentRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _emailMessageRepository = emailMessageRepository;
            _emailAttachmentRepository = emailAttachmentRepository;
            _messageTypeRepository = messageTypeRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<EmailMessageDto>> Handle(GetEmailMessageByIdQuery request, CancellationToken cancellationToken)
        {
            string msg;
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));

            if(User == null)
            {
                msg = request.lang == "en"
                    ? "Un Authorize"
                    : "إنتهت صلاحية الجلسة";
                return new BaseResponse<EmailMessageDto>(msg, false, 401);
            }

            var message = await _emailMessageRepository
                .Where(m => m.Id == request.Id)
                .Where(m => m.To == User.Email || m.From == User.Email)
                .Include(m => m.Attachments)
                .FirstOrDefaultAsync();

            if(message == null)
            {
                msg = request.lang == "en"
                    ? "Message Not Found"
                    : "الرسالة غير موجودة";

                return new BaseResponse<EmailMessageDto>(msg, false, 404);
            }
            if(message.To == User.Email && !message.IsRead)
            {
                message.IsRead = true;
              //message.Status = Domain.Constants.ContactUsConstants.MessageStatus.InProgress;
                await _emailMessageRepository.UpdateAsync(message);
            }
            var Type = await _messageTypeRepository.GetByIdAsync(message.TypeId);

            var data = _mapper.Map<EmailMessageDto>(message);

            var Sender = await _userRepository.GetByIdAsync(message.UserId);

            data.Attachments = _mapper.Map<List<EmailAttachmentListVm>>(message.Attachments);
            data.PersonalPhotoUrl = Sender.ImageURL!;
            data.Gender = Sender.Gender;
            data.TypeName = request.lang == "en" ? Type!.EnglishType : Type!.ArabicType;

            var ReplayMessages = _emailMessageRepository.WhereThenInclude(m => m.MessageId == message.Id && m.Id != message.Id, m => m.Attachments!).ToList();
           
            data.ReplayMessages = _mapper.Map<List<EmailMessageDto>>(ReplayMessages);
            
            for (int i = 0; i < data.ReplayMessages.Count(); i++)
            {
                data.ReplayMessages[i].PersonalPhotoUrl = User.ImageURL!;
                data.ReplayMessages[i].Gender = User.Gender;
                data.IsReplay = true;
            }
            return new BaseResponse<EmailMessageDto>("", true, 200, data);
          
        }
    }
}
