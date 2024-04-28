using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.OnePageTextModel;

namespace SharijhaAward.Application.Features.Settings.Queries.GetTermsOfUse
{
    public class GetTermsOfUseHandler : IRequestHandler<GetTermsOfUseQuery, BaseResponse<GetTermsOfUseDto>>
    {
        private readonly IAsyncRepository<OnePageText> OnePageTextRepository;
        public GetTermsOfUseHandler(IAsyncRepository<OnePageText> OnePageTextRepository)
        {
            this.OnePageTextRepository = OnePageTextRepository;
        }
        public async Task<BaseResponse<GetTermsOfUseDto>> Handle(GetTermsOfUseQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            OnePageText? OnePageTextEntity = await OnePageTextRepository
                .FirstOrDefaultAsync(x => x.Slug.ToLower() == Request.Slug.ToLower());

            if (OnePageTextEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Terms of use is not found"
                    : "شروط الاستخدام غير موجودة";

                return new BaseResponse<GetTermsOfUseDto>(ResponseMessage, false, 404);
            }

            GetTermsOfUseDto GetTermsOfUseDto = new GetTermsOfUseDto()
            {
                Text = Request.lang == "en"
                    ? OnePageTextEntity.EnglishText
                    : OnePageTextEntity.ArabicText
            };

            return new BaseResponse<GetTermsOfUseDto>(ResponseMessage, true, 200, GetTermsOfUseDto);
        }
    }
}
