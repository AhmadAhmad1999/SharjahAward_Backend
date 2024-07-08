using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AboutAwardPageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Commands.CreateAboutPage
{
    public class CreateAboutPageCommandHandler
        : IRequestHandler<CreateAboutPageCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AboutAwardPage> _aboutAwardPageRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateAboutPageCommandHandler(IAsyncRepository<AboutAwardPage> aboutAwardPageRepository, IFileService fileService, IMapper mapper)
        {
            _aboutAwardPageRepository = aboutAwardPageRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateAboutPageCommand request, CancellationToken cancellationToken)
        {
            int count =  _aboutAwardPageRepository.GetCount(a => !a.isDeleted);
           
            if (count > 0)
            {
                string msg = request.lang == "en"
                    ? "You Can't add tow About Pages"
                    : "لا يمكنك إضافة أكثر من صفحة";

                return new BaseResponse<object>("", false, 400);
            }
            var AboutPage = _mapper.Map<AboutAwardPage>(request);

            AboutPage.AboutImage = await _fileService.SaveFileAsync(request.AboutImage, 0);
            AboutPage.OurVisionImage = await _fileService.SaveFileAsync(request.OurVisionImage, 0);

            await _aboutAwardPageRepository.AddAsync(AboutPage);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
