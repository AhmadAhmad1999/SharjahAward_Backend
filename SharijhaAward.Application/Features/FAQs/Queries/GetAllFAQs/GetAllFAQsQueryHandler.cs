using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs
{
    public class GetAllFAQsQueryHandler 
        : IRequestHandler<GetAllFAQsQuery, List<FAQListVm>>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqRepository;
        private readonly IMapper _mapper;

        public GetAllFAQsQueryHandler(IAsyncRepository<FrequentlyAskedQuestion> faqRepository, IMapper mapper)
        {
            _faqRepository = faqRepository;
            _mapper = mapper;
        }

        public async Task<List<FAQListVm>> Handle(GetAllFAQsQuery request, CancellationToken cancellationToken)
        {
            var FAQs = await _faqRepository.ListAllAsync();

            if(FAQs.Count == 0)
            {
                throw new OpenQA.Selenium.NotFoundException("There is No FAQs");
            }

            List<FAQListVm> questions = new List<FAQListVm>();

            for(int i = 0; i< FAQs.Count; i++)
            {
                FAQListVm listVm = new FAQListVm()
                {
                    Id = FAQs[i].Id,
                    ArabicAnswer = FAQs[i].ArabicAnswer,
                    ArabicQuestion = FAQs[i].ArabicQuestion,
                    EnglishAnswer = FAQs[i].EnglishAnswer,
                    EnglishQuestion = FAQs[i].EnglishQuestion,

                    Answer = request.lang == "en"
                    ? FAQs[i].EnglishAnswer
                    : FAQs[i].ArabicAnswer,

                    Question = request.lang == "en"
                    ? FAQs[i].EnglishQuestion
                    : FAQs[i].ArabicQuestion,
                };
                questions.Add(listVm);

            }
            return _mapper.Map<List<FAQListVm>>(questions);
        }
    }
}
