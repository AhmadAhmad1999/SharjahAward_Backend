using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Commands.UpdateTermAndCondition
{
    public class UpdateTermAndConditionCommandHandler 
        : IRequestHandler<UpdateTermAndConditionCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<TermAndCondition> _termAndConditionRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public UpdateTermAndConditionCommandHandler(IAsyncRepository<TermAndCondition> termAndConditionRepository, IAsyncRepository<Category> categoryRepository, IMapper mapper)
        {
            _termAndConditionRepository = termAndConditionRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateTermAndConditionCommand request, CancellationToken cancellationToken)
        {
            var termToUpdate = await _termAndConditionRepository.GetByIdAsync(request.Id);
            string msg;
            if (termToUpdate == null)
            {
                msg = request.lang == "en"
                   ? "Term and Condition not Found"
                   : "لا تتوفر بيانات";

                return new BaseResponse<object>(msg, false, 404);
            }

            var category = await _categoryRepository.GetByIdAsync(request.CategoryId);

            if(category == null || category.ParentId == null)
            {
                msg = request.lang == "en"
                   ? "Sub Category Not Found"
                   : "الفئة الفرعية غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            
            _mapper.Map(
                  request, 
                  termToUpdate,
                  typeof(UpdateTermAndConditionCommand),
                  typeof(TermAndCondition));

            await _termAndConditionRepository.UpdateAsync(termToUpdate);

            msg = request.lang == "en"
                ? "Term and Condition has been Updated"
                : "تم التعديل بنجاح";

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
