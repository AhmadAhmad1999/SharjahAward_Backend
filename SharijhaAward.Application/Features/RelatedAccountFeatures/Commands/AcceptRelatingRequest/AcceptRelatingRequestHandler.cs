using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RelatedAccountModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.AcceptRelatingRequest
{
    public class AcceptRelatingRequestHandler : IRequestHandler<AcceptRelatingRequestCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<RelatedAccountRequest> _RelatedAccountRequestRepository;
        private readonly IAsyncRepository<RelatedAccount> _RelatedAccountRepository;
        private readonly IJwtProvider _JwtProvider;
        public AcceptRelatingRequestHandler(IAsyncRepository<RelatedAccountRequest> RelatedAccountRequestRepository,
            IAsyncRepository<RelatedAccount> RelatedAccountRepository,
            IJwtProvider JwtProvider)
        {
            _RelatedAccountRequestRepository = RelatedAccountRequestRepository;
            _RelatedAccountRepository = RelatedAccountRepository;
            _JwtProvider = JwtProvider;
        }
        public async Task<BaseResponse<object>> Handle(AcceptRelatingRequestCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            RelatedAccountRequest? RelatedAccountRequestEntity = await _RelatedAccountRequestRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id &&
                    x.ReceiverId == UserId);

            if (RelatedAccountRequestEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Request is not found"
                    : "الطلب غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromSeconds(30)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    RelatedAccount NewRelatedAccountEntity = new RelatedAccount()
                    {
                        isDeleted = false,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        User1Id = RelatedAccountRequestEntity.SenderId,
                        User2Id = RelatedAccountRequestEntity.ReceiverId
                    };

                    RelatedAccountRequestEntity.Status = Domain.Constants.RelatedAccountRequestStatus.Accepted;

                    await _RelatedAccountRequestRepository.UpdateAsync(RelatedAccountRequestEntity);

                    //await _RelatedAccountRequestRepository.DeleteAsync(RelatedAccountRequestEntity);
                    await _RelatedAccountRepository.AddAsync(NewRelatedAccountEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Request accepted successfuly"
                        : "تم قبول الطلب بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
