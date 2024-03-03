using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.FAQModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.FAQs.Commands.CreateFAQ
{
    public class CreateFAQCommandHandler 
        :IRequestHandler<CreateFAQCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<FrequentlyAskedQuestion> _faQRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CreateFAQCommandHandler(
            IAsyncRepository<FrequentlyAskedQuestion> faQRepository, 
            IAsyncRepository<Category> categoryRepository,
            IMapper mapper
            )
        {
            _faQRepository = faQRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateFAQCommand request, CancellationToken cancellationToken)
        {
            FrequentlyAskedQuestion faq = _mapper.Map<FrequentlyAskedQuestion>(request);
            Category category = await _categoryRepository.GetByIdAsync(faq.CategoryId);
            string msg;
            if (category == null)
            {
                msg = request.lang.ToLower() == "en"
                    ? "Category not Found"
                    : "الفئة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            await _faQRepository.AddAsync(faq);

            msg = request.lang == "en"
                ? "FAQ has been Created"
                : "تم إضافة السؤال الشائع";

            return new BaseResponse<object>(msg, true, 200);
         
        }
    }
}
