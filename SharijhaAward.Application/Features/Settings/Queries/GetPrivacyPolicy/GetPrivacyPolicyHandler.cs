using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Settings.Queries.GetProfileById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.OnePageTextModel;

namespace SharijhaAward.Application.Features.Settings.Queries.GetPrivacyPolicy
{
    public class GetPrivacyPolicyHandler : IRequestHandler<GetPrivacyPolicyQuery, BaseResponse<GetPrivacyPolicyDto>>
    {
        private readonly IAsyncRepository<OnePageText> _OnePageTextRepository;
        public GetPrivacyPolicyHandler(IAsyncRepository<OnePageText> OnePageTextRepository)
        {
            _OnePageTextRepository = OnePageTextRepository;
        }
        public async Task<BaseResponse<GetPrivacyPolicyDto>> Handle(GetPrivacyPolicyQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            OnePageText? OnePageTextEntity = await _OnePageTextRepository.FirstOrDefaultAsync(x => x.Id == 1);

            if (OnePageTextEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Privacy policy is not found"
                    : "سياسة الخصوصية غير موجودة";

                return new BaseResponse<GetPrivacyPolicyDto>(ResponseMessage, false, 404);
            }

            GetPrivacyPolicyDto GetPrivacyPolicyDto = new GetPrivacyPolicyDto()
            {
                Text = Request.lang == "en"
                    ? OnePageTextEntity.EnglishText
                    : OnePageTextEntity.ArabicText
            };

            return new BaseResponse<GetPrivacyPolicyDto>(ResponseMessage, true, 200, GetPrivacyPolicyDto);
        }
    }
}
