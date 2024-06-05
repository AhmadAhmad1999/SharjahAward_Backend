using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.FAQs.Queries.GetAllFAQs;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Queries.GetFAQsByCategoryId
{
    public class GetAllFAQsByCategoryIdQueryHandler
        : IRequestHandler<GetAllFAQsByCategoryIdQuery ,BaseResponse<List<FAQListVm>>>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faqRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GetAllFAQsByCategoryIdQueryHandler(IAsyncRepository<FrequentlyAskedQuestion> faqRepository, IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _faqRepository = faqRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<FAQListVm>>> Handle(GetAllFAQsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            string msg;
            if (category == null)
            {
                msg = request.lang == "en"
                    ? "Category Not Found"
                    : "الفئة غير موجودة";

                return new BaseResponse<List<FAQListVm>>(msg, false, 404);
            }
            
            List<FrequentlyAskedQuestion> FAQs = new List<FrequentlyAskedQuestion>();

            if (request.page != 0 && request.perPage != -1)
                FAQs = await _faqRepository.Where(f => f.CategoryId == category.Id)
                    .OrderByDescending(x => x.CreatedAt)
                    .Skip((request.page - 1) * request.perPage)
                    .Take(request.perPage).ToListAsync();
            else
                FAQs = await _faqRepository.Where(f => f.CategoryId == category.Id)
                    .OrderByDescending(x => x.CreatedAt).ToListAsync();

            var data = _mapper.Map<List<FAQListVm>>(FAQs);
            for(int i = 0; i < data.Count; i++)
            {
                data[i].Answer = request.lang == "en" ? data[i].EnglishAnswer : data[i].ArabicAnswer;
                data[i].Question = request.lang == "en" ? data[i].EnglishQuestion : data[i].ArabicQuestion;
            }
            var count = await _faqRepository.GetCountAsync(t => t.CategoryId == request.CategoryId);

            Pagination pagination = new Pagination(request.page, request.perPage, count);
            return new BaseResponse<List<FAQListVm>>("", true, 200, data, pagination);
        }
    }
}
