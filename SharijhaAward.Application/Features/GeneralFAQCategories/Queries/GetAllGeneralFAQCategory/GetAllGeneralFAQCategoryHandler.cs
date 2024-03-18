using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory
{
    public class GetAllGeneralFAQCategoryHandler : IRequestHandler<GetAllGeneralFAQCategoryQuery, 
        BaseResponse<List<GetAllGeneralFAQCategoryListVM>>>
    {
        private readonly IAsyncRepository<GeneralFrequentlyAskedQuestion> _GeneralFAQRepository;
        private readonly IAsyncRepository<GeneralFrequentlyAskedQuestionCategory> _GeneralFAQCategoryRepository;
        private readonly IMapper _Mapper;

        public GetAllGeneralFAQCategoryHandler(IMapper Mapper,
            IAsyncRepository<GeneralFrequentlyAskedQuestion> GeneralFAQRepository,
            IAsyncRepository<GeneralFrequentlyAskedQuestionCategory> GeneralFAQCategoryRepository)
        {
            _Mapper = Mapper;
            _GeneralFAQRepository = GeneralFAQRepository;
            _GeneralFAQCategoryRepository = GeneralFAQCategoryRepository;
        }

        public async Task<BaseResponse<List<GetAllGeneralFAQCategoryListVM>>> Handle(GetAllGeneralFAQCategoryQuery Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllGeneralFAQCategoryListVM> GeneralFAQCategories = await _GeneralFAQCategoryRepository
                .Select(x => new GetAllGeneralFAQCategoryListVM()
                {
                    Id = x.Id,
                    Name = Request.lang == "ar"
                        ? x.ArabicName
                        : x.EnglishName
                }).ToListAsync();

            foreach (GetAllGeneralFAQCategoryListVM GeneralFAQCategory in GeneralFAQCategories)
            {
                GeneralFAQCategory.GeneralFAQListVM = await _GeneralFAQRepository
                    .Where(x => x.GeneralFrequentlyAskedQuestionCategoryId == GeneralFAQCategory.Id)
                    .Select(x => new GetAllGeneralFAQListVM()
                    {
                        Id = x.Id,
                        Answer = Request.lang == "ar"
                            ? x.ArabicAnswer
                            : x.EnglishAnswer,
                        Question = Request.lang == "ar"
                            ? x.ArabicQuestion
                            : x.EnglishQuestion
                    }).ToListAsync();
            }

            return new BaseResponse<List<GetAllGeneralFAQCategoryListVM>>(ResponseMessage, true, 200, GeneralFAQCategories);
        }
    }
}
