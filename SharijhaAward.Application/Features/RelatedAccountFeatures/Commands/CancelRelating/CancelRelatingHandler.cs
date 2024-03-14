using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RelatedAccountModel;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.CancelRelating
{
    public class CancelRelatingHandler : IRequestHandler<CancelRelatingCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<RelatedAccount> _RelatedAccountRepository;
        public CancelRelatingHandler(IAsyncRepository<RelatedAccount> RelatedAccountRepository)
        {
            _RelatedAccountRepository = RelatedAccountRepository;
        }
        public async Task<BaseResponse<object>> Handle(CancelRelatingCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            RelatedAccount? RelatedAccountEntity = await _RelatedAccountRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (RelatedAccountEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Account is not found"
                    : "الحساب غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _RelatedAccountRepository.DeleteAsync(RelatedAccountEntity);

            ResponseMessage = Request.lang == "en"
                ? "Relating account has been canceled successfuly"
                : "تم حذف الارتباط بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
