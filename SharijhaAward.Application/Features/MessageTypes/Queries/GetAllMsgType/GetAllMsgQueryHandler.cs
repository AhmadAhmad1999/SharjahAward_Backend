using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.RoleMessageTypeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.MessageTypes.Queries.GetAllMsgType
{
    public class GetAllMsgQueryHandler 
        : IRequestHandler<GetAllMsgQuery, BaseResponse<List<MessageTypeListVM>>>
    {
        private readonly IAsyncRepository<MessageType> _messageTypeRepository;
        private readonly IAsyncRepository<RoleMessageType> _roleTypeRepository;
        private readonly IAsyncRepository<Role> _roleRepository;
        private readonly IMapper _mapper;

        public GetAllMsgQueryHandler(IAsyncRepository<Role> roleRepository, IAsyncRepository<RoleMessageType> roleTypeRepository, IAsyncRepository<MessageType> messageTypeRepository, IMapper mapper)
        {
            _messageTypeRepository = messageTypeRepository;
            _roleTypeRepository = roleTypeRepository;
            _roleRepository = roleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<MessageTypeListVM>>> Handle(GetAllMsgQuery request, CancellationToken cancellationToken)
        {
            var allMessageTypes = await _messageTypeRepository
                .GetPagedReponseAsync(request.page,request.perPage);

            var data = _mapper.Map<List<MessageTypeListVM>>(allMessageTypes);
           
            foreach( var messageType in data)
            {
                messageType.Type = request.lang == "en" ? messageType.EnglishType : messageType.ArabicType;
                var RoleIds = _roleTypeRepository.Where(m => m.MessageTypeId == messageType.Id).Select(m => m.RoleId).ToList();
                messageType.RoleName = _roleRepository.Where(r => RoleIds.Contains(r.Id)).Select(r => r.ArabicName).ToList();
            }

            var count = _messageTypeRepository.GetCount(m => !m.isDeleted);
            Pagination pagination = new Pagination(request.page, request.perPage, count);
            return new BaseResponse<List<MessageTypeListVM>>("", true, 200, data, pagination);
        }
    }
}
