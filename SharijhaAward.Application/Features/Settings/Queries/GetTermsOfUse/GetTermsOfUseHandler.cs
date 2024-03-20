using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TermsOfUse;

namespace SharijhaAward.Application.Features.Settings.Queries.GetTermsOfUse
{
    public class GetTermsOfUseHandler : IRequestHandler<GetTermsOfUseQuery, BaseResponse<GetTermsOfUseDto>>
    {
        private readonly IAsyncRepository<TermsOfUse> _TermsOfUseRepository;
        public GetTermsOfUseHandler(IAsyncRepository<TermsOfUse> TermsOfUseRepository)
        {
            _TermsOfUseRepository = TermsOfUseRepository;
        }
        public async Task<BaseResponse<GetTermsOfUseDto>> Handle(GetTermsOfUseQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TermsOfUse? TermsOfUseEntity = await _TermsOfUseRepository.FirstOrDefaultAsync(x => x.Id == 1);

            if (TermsOfUseEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Terms of use is not found"
                    : "شروط الاستخدام غير موجودة";

                return new BaseResponse<GetTermsOfUseDto>(ResponseMessage, false, 404);
            }

            GetTermsOfUseDto GetTermsOfUseDto = new GetTermsOfUseDto()
            {
                Text = Request.lang == "en"
                    ? TermsOfUseEntity.EnglishText
                    : TermsOfUseEntity.ArabicText
            };

            return new BaseResponse<GetTermsOfUseDto>(ResponseMessage, true, 200, GetTermsOfUseDto);
        }
    }
}
