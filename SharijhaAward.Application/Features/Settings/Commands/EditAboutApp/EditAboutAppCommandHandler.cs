using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.OnePageTextModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Settings.Commands.EditAboutApp
{
    public class EditAboutAppCommandHandler
        : IRequestHandler<EditAboutAppCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<OnePageText> _onePageTextRepository;
        
        public EditAboutAppCommandHandler(IAsyncRepository<OnePageText> onePageTextRepository)
        {
            _onePageTextRepository = onePageTextRepository;
        }
        public async Task<BaseResponse<object>> Handle(EditAboutAppCommand request, CancellationToken cancellationToken)
        {
            var aboutAppPage = await _onePageTextRepository
                .FirstOrDefaultAsync(a => a.Slug.ToLower() == request.Slug.ToLower());

            if (aboutAppPage == null)
            {
                return new BaseResponse<object>("", false, 404);
            }

            aboutAppPage.ArabicText = request.ArabicText;
            aboutAppPage.EnglishText = request.EnglishText;

            await _onePageTextRepository.UpdateAsync(aboutAppPage);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
