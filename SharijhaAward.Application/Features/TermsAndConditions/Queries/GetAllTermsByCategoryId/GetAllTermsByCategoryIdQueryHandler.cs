using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId
{
    public class GetAllTermsByCategoryIdQueryHandler
        : IRequestHandler<GetAllTermsByCategoryIdQuery, BaseResponse<List<TermAndConditionListVM>>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<TermAndCondition> _termRepository;
        private readonly IAsyncRepository<ConditionAttachment> _conditionAttachmentRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _providedFormRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionsProvidedFormsRepository;
        private readonly IUserRepository _userRepository;
   
        private readonly IMapper _mapper;

        public GetAllTermsByCategoryIdQueryHandler(
            IAsyncRepository<Category> categoryRepository,
            IAsyncRepository<TermAndCondition> termRepository,
            IAsyncRepository<ConditionAttachment> conditionAttachmentRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> providedFormRepository,
            IAsyncRepository<ConditionsProvidedForms> conditionsProvidedFormsRepository,
            IUserRepository userRepository,
         
            IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _providedFormRepository = providedFormRepository;
            _conditionAttachmentRepository = conditionAttachmentRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _termRepository = termRepository;
            _userRepository = userRepository;
     
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<TermAndConditionListVM>>> Handle(GetAllTermsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == request.CategoryId);
            string msg;
            if(category == null)
            {
                msg = request.lang == "en"
                    ? "Category Not Found"
                    : "الفئة غير موجودة";
                return new BaseResponse<List<TermAndConditionListVM>>(msg, false, 404);
            }

            var form = _providedFormRepository.FirstOrDefault(p => p.Id == request.formId);

            var Terms = await _termRepository
                .Where(t => t.CategoryId == category.Id)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();
            
            List<ConditionsProvidedForms> conditionsProvideds = await _conditionsProvidedFormsRepository
                .Where(x => Terms.Select(y => y.Id).Contains(x.TermAndConditionId) &&
                    x.ProvidedFormId == form!.Id)
                .ToListAsync();
           
            var data = _mapper.Map<List<TermAndConditionListVM>>(Terms);

            List<ConditionAttachment> AllConditionAttachmentEntities = await _conditionAttachmentRepository
                .Where(x => conditionsProvideds.Select(y => y.Id).Any(y => y == x.ConditionsProvidedFormsId))
                .ToListAsync();

            for (int i = 0; i<data.Count; i++)
            {
                data[i].ConditionsAttachments = _mapper.Map<ConditionProvidedFormListVm>(conditionsProvideds[i]);
               
                if (data[i].NeedAttachment)
                {
                    data[i].ConditionsAttachments!.Attachments = _mapper.Map<List<AttachmentListVM>>(AllConditionAttachmentEntities
                        .Where(x => x.ConditionsProvidedFormsId == conditionsProvideds[i].Id)
                        .ToList());
                }

                data[i].Title = request.lang == "en"
                    ? data[i].EnglishTitle
                    : data[i].ArabicTitle;

                data[i].Description = request.lang == "en"
                    ? data[i].EnglishDescription
                    : data[i].ArabicDescription;
            }
            return new BaseResponse<List<TermAndConditionListVM>>("", true, 200, data);
        }
    }
}
