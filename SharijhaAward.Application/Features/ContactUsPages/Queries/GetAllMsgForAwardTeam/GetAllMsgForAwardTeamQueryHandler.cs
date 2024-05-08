using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllEmailMessage;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.RoleMessageTypeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.GetAllMsgForAwardTeam
{
    public class GetAllMsgForAwardTeamQueryHandler
        : IRequestHandler<GetAllMsgForAwardTeamQuery, BaseResponse<List<EmailMessageListVM>>>
    {
        private readonly IAsyncRepository<EmailMessage> _emailMessageRepository;
        private readonly IAsyncRepository<MessageType> _messageTypeRepository;
        private readonly IAsyncRepository<RoleMessageType> _roleMessageTypeRepository;
        private readonly IAsyncRepository<UserRole> _userRoleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public GetAllMsgForAwardTeamQueryHandler(IUserRepository userRepository, IAsyncRepository<MessageType> messageTypeRepository, IAsyncRepository<EmailMessage> emailMessageRepository, IAsyncRepository<RoleMessageType> roleMessageTypeRepository, IAsyncRepository<UserRole> userRoleRepository, IJwtProvider jwtProvider, IMapper mapper)
        {
            _emailMessageRepository = emailMessageRepository;
            _roleMessageTypeRepository = roleMessageTypeRepository;
            _messageTypeRepository = messageTypeRepository;
            _userRoleRepository = userRoleRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<EmailMessageListVM>>> Handle(GetAllMsgForAwardTeamQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
           
            if(UserId == null)
            {
                return new BaseResponse<List<EmailMessageListVM>>("", false, 401);
            }
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));

            var RoleIds = _userRoleRepository.Where(r => r.UserId == int.Parse(UserId)).Select(r=>r.RoleId).ToList();
            
            List<int> MessageTypeIds = new List<int>();
            
            for(int i = 0; i < RoleIds.Count(); i++)
            {
                var TypeIds = _roleMessageTypeRepository.Where(r => r.RoleId == RoleIds[i]).Select(r => r.MessageTypeId).ToList();
                MessageTypeIds.AddRange(TypeIds);
            }

            List<EmailMessage> emailMessages = new List<EmailMessage>();
            
            var Count = 0;
           
            for (int i = 0; i < MessageTypeIds.Count(); i++)
            {
                var EmailMessage = _emailMessageRepository.WhereThenIncludeThenPagination(m => m.TypeId == MessageTypeIds[i] && m.Id == m.MessageId, request.page, request.pageSize , m => m.Attachments!).ToList();
                emailMessages.AddRange(EmailMessage);

                Count = _emailMessageRepository.GetCount(m => m.TypeId == MessageTypeIds[i]);
            }
            
            var data = _mapper.Map<List<EmailMessageListVM>>(emailMessages);
            
            for(int i=0; i< data.Count(); i++)
            {
                var Type = await _messageTypeRepository.GetByIdAsync(emailMessages[i].TypeId);
                
                data[i].Attachments = _mapper.Map<List<EmailAttachmentListVm>>(emailMessages[i].Attachments);
               
                data[i].TypeName = Type!.Type;

                data[i].IsOutComing = data[i].From == User!.Email ? true : false; 
            }
            
            Pagination pagination = new Pagination(request.page, request.pageSize, Count);
            
            return new BaseResponse<List<EmailMessageListVM>>("", true, 200, data.OrderByDescending(d=>d.CreatedAt).ToList(), pagination, Count);

        }
    }
}
