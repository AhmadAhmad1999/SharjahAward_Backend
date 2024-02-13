using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetFAQById
{
    public class GetFAQByIdQueryHandler : IRequestHandler<GetFAQByIdQuery, FAQDto>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqRepository;
        private readonly IMapper _mapper;

        public GetFAQByIdQueryHandler(IAsyncRepository<FrequentlyAskedQuestion> faqRepository, IMapper mapper)
        {
            _faqRepository = faqRepository;
            _mapper = mapper;
        }

        public async Task<FAQDto> Handle(GetFAQByIdQuery request, CancellationToken cancellationToken)
        {
            var faq = await _faqRepository.GetByIdAsync(request.Id);
            if (faq == null)
            {
                throw new OpenQA.Selenium.NotFoundException("Frequently Asked Question Not Found");
            }

            FAQDto fAQDto = new FAQDto()
            {
                ArabicQuestion = faq.ArabicQuestion,
                EnglishQuestion = faq.EnglishQuestion,
                ArabicAnswer = faq.ArabicAnswer,
                EnglishAnswer = faq.EnglishAnswer,

                Answer = request.lang == "en"
                ? faq.EnglishAnswer
                : faq.ArabicAnswer,

                Question = request.lang == "en"
                ? faq.EnglishQuestion
                : faq.ArabicQuestion,
            };

            return _mapper.Map<FAQDto>(fAQDto);
        }
    }
}
