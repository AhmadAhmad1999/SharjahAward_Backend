using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PrivacyPolicy;

namespace SharijhaAward.Application.Features.Settings.Commands.EditPrivacyPolicy
{
    public class EditPrivacyPolicyHandler : IRequestHandler<EditPrivacyPolicyCommand, BaseResponse<object>>
    {
        private IAsyncRepository<PrivacyPolicy> _PrivacyPolicyRepository;
        public EditPrivacyPolicyHandler(IAsyncRepository<PrivacyPolicy> PrivacyPolicyRepository)
        {
            _PrivacyPolicyRepository = PrivacyPolicyRepository;
        }

        public async Task<BaseResponse<object>> Handle(EditPrivacyPolicyCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            PrivacyPolicy? PrivacyPolicyEntity = await _PrivacyPolicyRepository
                .FirstOrDefaultAsync(x => x.Id == 1);

            if (PrivacyPolicyEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Privay policy is not found"
                    : "سياسة الخصوصية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            PrivacyPolicyEntity.ArabicText = Request.ArabicText;
            PrivacyPolicyEntity.EnglishText = Request.EnglishText;

            await _PrivacyPolicyRepository.UpdateAsync(PrivacyPolicyEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
