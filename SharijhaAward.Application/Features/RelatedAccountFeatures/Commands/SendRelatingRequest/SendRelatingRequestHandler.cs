using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.FAQs.Commands.DeleteFAQ;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.FAQModel;
using SharijhaAward.Domain.Entities.RelatedAccountModel;
using SharijhaAward.Domain.Entities.SubscriberModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.SendRelatingRequest
{
    public class SendRelatingRequestHandler : IRequestHandler<SendRelatingRequestCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.SubscriberModel.Subscriber> _SubscriberRepository;
        private readonly IAsyncRepository<RelatedAccountRequest> _RelatedAccountRequestRepository;
        private readonly IJwtProvider _JWTProvider;

        public SendRelatingRequestHandler(IAsyncRepository<Domain.Entities.SubscriberModel.Subscriber> SubscriberRepository,
            IAsyncRepository<RelatedAccountRequest> RelatedAccountRequestRepository,
            IJwtProvider JWTProvider)
        {
            _SubscriberRepository = SubscriberRepository;
            _RelatedAccountRequestRepository = RelatedAccountRequestRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<object>> Handle(SendRelatingRequestCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.SubscriberModel.Subscriber? ReceiverUserEntity = await _SubscriberRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ReceiverId);

            if (ReceiverUserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Subscriber is not found"
                    : "المشترك غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            string SenderId = _JWTProvider.GetUserIdFromToken(Request.token!);

            RelatedAccountRequest NewRelatedAccountRequestEntity = new RelatedAccountRequest()
            {
                isDeleted = false,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                DeletedAt = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                SenderId = new Guid(SenderId),
                ReceiverId = ReceiverUserEntity.Id
            };

            await _RelatedAccountRequestRepository.AddAsync(NewRelatedAccountRequestEntity);

            ResponseMessage = Request.lang == "en"
                ? "Request sent successfuly"
                : "تم إرسال الطلب بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}