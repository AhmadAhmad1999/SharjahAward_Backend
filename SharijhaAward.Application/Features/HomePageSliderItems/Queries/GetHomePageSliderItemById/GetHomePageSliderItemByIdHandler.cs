using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using SharijhaAward.Domain.Entities.HomePageSliderModel;

namespace SharijhaAward.Application.Features.HomePageSliderItems.Queries.GetHomePageSliderItemById
{
    public class GetHomePageSliderItemByIdHandler 
        : IRequestHandler<GetHomePageSliderItemByIdQuery, BaseResponse<GetHomePageSliderItemByIdDto>>
    {
        private readonly IAsyncRepository<HomePageSlider> _HomePageSliderRepository;
        private readonly IMapper _Mapper;

        public GetHomePageSliderItemByIdHandler(IAsyncRepository<HomePageSlider> HomePageSliderRepository, IMapper Mapper)
        {
            _HomePageSliderRepository = HomePageSliderRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<GetHomePageSliderItemByIdDto>> 
            Handle(GetHomePageSliderItemByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            HomePageSlider? HomePageSliderEntity = await _HomePageSliderRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (HomePageSliderEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Home page slider is not found"
                    : "سلايدر الصور غير موجود";

                return new BaseResponse<GetHomePageSliderItemByIdDto>(ResponseMessage, false, 404);
            }

            GetHomePageSliderItemByIdDto GetHomePageSliderItemByIdDto = _Mapper.Map<GetHomePageSliderItemByIdDto>(HomePageSliderEntity);

            return new BaseResponse<GetHomePageSliderItemByIdDto>(ResponseMessage, true, 200, GetHomePageSliderItemByIdDto);
        }
    }
}
