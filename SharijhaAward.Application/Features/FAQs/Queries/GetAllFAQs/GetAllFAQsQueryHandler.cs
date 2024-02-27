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
            var FAQs = await _faqRepository.GetPagedReponseAsync(request.page,request.pageSize);
            string msg;
            if(FAQs.Count == 0)
            {
                msg = request.lang == "en"
                    ? "There is no FAQs"
                    : "لا يوجد أسألة شائعة";

                return new BaseResponse<List<FAQListVm>>(msg, false, 404);
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
            var data = _mapper.Map<List<FAQListVm>>(questions);

            msg = request.lang == "en"
                   ? "Retrieved Successfully"
                   : "تم الإسترجاع بنجاح";

            return new BaseResponse<List<FAQListVm>>(msg, true, 200,data);
        }
    }
}
