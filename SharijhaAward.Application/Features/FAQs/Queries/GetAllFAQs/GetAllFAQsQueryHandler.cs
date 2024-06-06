using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs
{
    public class GetAllFAQsQueryHandler 
        : IRequestHandler<GetAllFAQsQuery, BaseResponse<List<FAQListVm>>>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqRepository;
        private readonly IMapper _mapper;

        public GetAllFAQsQueryHandler(IAsyncRepository<FrequentlyAskedQuestion> faqRepository, IMapper mapper)
        {
            _faqRepository = faqRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<FAQListVm>>> Handle(GetAllFAQsQuery request, CancellationToken cancellationToken)
        {
            var FAQs = await _faqRepository.OrderByDescending(x => x.CreatedAt, request.page,request.perPage)
                .ToListAsync();

            var data = _mapper.Map<List<FAQListVm>>(FAQs);

            if(data.Count != 0)
            {
                for (int i = 0; i < data.Count; i++)
                {
                    data[i].Answer = request.lang == "en"
                    ? data[i].EnglishAnswer
                    : data[i].ArabicAnswer;

                    data[i].Question = request.lang == "en"
                     ? data[i].EnglishQuestion
                     : data[i].ArabicQuestion;
                }
            }
            int count = _faqRepository.GetCount(f => f.isDeleted == false);
            Pagination pagination = new Pagination(request.page, request.perPage, count);
            
            return new BaseResponse<List<FAQListVm>>("", true, 200, data, pagination);
        }
    }
}
