using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.HomePageSliderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.HomePageSliderItems.Commands.CreateHomePageSliderItem
{
    public class CreateHomePageSliderItemCommandHandler
        : IRequestHandler<CreateHomePageSliderItemCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<HomePageSlider> _homePageSliderRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateHomePageSliderItemCommandHandler(IFileService fileService, IAsyncRepository<HomePageSlider> homePageSliderRepository, IMapper mapper)
        {
            _homePageSliderRepository = homePageSliderRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateHomePageSliderItemCommand request, CancellationToken cancellationToken)
        {
            var SliderItem = _mapper.Map<HomePageSlider>(request);

            SliderItem.ImageUrl = await _fileService.SaveFileAsync(request.Image, SystemFileType.Images);

            await _homePageSliderRepository.AddAsync(SliderItem);
           
            string msg = request.lang == "en"
                ? "Home Page Slider Item has been Creted"
                : "تم إضافة العنصر";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
