using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.RelatedAccountModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.CreateDirectRelating
{
    public class CreateDirectRelatingHandler : IRequestHandler<CreateDirectRelatingCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<RelatedAccount> _RelatedAccountRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<RelatedAccountRequest> _RelatedAccountRequestRepository;

        public CreateDirectRelatingHandler(IAsyncRepository<RelatedAccount> RelatedAccountRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<RelatedAccountRequest> RelatedAccountRequestRepository)
        {
            _RelatedAccountRepository = RelatedAccountRepository;
            _UserRoleRepository = UserRoleRepository;
            _RelatedAccountRequestRepository = RelatedAccountRequestRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateDirectRelatingCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            UserRole? UserRole = await _UserRoleRepository
                .Include(x => x.Role!)
                .Include(x => x.User!)
                .FirstOrDefaultAsync(x => x.User!.Email.ToLower() == Request.ReceiverEmail.ToLower() && x.User!.isValidAccount &&
                    x.Role!.EnglishName.ToLower() == "Subscriber".ToLower());

            if (UserRole == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Account is not found"
                    : "الحساب غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }
            else if (UserRole.UserId == Request.SenderId)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This is your account's email so you can't send a request to yourself"
                    : "البريد الإلكتروني المدخل هو الخاص بحسابك الشخصي ولا يمكنك إرسال طلب لنفسك";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }
            
            RelatedAccount? CheckIfRelatedAccountIsAlreadyExist = await _RelatedAccountRepository
                .FirstOrDefaultAsync(x => x.User1Id == Request.SenderId && x.User2Id == UserRole.UserId);

            if (CheckIfRelatedAccountIsAlreadyExist is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "You already have this account in your linked accounts"
                    : "هذا الحساب موجود مسبقاً في قائمة الحسابات المرتبطة الخاصة بك";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            RelatedAccountRequest? CheckIfRelatedAccountRequestIsAlreadyExist = await _RelatedAccountRequestRepository
                .FirstOrDefaultAsync(x => x.SenderId == Request.SenderId && x.ReceiverId == UserRole.UserId);

            RelatedAccount NewRelatedAccountEntity = new RelatedAccount()
            {
                isDeleted = false,
                CreatedAt = DateTime.UtcNow,
                CreatedBy = null,
                DeletedAt = null,
                LastModifiedAt = null,
                LastModifiedBy = null,
                User1Id = Request.SenderId,
                User2Id = UserRole.UserId
            };

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    if (CheckIfRelatedAccountRequestIsAlreadyExist is not null)
                    {
                        await _RelatedAccountRequestRepository.DeleteAsync(CheckIfRelatedAccountRequestIsAlreadyExist);
                    }

                    await _RelatedAccountRepository.AddAsync(NewRelatedAccountEntity);

                    ResponseMessage = Request.lang == "en"
                        ? "Relating is successful"
                        : "تم إنشاء الارتباط بنجاح";

                    Transaction.Complete();

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
