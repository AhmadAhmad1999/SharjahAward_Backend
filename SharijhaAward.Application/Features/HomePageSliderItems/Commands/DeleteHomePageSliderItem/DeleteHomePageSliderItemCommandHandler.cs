using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.HomePageSliderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.HomePageSliderItems.Commands.DeleteHomePageSliderItem
{
    public class DeleteHomePageSliderItemCommandHandler
        : IRequestHandler<DeleteHomePageSliderItemCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<HomePageSlider> _homePageSliderRepository;

        public DeleteHomePageSliderItemCommandHandler(IAsyncRepository<HomePageSlider> homePageSliderRepository)
        {
            _homePageSliderRepository = homePageSliderRepository;
        }
    
        public async Task<BaseResponse<object>> Handle(DeleteHomePageSliderItemCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Home Page Slider Item has been Deleted"
                : "تم حذف العنصر";

            var sliderItemToDelete = await _homePageSliderRepository.GetByIdAsync(request.Id);
            
            if(sliderItemToDelete == null)
            {
                 msg = request.lang == "en"
                     ? "Home Page Slider Item Not Found"
                     : "العنصر غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _homePageSliderRepository.DeleteAsync(sliderItemToDelete);

            return new BaseResponse<object>(msg, true, 200);
        
        }
    }
}
