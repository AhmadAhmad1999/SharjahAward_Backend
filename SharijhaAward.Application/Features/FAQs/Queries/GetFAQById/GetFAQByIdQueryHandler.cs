using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetFAQById
{
    public class GetFAQByIdQueryHandler : IRequestHandler<GetFAQByIdQuery, BaseResponse<FAQDto>>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqRepository;
        private readonly IMapper _mapper;

        public GetFAQByIdQueryHandler(IAsyncRepository<FrequentlyAskedQuestion> faqRepository, IMapper mapper)
        {
            _faqRepository = faqRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<FAQDto>> Handle(GetFAQByIdQuery request, CancellationToken cancellationToken)
        {
            var faq = await _faqRepository.GetByIdAsync(request.Id);
            string msg;

            if (faq == null)
            {
                msg = request.lang == "en"
                    ? "The FAQ Not Found"
                    : "السؤال الشائع غير موجود";

                return new BaseResponse<FAQDto>(msg, false, 404);
            }
            var data = _mapper.Map<FAQDto>(faq);

            data.Answer = request.lang == "en"
               ? data.EnglishAnswer
               : data.ArabicAnswer;


            data.Question = request.lang == "en"
                ? data.EnglishQuestion
                : data.ArabicQuestion;

            return new BaseResponse<FAQDto>("", true, 200,data);
        }
    }
}
