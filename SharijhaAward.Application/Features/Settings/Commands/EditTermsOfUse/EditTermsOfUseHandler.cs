using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TermsOfUse;

namespace SharijhaAward.Application.Features.Settings.Commands.EditTermsOfUse
{
    public class EditTermsOfUseHandler : IRequestHandler<EditTermsOfUseCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TermsOfUse> _TermsOfUseRepository;
        public EditTermsOfUseHandler(IAsyncRepository<TermsOfUse> TermsOfUseRepository)
        {
            _TermsOfUseRepository = TermsOfUseRepository;
        }
        public async Task<BaseResponse<object>> Handle(EditTermsOfUseCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TermsOfUse? TermsOfUseEntity = await _TermsOfUseRepository
                .FirstOrDefaultAsync(x => x.Id == 1);

            if (TermsOfUseEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Terms of use is not found"
                    : "شروط الاستخدام غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            TermsOfUseEntity.ArabicText = Request.ArabicText;
            TermsOfUseEntity.EnglishText = Request.EnglishText;

            await _TermsOfUseRepository.UpdateAsync(TermsOfUseEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
