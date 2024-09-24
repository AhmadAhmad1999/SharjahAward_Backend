using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.SearchForFAQs
{
    public class SearchForFAQsQueryHandler
        : IRequestHandler<SearchForFAQsQuery, BaseResponse<List<FAQListVm>>>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqQueryRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public SearchForFAQsQueryHandler(IAsyncRepository<FrequentlyAskedQuestion> faqQueryRepository, IAsyncRepository<Cycle> cycleRepository, IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _faqQueryRepository = faqQueryRepository;
            _cycleRepository = cycleRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<FAQListVm>>> Handle(SearchForFAQsQuery request, CancellationToken cancellationToken)
        {
            var Cycle = await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active);
            if (Cycle == null)
            {
                return new BaseResponse<List<FAQListVm>>("There is no Cycle Active", false, 404);
            }

            var Categories = _categoryRepository.Where(c => c.CycleId == Cycle.Id)
                .Include(x => x.Parent!).ToList();
            
            List<FrequentlyAskedQuestion> frequentlyAskedQuestions = new List<FrequentlyAskedQuestion>();
            for(int i = 0; i < Categories.Count; i++)
            {
                var FAQs = _faqQueryRepository.Where(f => f.CategoryId == Categories[i].Id).ToList();
                
                frequentlyAskedQuestions.AddRange(FAQs);
            }

            var AskedQuestions = request.SrearchQuery == null
                ? frequentlyAskedQuestions
                : frequentlyAskedQuestions.Where(
                f => f.EnglishQuestion.Contains(request.SrearchQuery)
                || f.EnglishAnswer.Contains(request.SrearchQuery)
                || f.ArabicQuestion.Contains(request.SrearchQuery)
                || f.ArabicAnswer.Contains(request.SrearchQuery)).ToList();

            var data = _mapper.Map<List<FAQListVm>>(AskedQuestions);

            return new BaseResponse<List<FAQListVm>>("", true, 200, data);
        }
    }
}
