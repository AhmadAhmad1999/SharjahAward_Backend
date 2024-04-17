using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.MessageTypes.Commands.DeleteMsgType
{
    public class DeleteMsgTypeCommandHandler
        : IRequestHandler<DeleteMsgTypeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<MessageType> _messageTypeRepository;

        public DeleteMsgTypeCommandHandler(IAsyncRepository<MessageType> messageTypeRepository)
        {
            _messageTypeRepository = messageTypeRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteMsgTypeCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Message Type has been Deleted"
                : "تم حذف نوع الرسالة بنجاح";

            var messageTypeToDelete = await _messageTypeRepository.GetByIdAsync(request.Id);
            
            if (messageTypeToDelete != null)
            {
                msg = request.lang == "en"
                ? "Message Type Not Found"
                : "نوع الرسالة غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _messageTypeRepository.DeleteAsync(messageTypeToDelete!);

            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
