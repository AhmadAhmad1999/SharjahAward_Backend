using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RelatedAccountModel;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.SendRelatingRequest
{
    public class SendRelatingRequestHandler : IRequestHandler<SendRelatingRequestCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<RelatedAccountRequest> _RelatedAccountRequestRepository;
        private readonly IJwtProvider _JWTProvider;

        public SendRelatingRequestHandler(IUserRepository UserRepository,
            IAsyncRepository<RelatedAccountRequest> RelatedAccountRequestRepository,
            IJwtProvider JWTProvider)
        {
            _UserRepository = UserRepository;
            _RelatedAccountRequestRepository = RelatedAccountRequestRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<object>> Handle(SendRelatingRequestCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? ReceiverUserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.ReceiverEmail.ToLower());

            if (ReceiverUserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Account is not found"
                    : "الحساب غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 400);
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