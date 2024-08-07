using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.OnePageTextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Settings.Queries.GetAboutApp
{
    public class GetAboutAppQueryHandler
        : IRequestHandler<GetAboutAppQuery, BaseResponse<AboutAppDto>>
    {
        private readonly IAsyncRepository<OnePageText> _onePageTextRepository;

        public GetAboutAppQueryHandler(IAsyncRepository<OnePageText> onePageTextRepository)
        {
            _onePageTextRepository = onePageTextRepository;
        }

        public async Task<BaseResponse<AboutAppDto>> Handle(GetAboutAppQuery request, CancellationToken cancellationToken)
        {
            var aboutAppPage = await _onePageTextRepository
                .FirstOrDefaultAsync(a => a.Slug.ToLower() == request.Slug.ToLower());

            if (aboutAppPage == null)
            {
                return new BaseResponse<AboutAppDto>("", false, 404);
            }

            var AboutAppDto = new AboutAppDto()
            {
                Text = request.lang == "en"
                    ? aboutAppPage.EnglishText
                    : aboutAppPage.ArabicText
            };

            return new BaseResponse<AboutAppDto>("", true, 200, AboutAppDto);
        }
    }
}
