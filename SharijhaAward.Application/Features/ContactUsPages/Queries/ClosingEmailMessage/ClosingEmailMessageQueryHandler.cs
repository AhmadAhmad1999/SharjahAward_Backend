using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ContactUsModels;

namespace SharijhaAward.Application.Features.ContactUsPages.Queries.ClosingEmailMessage
{
    public class ClosingEmailMessageQueryHandler
        : IRequestHandler<ClosingEmailMessageQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<EmailMessage> _EmailMessageRepository;

        public ClosingEmailMessageQueryHandler(IAsyncRepository<EmailMessage> _EmailMessageRepository)
        {
            this._EmailMessageRepository = _EmailMessageRepository;
        }

        public async Task<BaseResponse<object>> Handle(ClosingEmailMessageQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            EmailMessage? EmailMessageEntity = await _EmailMessageRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id); 
            
            if(EmailMessageEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Email message is not found"
                    : "رسالة الإيميل غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _EmailMessageRepository
                .Where(x => x.MessageId == EmailMessageEntity.MessageId)
                .ExecuteUpdateAsync(x => x.SetProperty(y => y.Status, Domain.Constants.ContactUsConstants.MessageStatus.Close));
           
            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
