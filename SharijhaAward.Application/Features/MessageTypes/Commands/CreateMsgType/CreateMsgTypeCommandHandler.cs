using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.MessageTypes.Commands.CreateMsgType
{
    public class CreateMsgTypeCommandHandler 
        : IRequestHandler<CreateMsgTypeCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<MessageType> _messageTypeRepository;
        private readonly IMapper _mapper;

        public CreateMsgTypeCommandHandler(IAsyncRepository<MessageType> messageTypeRepository, IMapper mapper)
        {
            _messageTypeRepository = messageTypeRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateMsgTypeCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Messege Type has been Created"
                : "تم إضافة نوع رسالة جديد";

            var messageType = _mapper.Map<MessageType>(request);

            var allMessageTypes = await _messageTypeRepository.ListAllAsync();
            
            var type = _messageTypeRepository.FirstOrDefault(t => t.Id == messageType.Id);
            
            if(type != null)
            {
                msg = request.lang == "en"
                ? "Messege Type is allready exisit"
                : "نوع الرسالة موجود بالفعل";

                return new BaseResponse<int>(msg, false, 400);
            }
            var data = await _messageTypeRepository.AddAsync(messageType);

            return new BaseResponse<int>(msg, true, 200, data.Id);
        }
    }
}
