using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.OnePageTextModel;

namespace SharijhaAward.Application.Features.Settings.Commands.EditTermsOfUse
{
    public class EditTermsOfUseHandler : IRequestHandler<EditTermsOfUseCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<OnePageText> _OnePageTextRepository;
        public EditTermsOfUseHandler(IAsyncRepository<OnePageText> OnePageTextRepository)
        {
            _OnePageTextRepository = OnePageTextRepository;
        }
        public async Task<BaseResponse<object>> Handle(EditTermsOfUseCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            OnePageText? TermsOfUseEntity = await _OnePageTextRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (TermsOfUseEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Terms of use is not found"
                    : "شروط الاستخدام غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            TermsOfUseEntity.ArabicText = Request.ArabicText;
            TermsOfUseEntity.EnglishText = Request.EnglishText;

            await _OnePageTextRepository.UpdateAsync(TermsOfUseEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
