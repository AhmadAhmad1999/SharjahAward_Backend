using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;

namespace SharijhaAward.Application.Features.GeneralFAQCategories.Queries.GetAllGeneralFAQCategory
{
    public class GetAllGeneralFAQCategoryHandler : IRequestHandler<GetAllGeneralFAQCategoryQuery, 
        BaseResponse<List<GetAllGeneralFAQCategoryListVM>>>
    {
        private readonly IAsyncRepository<GeneralFAQ> _GeneralFAQRepository;
        private readonly IAsyncRepository<GeneralFAQCategory> _GeneralFAQCategoryRepository;

        public GetAllGeneralFAQCategoryHandler(IAsyncRepository<GeneralFAQ> GeneralFAQRepository,
            IAsyncRepository<GeneralFAQCategory> GeneralFAQCategoryRepository)
        {
            _GeneralFAQRepository = GeneralFAQRepository;
            _GeneralFAQCategoryRepository = GeneralFAQCategoryRepository;
        }

        public async Task<BaseResponse<List<GetAllGeneralFAQCategoryListVM>>> Handle(GetAllGeneralFAQCategoryQuery Request,
            CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };

            string ResponseMessage = string.Empty;

            List<GetAllGeneralFAQCategoryListVM> GeneralFAQCategories = await _GeneralFAQCategoryRepository
                .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                .Select(x => new GetAllGeneralFAQCategoryListVM()
                {
                    Id = x.Id,
                    Name = Request.lang == "ar"
                        ? x.ArabicName
                        : x.EnglishName
                }).ToListAsync();

            List<GetAllGeneralFAQListVM> AllGeneralFAQEntities = new List<GetAllGeneralFAQListVM>();

            if (string.IsNullOrEmpty(Request.searchQuery))
            {
                AllGeneralFAQEntities = await _GeneralFAQRepository
                    .Where(x => GeneralFAQCategories.Select(y => y.Id).Contains(x.GeneralFrequentlyAskedQuestionCategoryId))
                    .OrderByDescending(x => x.CreatedAt)
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
            else
            {
                AllGeneralFAQEntities = await _GeneralFAQRepository
                    .Where(x => GeneralFAQCategories.Select(y => y.Id).Contains(x.GeneralFrequentlyAskedQuestionCategoryId) &&
                        (x.ArabicQuestion.Contains(Request.searchQuery!) ||
                         x.ArabicAnswer.Contains(Request.searchQuery!) ||
                         x.EnglishQuestion.Contains(Request.searchQuery!) || 
                         x.EnglishAnswer.Contains(Request.searchQuery!)))
                    .OrderByDescending(x => x.CreatedAt)
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

            int TotalCount = await _GeneralFAQCategoryRepository
                .WhereThenFilter(x => true, filterObject)
                .CountAsync();

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllGeneralFAQCategoryListVM>>(ResponseMessage, true, 200, GeneralFAQCategories, PaginationParameter);
        }
    }
}
