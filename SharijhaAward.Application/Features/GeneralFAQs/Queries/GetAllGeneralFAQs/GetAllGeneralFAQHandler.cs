using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;

namespace SharijhaAward.Application.Features.GeneralFAQs.Queries.GetAllGeneralFAQs
{
    public class GetAllGeneralFAQHandler : IRequestHandler<GetAllGeneralFAQQuery, BaseResponse<List<GetAllGeneralFAQListVM>>>
    {
        private readonly IAsyncRepository<GeneralFAQ> _GeneralFAQRepository;
        private readonly IMapper _Mapper;

        public GetAllGeneralFAQHandler(IMapper Mapper,
            IAsyncRepository<GeneralFAQ> GeneralFAQRepository)
        {
            _Mapper = Mapper;
            _GeneralFAQRepository = GeneralFAQRepository;
        }

        public async Task<BaseResponse<List<GetAllGeneralFAQListVM>>> Handle(GetAllGeneralFAQQuery Request, CancellationToken cancellationToken)
        {
            FilterObject filterObject = new FilterObject() { Filters = Request.filters };
            
            string ResponseMessage = string.Empty;

            List<GetAllGeneralFAQListVM> GeneralFAQs = new List<GetAllGeneralFAQListVM>();

            if (Request.CategoryId is not null)
            {
                if (Request.page != 0 && Request.perPage != -1)
                {
                    GeneralFAQs = await _GeneralFAQRepository
                        .WhereThenFilter(x => x.GeneralFrequentlyAskedQuestionCategoryId == Request.CategoryId, filterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .Select(x => new GetAllGeneralFAQListVM()
                        {
                            Id = x.Id,
                            Answer = Request.lang! == "ar"
                                ? x.ArabicAnswer
                                : x.EnglishAnswer,
                            Question = Request.lang! == "ar"
                                ? x.ArabicQuestion
                                : x.EnglishQuestion,
                            GeneralFrequentlyAskedQuestionCategoryId = x.GeneralFrequentlyAskedQuestionCategoryId,
                            GeneralFrequentlyAskedQuestionCategoryName = Request.lang == "en"
                                ? x.GeneralFrequentlyAskedQuestionCategory!.EnglishName
                                : x.GeneralFrequentlyAskedQuestionCategory!.ArabicName
                        }).ToListAsync();
                }
                else
                {
                    GeneralFAQs = await _GeneralFAQRepository
                        .WhereThenFilter(x => x.GeneralFrequentlyAskedQuestionCategoryId == Request.CategoryId, filterObject)
                        .OrderByDescending(x => x.CreatedAt)
                        .Select(x => new GetAllGeneralFAQListVM()
                        {
                            Id = x.Id,
                            Answer = Request.lang! == "ar"
                                ? x.ArabicAnswer
                                : x.EnglishAnswer,
                            Question = Request.lang! == "ar"
                                ? x.ArabicQuestion
                                : x.EnglishQuestion,
                            GeneralFrequentlyAskedQuestionCategoryId = x.GeneralFrequentlyAskedQuestionCategoryId,
                            GeneralFrequentlyAskedQuestionCategoryName = Request.lang == "en"
                                ? x.GeneralFrequentlyAskedQuestionCategory!.EnglishName
                                : x.GeneralFrequentlyAskedQuestionCategory!.ArabicName
                        }).ToListAsync();
                }
            }
            else
            {
                GeneralFAQs = await _GeneralFAQRepository
                    .OrderByDescending(filterObject, x => x.CreatedAt, Request.page, Request.perPage)
                    .Select(x => new GetAllGeneralFAQListVM()
                    {
                        Id = x.Id,
                        Answer = Request.lang! == "ar"
                            ? x.ArabicAnswer
                            : x.EnglishAnswer,
                        Question = Request.lang! == "ar"
                            ? x.ArabicQuestion
                            : x.EnglishQuestion,
                        GeneralFrequentlyAskedQuestionCategoryId = x.GeneralFrequentlyAskedQuestionCategoryId,
                        GeneralFrequentlyAskedQuestionCategoryName = Request.lang == "en"
                            ? x.GeneralFrequentlyAskedQuestionCategory!.EnglishName
                            : x.GeneralFrequentlyAskedQuestionCategory!.ArabicName
                    }).ToListAsync();
            }

            int TotalCount = _GeneralFAQRepository.GetCount(null);

            Pagination Pagination = new Pagination(Request.page, Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllGeneralFAQListVM>>(ResponseMessage, true, 200, GeneralFAQs, Pagination);
        }
    }
}
