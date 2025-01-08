using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;

namespace SharijhaAward.Application.Features.ContactUsPages.Commands.DeleteMessage
{
    public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;

        public DeleteMessageCommandHandler(IAsyncRepository<EmailMessage> _EmailMessageRepository)
        {
            this._EmailMessageRepository = _EmailMessageRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteMessageCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = Request.lang == "en"
                ? "Message has been deleted"
                : "تم حذف الرسالة";

            EmailMessage? EmailMessageEntityToDelete = await _EmailMessageRepository
                .IncludeThenFirstOrDefaultAsync(x => x.message!, x => x.Id == Request.Id);

            if (EmailMessageEntityToDelete is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Message not found"
                    : "الرسالة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _EmailMessageRepository.DeleteAsync(EmailMessageEntityToDelete);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
