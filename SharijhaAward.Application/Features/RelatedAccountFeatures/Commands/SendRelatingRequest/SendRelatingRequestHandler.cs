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
        private readonly IAsyncRepository<RelatedAccount> _RelatedAccountRepository;
        private readonly IJwtProvider _JWTProvider;

        public SendRelatingRequestHandler(IUserRepository UserRepository,
            IAsyncRepository<RelatedAccountRequest> RelatedAccountRequestRepository,
            IAsyncRepository<RelatedAccount> RelatedAccountRepository,
            IJwtProvider JWTProvider)
        {
            _UserRepository = UserRepository;
            _RelatedAccountRequestRepository = RelatedAccountRequestRepository;
            _RelatedAccountRepository = RelatedAccountRepository;
            _JWTProvider = JWTProvider;
        }
        public async Task<BaseResponse<object>> Handle(SendRelatingRequestCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Guid SenderId = new Guid(_JWTProvider.GetUserIdFromToken(Request.token!));

            Domain.Entities.IdentityModels.User? ReceiverUserEntity = _UserRepository
                .Include(x => x.Role!)
                .FirstOrDefault(x => x.Email.ToLower() == Request.ReceiverEmail.ToLower() && x.isValidAccount &&
                    x.Role!.RoleName.ToLower() == "Subscriber".ToLower());

            if (ReceiverUserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Account is not found"
                    : "الحساب غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }
            else if (ReceiverUserEntity.Id == SenderId)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This is your account's email so you can't send a request to yourself"
                    : "البريد الإلكتروني المدخل هو الخاص بحسابك الشخصي ولا يمكنك إرسال طلب لنفسك";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            RelatedAccountRequest? CheckIfRelatedAccountRequestIsAlreadyExist = await _RelatedAccountRequestRepository
                .FirstOrDefaultAsync(x => x.SenderId == SenderId && x.ReceiverId == ReceiverUserEntity.Id);

            if (CheckIfRelatedAccountRequestIsAlreadyExist is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "You already sent a request to this account's email"
                    : "لقد قمت مسبقاً بإرسال طلب لهذا الحساب";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            RelatedAccount? CheckIfRelatedAccountIsAlreadyExist = await _RelatedAccountRepository
                .FirstOrDefaultAsync(x => (x.User1Id == SenderId || x.User2Id == SenderId) &&
                    (x.User1Id == ReceiverUserEntity.Id || x.User2Id == ReceiverUserEntity.Id));

            if (CheckIfRelatedAccountIsAlreadyExist is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "You already have this account in your linked accounts"
                    : "هذا الحساب موجود مسبقاً في قائمة الحسابات المرتبطة الخاصة بك";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            RelatedAccountRequest NewRelatedAccountRequestEntity = new RelatedAccountRequest()
            {
                isDeleted = false,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                DeletedAt = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                SenderId = SenderId,
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