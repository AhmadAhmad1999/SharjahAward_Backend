using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetProvidedFormById
{
    public class GetProvidedFormByIdQueryHandler
        : IRequestHandler<GetProvidedFormByIdQuery, BaseResponse<ProvidedFormDto>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;       
        private readonly IUserRepository _userRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<ExtraAttachmentFile> _ExtraAttachmentFileRepository;
        private readonly IMapper _mapper;

        public GetProvidedFormByIdQueryHandler(
            IAsyncRepository<Category> categoryRepository, 
            IUserRepository userRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<CycleConditionAttachment> CycleConditionAttachmentRepository,
            IAsyncRepository<ConditionAttachment> ConditionAttachmentRepository,
            IAsyncRepository<ExtraAttachmentFile> ExtraAttachmentFileRepository,
            IMapper mapper)
        {
            _formRepository = formRepository;
            _categoryRepository = categoryRepository;
            _userRepository = userRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _ConditionAttachmentRepository = ConditionAttachmentRepository;
            _CycleConditionAttachmentRepository = CycleConditionAttachmentRepository;
            _ExtraAttachmentFileRepository = ExtraAttachmentFileRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<ProvidedFormDto>> Handle(GetProvidedFormByIdQuery request, CancellationToken cancellationToken)
        {

            var User = await _userRepository.GetByIdAsync(request.UserId);

            if (User == null)
            {
                return new BaseResponse<ProvidedFormDto>("User Not Found", false, 404);
            }

            var form = await _formRepository.FirstOrDefaultAsync(f => f.Id == request.Id);

             if (form == null)
             {
                 return new BaseResponse<ProvidedFormDto>("Provided Form Not Found", false, 404);
             }
            var data = _mapper.Map<ProvidedFormDto>(form);


            var AllCycleConditionAttachmentEntities = await _CycleConditionAttachmentRepository
                .Where(x => form.Id == x.CycleConditionsProvidedForm!.ProvidedFormId &&
                    x.CycleConditionsProvidedForm!.CycleCondition!.NeedAttachment &&
                    (x.IsAccept != null ? !x.IsAccept.Value : false))
                .ToListAsync();

            var AllConditionAttachmentEntities = await _ConditionAttachmentRepository
                .Where(x => form.Id == x.ConditionsProvidedForms!.ProvidedFormId &&
                    x.ConditionsProvidedForms.TermAndCondition.NeedAttachment &&
                    (x.IsAccept != null ? !x.IsAccept.Value : false))
                .ToListAsync();

            var AllExtraAttachmentFileEntities = await _ExtraAttachmentFileRepository
                .Where(x => form.Id == x.ExtraAttachment!.ProvidedFormId &&
                    (x.IsAccept != null ? !x.IsAccept.Value : false))
                .ToListAsync();

            var AllDynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                .Where(x => (x.isAccepted != null ? !x.isAccepted.Value : false) &&
                    data.Id == x.RecordId &&
                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1)
                .ToListAsync();

            var AllCriterionAttachmentEntities = await _CriterionAttachmentRepository
                .Where(x => form.Id == x.ProvidedFormId &&
                    (x.IsAccepted != null ? !x.IsAccepted.Value : false))
                .ToListAsync();

            var AllCriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                .Where(x => form.Id == x.ProvidedFormId &&
                    (x.IsAccepted != null ? !x.IsAccepted.Value : false))
                .ToListAsync();

            data.RejectedSteps = new List<int>();

            var cycleConditions = AllCycleConditionAttachmentEntities
                .Where(c => c.CycleConditionsProvidedForm.ProvidedFormId == form.Id)
                .ToList();

            if (cycleConditions.Any())
                data.RejectedSteps!.Add(1);

            var TermAndConditions = AllConditionAttachmentEntities
                            .Where(c => c.ConditionsProvidedForms!.ProvidedFormId == form.Id)
                            .ToList();

            if (TermAndConditions.Any())
                data.RejectedSteps!.Add(3);

            var ExtraAttachments = AllExtraAttachmentFileEntities
                .Where(e => e.ExtraAttachment!.ProvidedFormId == form.Id)
                .ToList();

            if (ExtraAttachments.Any())
                data.RejectedSteps!.Add(6);

            bool CheckIfThereIsRejectedDynamicFields = AllDynamicAttributeValueEntities
                .Any(x => x.RecordId == data.Id);

            if (CheckIfThereIsRejectedDynamicFields)
                data.RejectedSteps!.Add(4);

            bool CriterionAttachment = AllCriterionAttachmentEntities
                .Any(x => x.ProvidedFormId == data.Id);

            if (CriterionAttachment)
                data.RejectedSteps!.Add(5);

            bool CriterionItemAttachment = AllCriterionItemAttachmentEntities
                .Any(x => x.ProvidedFormId == data.Id);

            if (CriterionItemAttachment)
                data.RejectedSteps!.Add(5);

            if (data.RejectedSteps!.Count() > 0)
            {
                form.needSing = true;

                await _formRepository.UpdateAsync(form);
            }

            var Subcategory = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == form.categoryId);
            var Maincategory = await _categoryRepository.IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Subcategory!.ParentId);
            
            
            
            data.MainCategoryName = request.lang == "en" ? Maincategory.EnglishName : Maincategory.ArabicName;
            data.SubCategoryName = request.lang == "en" ? Subcategory.EnglishName : Subcategory.ArabicName;
           
            return new BaseResponse<ProvidedFormDto>("", true, 200, data);

        }
    }
}
