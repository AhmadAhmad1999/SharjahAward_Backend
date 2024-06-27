using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.HomePageSliderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.HomePageSliderItems.Commands.UpdateHomePageSliderItem
{
    public class UpdateHomePageSliderItemQueryHandler
        : IRequestHandler<UpdateHomePageSliderItemQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<HomePageSlider> _homePageSliderRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateHomePageSliderItemQueryHandler(IAsyncRepository<HomePageSlider> homePageSliderRepository, IFileService fileService, IMapper mapper)
        {
            _homePageSliderRepository = homePageSliderRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateHomePageSliderItemQuery request, CancellationToken cancellationToken)
        {
            var item = await _homePageSliderRepository.GetByIdAsync(request.Id);
            string msg;

            if (item == null)
            {
                msg = request.lang == "en"
                    ? "The News is not Found"
                    : "الخبر غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            var image = item.ImageUrl;
            
            _mapper.Map(request, item, typeof(UpdateHomePageSliderItemQuery), typeof(HomePageSlider));

            item.ImageUrl = request.EditOnImage == true
                ? item.ImageUrl = await _fileService.SaveFileAsync(request.Image!)
                : item.ImageUrl = image;

            await _homePageSliderRepository.UpdateAsync(item);

            msg = request.lang == "en"
                ? "The news has been Updated"
                : "تم تعديل الخبر بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
