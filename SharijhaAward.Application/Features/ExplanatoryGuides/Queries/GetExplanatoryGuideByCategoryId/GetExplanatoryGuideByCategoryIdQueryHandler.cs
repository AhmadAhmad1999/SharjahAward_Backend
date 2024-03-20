using MediatR;
using MimeKit;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ExplanatoryGuideModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideByCategoryId
{
    public class GetExplanatoryGuideByCategoryIdQueryHandler
         : IRequestHandler<GetExplanatoryGuideByCategoryIdQuery, BaseResponse<ExplanatoryGuideDto>>
    {
        private readonly IAsyncRepository<ExplanatoryGuide> _explanatoryGuideRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IFileService _fileService;
        
        public GetExplanatoryGuideByCategoryIdQueryHandler(
            IAsyncRepository<ExplanatoryGuide> explanatoryGuideRepository,
            IAsyncRepository<Category> categoryRepository,
            IFileService fileService)
        {
            _fileService = fileService;
            _categoryRepository = categoryRepository;
            _explanatoryGuideRepository = explanatoryGuideRepository;
        }

        public async Task<BaseResponse<ExplanatoryGuideDto>> Handle(GetExplanatoryGuideByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            if (category == null)
            {
                return new BaseResponse<ExplanatoryGuideDto>("Not Found", false, 404);
            }
            var Guide = _explanatoryGuideRepository.Where(g=>g.CategoryId==category.Id).FirstOrDefault();
            byte [] fileContent;
            if (Guide != null)
            {
                 fileContent = request.lang == "en"
               ? await _fileService.ReadFileAsync(Guide!.EnglishFilePath)
               : await _fileService.ReadFileAsync(Guide!.ArabicFilePath);
            }
            else
            {
                return new BaseResponse<ExplanatoryGuideDto>("The Explanatory Guide not found", false, 404);
                
            }
            var data = new ExplanatoryGuideDto()
            {
                fileContent = fileContent!,
                fileContentType = "applection/pdf",
                fileFileName = Guide!.EnglishTitle
            };

            return new BaseResponse<ExplanatoryGuideDto>("", true, 200, data);
            
        }
    }
}
