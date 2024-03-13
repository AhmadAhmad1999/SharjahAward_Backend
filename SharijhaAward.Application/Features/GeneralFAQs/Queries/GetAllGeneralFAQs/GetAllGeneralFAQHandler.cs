using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.FAQModel;
using SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.GeneralFAQs.Queries.GetAllGeneralFAQs
{
    public class GetAllGeneralFAQHandler : IRequestHandler<GetAllGeneralFAQQuery, BaseResponse<List<GetAllGeneralFAQListVM>>>
    {
        private readonly IAsyncRepository<GeneralFrequentlyAskedQuestion> _GeneralFAQRepository;
        private readonly IMapper _Mapper;

        public GetAllGeneralFAQHandler(IMapper Mapper,
            IAsyncRepository<GeneralFrequentlyAskedQuestion> GeneralFAQRepository)
        {
            _Mapper = Mapper;
            _GeneralFAQRepository = GeneralFAQRepository;
        }

        public async Task<BaseResponse<List<GetAllGeneralFAQListVM>>> Handle(GetAllGeneralFAQQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<GetAllGeneralFAQListVM> GeneralFAQs = await _GeneralFAQRepository
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
