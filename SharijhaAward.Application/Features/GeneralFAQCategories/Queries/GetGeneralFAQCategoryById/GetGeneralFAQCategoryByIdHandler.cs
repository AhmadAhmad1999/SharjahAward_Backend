using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetGeneralFAQCategoryById
{
    public class GetGeneralFAQCategoryByIdHandler : IRequestHandler<GetGeneralFAQCategoryByIdQuery, BaseResponse<GetGeneralFAQCategoryByIdDto>>
    {
        private readonly IAsyncRepository<GeneralFAQ> _GeneralFAQRepository;
        private readonly IAsyncRepository<GeneralFAQCategory> _GeneralFAQCategoryRepository;

        public GetGeneralFAQCategoryByIdHandler(IAsyncRepository<GeneralFAQ> GeneralFAQRepository,
            IAsyncRepository<GeneralFAQCategory> GeneralFAQCategoryRepository)
        {
            _GeneralFAQRepository = GeneralFAQRepository;
            _GeneralFAQCategoryRepository = GeneralFAQCategoryRepository;
        }
        public async Task<BaseResponse<GetGeneralFAQCategoryByIdDto>> Handle(GetGeneralFAQCategoryByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            GeneralFAQCategory? GeneralFAQCategory = await _GeneralFAQCategoryRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (GeneralFAQCategory == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "General FAQ category is not found"
                    : "فئة السؤال الشائع العام غير موجودة";

                return new BaseResponse<GetGeneralFAQCategoryByIdDto>(ResponseMessage, false, 404);
            }

            GetGeneralFAQCategoryByIdDto GetGeneralFAQCategoryByIdDto = new GetGeneralFAQCategoryByIdDto()
            {
                Id = GeneralFAQCategory.Id,
                Name = Request.lang == "ar"
                    ? GeneralFAQCategory.ArabicName
                    : GeneralFAQCategory.EnglishName,
                GeneralFAQListVM = await _GeneralFAQRepository.Where(x => x.GeneralFrequentlyAskedQuestionCategoryId == GeneralFAQCategory.Id)
                    .Select(x => new GetAllGeneralFAQCategory.GetAllGeneralFAQListVM()
                    {
                        Id = x.Id,
                        Answer = Request.lang == "ar"
                            ? x.ArabicAnswer
                            : x.EnglishAnswer,
                        Question = Request.lang == "ar"
                            ? x.ArabicQuestion
                            : x.EnglishQuestion
                    }).ToListAsync()
            };

            return new BaseResponse<GetGeneralFAQCategoryByIdDto>(ResponseMessage, true, 200, GetGeneralFAQCategoryByIdDto);
        }
    }
}