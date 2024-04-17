using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
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
            string ResponseMessage = string.Empty;

            List<GetAllGeneralFAQListVM> GeneralFAQs = await _GeneralFAQRepository
                .Where(x => x.GeneralFrequentlyAskedQuestionCategoryId == Request.CategoryId)
                .OrderByDescending(x => x.CreatedAt)
                .Select(x => new GetAllGeneralFAQListVM()
                {
                    Id = x.Id,
                    Answer = Request.lang! == "ar"
                        ? x.ArabicAnswer
                        : x.EnglishAnswer,
                    Question = Request.lang! == "ar"
                        ? x.ArabicQuestion
                        : x.EnglishQuestion
                }).ToListAsync();

            int TotalCount = _GeneralFAQRepository.GetCount(null);

            Pagination Pagination = new Pagination(Request.page, Request.pageSize, TotalCount);

            return new BaseResponse<List<GetAllGeneralFAQListVM>>(ResponseMessage, true, 200, GeneralFAQs, Pagination);
        }
    }
}
