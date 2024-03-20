using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Settings.Queries.GetProfileById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PrivacyPolicy;

namespace SharijhaAward.Application.Features.Settings.Queries.GetPrivacyPolicy
{
    public class GetPrivacyPolicyHandler : IRequestHandler<GetPrivacyPolicyQuery, BaseResponse<GetPrivacyPolicyDto>>
    {
        private readonly IAsyncRepository<PrivacyPolicy> _PrivacyPolicyRepository;
        public GetPrivacyPolicyHandler(IAsyncRepository<PrivacyPolicy> PrivacyPolicyRepository)
        {
            _PrivacyPolicyRepository = PrivacyPolicyRepository;
        }
        public async Task<BaseResponse<GetPrivacyPolicyDto>> Handle(GetPrivacyPolicyQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            PrivacyPolicy? PrivacyPolicyEntity = await _PrivacyPolicyRepository.FirstOrDefaultAsync(x => x.Id == 1);

            if (PrivacyPolicyEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Privacy policy is not found"
                    : "سياسة الخصوصية غير موجودة";

                return new BaseResponse<GetPrivacyPolicyDto>(ResponseMessage, false, 404);
            }

            GetPrivacyPolicyDto GetPrivacyPolicyDto = new GetPrivacyPolicyDto()
            {
                Text = Request.lang == "en"
                    ? PrivacyPolicyEntity.EnglishText
                    : PrivacyPolicyEntity.ArabicText
            };

            return new BaseResponse<GetPrivacyPolicyDto>(ResponseMessage, true, 200, GetPrivacyPolicyDto);
        }
    }
}
