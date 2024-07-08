using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using SharijhaAward.Domain.Entities.ReferenceSourcesModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ReferenceSources.Queries.GetReferenceSourcePage
{
    public class GetReferenceSourcePageQueryHandler
        : IRequestHandler<GetReferenceSourcePageQuery, BaseResponse<ReferenceSourceDto>>
    {
        private readonly IAsyncRepository<ReferenceSource> _referenceSourceRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<ExplanatoryGuide> _explanatoryGuideRepository;
        private readonly IMapper _mapper;

        public GetReferenceSourcePageQueryHandler(IAsyncRepository<ExplanatoryGuide> explanatoryGuideRepository, IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<Category> categoryRepository, IAsyncRepository<ReferenceSource> referenceSourceRepository, IMapper mepper)
        {
            _referenceSourceRepository = referenceSourceRepository;
            _categoryRepository = categoryRepository;
            _cycleRepository = cycleRepository;
            _explanatoryGuideRepository = explanatoryGuideRepository;
            _mapper = mepper;
        }

        public async Task<BaseResponse<ReferenceSourceDto>> Handle(GetReferenceSourcePageQuery request, CancellationToken cancellationToken)
        {
            var ReferenceSourcePage = await _referenceSourceRepository.FirstOrDefaultAsync(r => !r.isDeleted);

            //if (ReferenceSourcePage == null)
            //{
            //   string msg = request.lang == "en"
            //              ? "Reference Source Page Not Found"
            //              : "المصادر المرجعية غير موجودة";

            //    return new BaseResponse<ReferenceSourceDto>(msg, false, 404);
            //}

            var Cycle = await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active);
            
            var data = _mapper.Map<ReferenceSourceDto>(ReferenceSourcePage);

            data.ExplanatoryGuides = new List<CategoryExplanatoryGuideDto>();

            if (Cycle != null)
            {
                var SubCategories = await _categoryRepository
                    .Where(c => c.ParentId != null && c.CycleId == Cycle.Id)
                    .ToListAsync();

                foreach(var subCategory in SubCategories)
                {
                    var ExplanatoryGuide = await _explanatoryGuideRepository.Where(e => e.CategoryId == subCategory.Id).FirstOrDefaultAsync();
                    
                    if(ExplanatoryGuide != null)
                    {
                        var CategoryExplanatoryGuide = new CategoryExplanatoryGuideDto()
                        {
                            SubCategoryName = request.lang == "en" ? subCategory.EnglishName : subCategory.ArabicName,

                            ExplanatoryGuideUrl = request.lang == "en"
                                ? ExplanatoryGuide!.EnglishFilePath
                                : ExplanatoryGuide!.ArabicFilePath
                        };

                        data.ExplanatoryGuides.Add(CategoryExplanatoryGuide);
                    }

                }
            }

            data.Title = request.lang == "en"
                ? data.EnglishTitle
                : data.ArabicTitle;
            
            data.Sources = request.lang == "en"
                ? data.EnglishSources
                : data.ArabicSources;

            return new BaseResponse<ReferenceSourceDto>("", true, 200, data);
        }
    }
}
