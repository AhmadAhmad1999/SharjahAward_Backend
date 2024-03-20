using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideByCategoryId;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideDetailsByCategoryId
{
    public class GetExplanatoryGuideDetailsByCategoryIdQueryHandler
        : IRequestHandler<GetExplanatoryGuideDetailsByCategoryIdQuery, BaseResponse<ExplanatoryGuideDetailsDto>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository <ExplanatoryGuide> _explanatoryGuideRepository;
        private readonly IMapper _mapper;

        public GetExplanatoryGuideDetailsByCategoryIdQueryHandler(IAsyncRepository<Category> categoryRepository, IAsyncRepository<ExplanatoryGuide> explanatoryGuideRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _explanatoryGuideRepository = explanatoryGuideRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ExplanatoryGuideDetailsDto>> Handle(GetExplanatoryGuideDetailsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var Category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            if(Category == null)
            {
                return new BaseResponse<ExplanatoryGuideDetailsDto>("", false, 404);
            }
            var Guide = _explanatoryGuideRepository.Where(e=>e.CategoryId == Category.Id).FirstOrDefault();
            if(Guide == null)
            {
                return new BaseResponse<ExplanatoryGuideDetailsDto>("The Explanatory Guide not found", false, 404);

            }
            var data = _mapper.Map<ExplanatoryGuideDetailsDto>(Guide);
            
            data.Title = request.lang == "en"
                ? data.EnglishTitle
                : data.ArabicTitle;

            return new BaseResponse<ExplanatoryGuideDetailsDto>("",true,200,data);
        }
    }
}
