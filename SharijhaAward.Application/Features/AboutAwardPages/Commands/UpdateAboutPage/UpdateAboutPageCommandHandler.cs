using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.AboutAwardPageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Commands.UpdateAboutPage
{
    public class UpdateAboutPageCommandHandler
        : IRequestHandler<UpdateAboutPageCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AboutAwardPage> _aboutAwardPageRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateAboutPageCommandHandler(IFileService fileService,IAsyncRepository<AboutAwardPage> aboutAwardPageRepository, IMapper mapper)
        {
            _aboutAwardPageRepository = aboutAwardPageRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateAboutPageCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "About Page has been Updated"
                : "تم التعديل بنجاح";

            var aboutPage = _aboutAwardPageRepository.FirstOrDefault(a => true);
            if(aboutPage == null)
            {
                return new BaseResponse<object>("About Page Not Found", false, 400);
            }
            var aboutPageImage = aboutPage.AboutImage;
            var OurVisionImage = aboutPage.OurVisionImage;
            
            _mapper.Map(request, aboutPage, typeof(UpdateAboutPageCommand), typeof(AboutAwardPage));

            aboutPage.AboutImage =  request.EditeOnAboutImage
                ? aboutPage.AboutImage = await _fileService.SaveFileAsync(request.AboutImage!, SystemFileType.Images)
                : aboutPage.AboutImage = aboutPageImage;

            aboutPage.OurVisionImage = request.EditeOnOurVisionImage == true
                ? aboutPage.OurVisionImage = await _fileService.SaveFileAsync(request.OurVisionImage!, SystemFileType.Images)
                : aboutPage.OurVisionImage = OurVisionImage;

            await _aboutAwardPageRepository.UpdateAsync(aboutPage);

            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
