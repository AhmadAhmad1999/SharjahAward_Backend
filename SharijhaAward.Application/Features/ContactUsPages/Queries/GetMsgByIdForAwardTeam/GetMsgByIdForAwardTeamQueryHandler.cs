using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetEmailMessageById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.RoleMessageTypeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetMsgByIdForAwardTeam
{
    public class GetMsgByIdForAwardTeamQueryHandler
        : IRequestHandler<GetMsgByIdForAwardTeamQuery, BaseResponse<EmailMessageDto>>
    {
        private readonly IAsyncRepository<EmailMessage> _emailMessageRepository;
        private readonly IAsyncRepository<EmailAttachment> _emailAttachmentRepository;
        private readonly IAsyncRepository<RoleMessageType> _roleMessageTypeRepository;
        private readonly IAsyncRepository<MessageType> _messageTypeRepository;
        private readonly IAsyncRepository<UserRole> _userRoleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetMsgByIdForAwardTeamQueryHandler(IAsyncRepository<RoleMessageType> roleMessageTypeRepository, IAsyncRepository<UserRole> userRoleRepository, IAsyncRepository<EmailMessage> emailMessageRepository, IAsyncRepository<EmailAttachment> emailAttachmentRepository, IAsyncRepository<MessageType> messageTypeRepository, IUserRepository userRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _emailMessageRepository = emailMessageRepository;
            _emailAttachmentRepository = emailAttachmentRepository;
            _messageTypeRepository = messageTypeRepository;
            _roleMessageTypeRepository = roleMessageTypeRepository;
            _userRoleRepository = userRoleRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<EmailMessageDto>> Handle(GetMsgByIdForAwardTeamQuery request, CancellationToken cancellationToken)
        {
            string msg;
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));

            if (User == null)
            {
                msg = request.lang == "en"
                    ? "Un Authorize"
                    : "إنتهت صلاحية الجلسة";
                return new BaseResponse<EmailMessageDto>(msg, false, 401);
            }
            var RoleIds = _userRoleRepository.Where(r => r.UserId == int.Parse(UserId)).Select(r => r.RoleId).ToList();
           
            List<int> MessageTypeIds = new List<int>();

            for (int i = 0; i < RoleIds.Count(); i++)
            {
                var TypeIds = _roleMessageTypeRepository.Where(r => r.RoleId == RoleIds[i]).Select(r => r.MessageTypeId).ToList();
                MessageTypeIds.AddRange(TypeIds);
            }

            var message = await _emailMessageRepository
                .FirstOrDefaultAsync(m => m.Id == request.Id);
            
            if (message == null && !MessageTypeIds.Contains(message!.TypeId))
            {
                msg = request.lang == "en"
                    ? "Message Not Found"
                    : "الرسالة غير موجودة";

                return new BaseResponse<EmailMessageDto>(msg, false, 404);
            }

            if (!message.IsRead)
            {
                message.IsRead = true;
                message.Status = Domain.Constants.ContactUsConstants.MessageStatus.InProgress;
                await _emailMessageRepository.UpdateAsync(message);
            }
            var Type = await _messageTypeRepository.GetByIdAsync(message.TypeId);

            var data = _mapper.Map<EmailMessageDto>(message);

            var Sender = await _userRepository.GetByIdAsync(message.UserId);

            data.Attachments = _mapper.Map<List<EmailAttachmentListVm>>(await _emailAttachmentRepository
                .Where(x => x.MessageId == data.Id).ToListAsync());

            data.PersonalPhotoUrl = Sender.ImageURL!;
            data.Gender = Sender.Gender;
            data.TypeName = request.lang == "en" ? Type!.EnglishType : Type!.ArabicType;

            var ReplayMessages = await _emailMessageRepository
                .Where(m => m.MessageId == message.Id && m.Id != message.Id)
                .ToListAsync();

            data.ReplayMessages = _mapper.Map<List<EmailMessageDto>>(ReplayMessages);

            List<EmailAttachment> AllEmailAttachmentEntities = await _emailAttachmentRepository
                .Where(x => data.ReplayMessages.Select(y => y.Id).Contains(x.MessageId))
                .ToListAsync();

            for (int i = 0; i < data.ReplayMessages.Count(); i++)
            {
                data.ReplayMessages[i].PersonalPhotoUrl = User.ImageURL!;
                data.ReplayMessages[i].Gender = User.Gender;

                data.ReplayMessages[i].Attachments = _mapper.Map<List<EmailAttachmentListVm>>(AllEmailAttachmentEntities
                    .Where(x => x.MessageId == data.ReplayMessages[i].Id)
                    .ToList());
            }

            return new BaseResponse<EmailMessageDto>("", true, 200, data);
        }
    }
}
