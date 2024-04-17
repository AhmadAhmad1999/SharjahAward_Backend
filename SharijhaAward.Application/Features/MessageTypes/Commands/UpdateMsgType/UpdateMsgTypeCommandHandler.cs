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

namespace SharijhaAward.Application.Features.MessageTypes.Commands.UpdateMsgType
{
    public class UpdateMsgTypeCommandHandler
        : IRequestHandler<UpdateMsgTypeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<MessageType> _messageTypeRepository;
        private IMapper _mapper;

        public UpdateMsgTypeCommandHandler(IAsyncRepository<MessageType> messageTypeRepository, IMapper mapper)
        {
            _messageTypeRepository = messageTypeRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateMsgTypeCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Message Type has been Updated"
                : "تم تعديل عنوان الرسالة";

            var messageTypeToUpdate = await _messageTypeRepository.GetByIdAsync(request.Id);
            if (messageTypeToUpdate == null)
            {
                msg = request.lang == "en"
                ? "Message Type Not Found"
                : "نوع الرسالة غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            _mapper.Map(request, messageTypeToUpdate, typeof(UpdateMsgTypeCommand), typeof(MessageType));

            await _messageTypeRepository.UpdateAsync(messageTypeToUpdate);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
