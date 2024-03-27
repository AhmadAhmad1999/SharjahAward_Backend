using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.OnePageTextModel;

namespace SharijhaAward.Application.Features.Settings.Commands.EditPrivacyPolicy
{
    public class EditPrivacyPolicyHandler : IRequestHandler<EditPrivacyPolicyCommand, BaseResponse<object>>
    {
        private IAsyncRepository<OnePageText> _OnePageTextRepository;
        public EditPrivacyPolicyHandler(IAsyncRepository<OnePageText> OnePageTextRepository)
        {
            _OnePageTextRepository = OnePageTextRepository;
        }

        public async Task<BaseResponse<object>> Handle(EditPrivacyPolicyCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            OnePageText? OnePageTextEntity = await _OnePageTextRepository
                .FirstOrDefaultAsync(x => x.Id == 1);

            if (OnePageTextEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Privay policy is not found"
                    : "سياسة الخصوصية غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            OnePageTextEntity.ArabicText = Request.ArabicText;
            OnePageTextEntity.EnglishText = Request.EnglishText;

            await _OnePageTextRepository.UpdateAsync(OnePageTextEntity);

            ResponseMessage = Request.lang == "en"
                ? "Privay policy has been updated successfully"
                : "تم تعديل سياسة الخصوصية بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
