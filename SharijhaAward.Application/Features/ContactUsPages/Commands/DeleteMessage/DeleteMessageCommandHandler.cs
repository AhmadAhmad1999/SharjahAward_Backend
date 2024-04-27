using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ContactUsPages.Commands.DeleteMessage
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EmailMessage> _emailMessageRepository;

        public DeleteMessageCommandHandler(IAsyncRepository<EmailMessage> emailMessageRepository)
        {
            _emailMessageRepository = emailMessageRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Message has been Deleted"
                : "تم حذف الرسالة";

            var messageToDelete = await _emailMessageRepository.GetByIdAsync(request.Id);
            if (messageToDelete == null)
            {
                msg = request.lang == "en"
                ? "Message not found"
                : "الرسالة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _emailMessageRepository.DeleteAsync(messageToDelete);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
