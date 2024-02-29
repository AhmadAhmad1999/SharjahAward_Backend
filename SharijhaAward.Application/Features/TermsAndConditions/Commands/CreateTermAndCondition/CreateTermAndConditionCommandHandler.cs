using Aspose.Pdf.Operators;
using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.News.Commands.CreateNews;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Commands.CreateTermAndCondition
{
    public class CreateTermAndConditionCommandHandler 
        : IRequestHandler<CreateTermAndConditionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TermAndCondition> _termAndConditionRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public CreateTermAndConditionCommandHandler(IAsyncRepository<TermAndCondition> termAndConditionRepository, IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _termAndConditionRepository = termAndConditionRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateTermAndConditionCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
            string msg;
            if(category == null || category.ParentId == null)
            {
                msg = request.lang == "en"
                    ? "Sub Category Not Found"
                    : "الفئة الفرعية غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            var TermAndCondition = _mapper.Map<TermAndCondition>(request);
            await _termAndConditionRepository.AddAsync(TermAndCondition);

            msg = request.lang == "en"
               ? "Created Succsess"
               : "تم الإنشاء بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
