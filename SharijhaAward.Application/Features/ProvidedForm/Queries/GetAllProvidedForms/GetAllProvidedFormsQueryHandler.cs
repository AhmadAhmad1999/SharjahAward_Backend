using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.AttachmentModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.ConditionsProvidedFormsModel;
using SharijhaAward.Domain.Entities.CriterionItemModel;
using SharijhaAward.Domain.Entities.CriterionModel;
using SharijhaAward.Domain.Entities.CycleConditionsProvidedFormModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentModel;
using SharijhaAward.Domain.Entities.ExtraAttachmentProvidedFormModel;
using SharijhaAward.Domain.Entities.SystemAttachmentModel;
using SharijhaAward.Domain.Entities.TermsAndConditionsModel;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms
{
    public class GetAllProvidedFormsQueryHandler
        : IRequestHandler<GetAllProvidedFormsQuery, BaseResponse<List<FormListVm>>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<CycleConditionsProvidedForm> _cycleConditionsProvidedFormRepository;
        private readonly IAsyncRepository<ConditionsProvidedForms> _conditionsProvidedFormsRepository;
        private readonly IAsyncRepository<ExtraAttachment> _extraAttachmentRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        private readonly IAsyncRepository<CycleConditionAttachment> _CycleConditionAttachmentRepository;
        private readonly IAsyncRepository<ConditionAttachment> _ConditionAttachmentRepository;
        private readonly IAsyncRepository<ExtraAttachmentFile> _ExtraAttachmentFileRepository;

        public GetAllProvidedFormsQueryHandler(IAsyncRepository<ExtraAttachment> extraAttachmentRepository,  IAsyncRepository<ConditionsProvidedForms> conditionsProvidedFormsRepository, IAsyncRepository<CycleConditionsProvidedForm> cycleConditionsProvidedFormRepository, IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository, IAsyncRepository<Category> categoryRepository, IJwtProvider jwtProvider, IMapper mapper,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository,
            IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository,
            IAsyncRepository<CycleConditionAttachment> CycleConditionAttachmentRepository,
            IAsyncRepository<ConditionAttachment> ConditionAttachmentRepository,
            IAsyncRepository<ExtraAttachmentFile> ExtraAttachmentFileRepository)
        {
            _formRepository = formRepository;
            _userRepository = userRepository;
            _categoryRepository = categoryRepository;
            _jwtProvider = jwtProvider;
            _mapper = mapper;
            _cycleConditionsProvidedFormRepository = cycleConditionsProvidedFormRepository;
            _extraAttachmentRepository = extraAttachmentRepository;
            _conditionsProvidedFormsRepository = conditionsProvidedFormsRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
            _CycleConditionAttachmentRepository = CycleConditionAttachmentRepository;
            _ConditionAttachmentRepository = ConditionAttachmentRepository;
            _ExtraAttachmentFileRepository = ExtraAttachmentFileRepository;
        }

        public async Task<BaseResponse<List<FormListVm>>> Handle(GetAllProvidedFormsQuery request, CancellationToken cancellationToken)
        {
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            
            var User = await _userRepository.GetByIdAsync(int.Parse(UserId));
            
            if (User == null)
            {
                return new BaseResponse<List<FormListVm>> ("", false, 401);
            }
           
            FilterObject filterObject = new FilterObject() { Filters= request.filters };

            var form = request.Type == null
                ? await _formRepository.WhereThenFilter(f => f.userId == User.Id, filterObject).OrderByDescending(x => x.CreatedAt).ToListAsync()
                : await _formRepository.WhereThenFilter(f => f.userId == User.Id, filterObject).Where(f=>f.Type==request.Type)
                    .OrderByDescending(x => x.CreatedAt).ToListAsync();
           
            

            var data = _mapper.Map<List<FormListVm>> (form);

            List<CycleConditionAttachment> AllCycleConditionAttachmentEntities = await _CycleConditionAttachmentRepository
                .Include(x => x.CycleConditionsProvidedForm!)
                .Include(x => x.CycleConditionsProvidedForm!.CycleCondition!)
                .Where(x => form.Select(y => y.Id).Contains(x.CycleConditionsProvidedForm!.ProvidedFormId) &&
                    x.CycleConditionsProvidedForm!.CycleCondition!.NeedAttachment &&
                    (x.IsAccept != null ? !x.IsAccept.Value : false))
                .ToListAsync();

            List<ConditionAttachment> AllConditionAttachmentEntities = await _ConditionAttachmentRepository
                .Include(x => x.ConditionsProvidedForms!)
                .Include(x => x.ConditionsProvidedForms!.TermAndCondition!)
                .Where(x => form.Select(y => y.Id).Contains(x.ConditionsProvidedForms!.ProvidedFormId) &&
                    x.ConditionsProvidedForms.TermAndCondition.NeedAttachment &&
                    (x.IsAccept != null ? !x.IsAccept.Value : false))
                .ToListAsync();

            List<ExtraAttachmentFile> AllExtraAttachmentFileEntities = await _ExtraAttachmentFileRepository
                .Include(x => x.ExtraAttachment!)
                .Where(x => form.Select(y => y.Id).Contains(x.ExtraAttachment!.ProvidedFormId) &&
                    (x.IsAccept != null ? !x.IsAccept.Value : false))
                .ToListAsync();

            List<DynamicAttributeValue> AllDynamicAttributeValueEntities = await _DynamicAttributeValueRepository
                .Include(x => x.DynamicAttribute!)
                .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                .Where(x => (x.isAccepted != null ? !x.isAccepted.Value : false) &&
                    data.Select(y => y.Id).Any(y => y == x.RecordId) &&
                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1)
                .ToListAsync();

            List<CriterionAttachment> AllCriterionAttachmentEntities = await _CriterionAttachmentRepository
                .Where(x => data.Select(y => y.Id).Contains(x.ProvidedFormId) &&
                    (x.IsAccepted != null ? !x.IsAccepted.Value : false))
                .ToListAsync();

            List<CriterionItemAttachment> AllCriterionItemAttachmentEntities = await _CriterionItemAttachmentRepository
                .Where(x => data.Select(y => y.Id).Contains(x.ProvidedFormId) &&
                    (x.IsAccepted != null ? !x.IsAccepted.Value : false))
                .ToListAsync();

            for (int i = 0; i < data.Count(); i++)
            {
                var SubCategory = await _categoryRepository.GetByIdAsync(form[i].categoryId);
                
                if(SubCategory == null)
                {
                    return new BaseResponse<List<FormListVm>>("", false, 400);
                }

                var Category = await _categoryRepository.GetByIdAsync(SubCategory!.ParentId);
                
                if (Category == null)
                {
                    return new BaseResponse<List<FormListVm>>("", false, 400);
                }

                data[i].SubCategoryName = request.lang=="en"
                    ? SubCategory.EnglishName
                    : SubCategory.ArabicName;

                data[i].CategoryName = request.lang == "en"
                    ? Category.EnglishName
                    : Category.ArabicName;

                data[i].RejectedSteps = new List<int>();

                var cycleConditions = AllCycleConditionAttachmentEntities
                    .Where(c => c.CycleConditionsProvidedForm.ProvidedFormId == form[i].Id)
                    .ToList();

                if (cycleConditions.Any())
                    data[i].RejectedSteps!.Add(1);

                var TermAndConditions = AllConditionAttachmentEntities
                                .Where(c => c.ConditionsProvidedForms!.ProvidedFormId == form[i].Id)
                                .ToList();

                if (TermAndConditions.Any())
                    data[i].RejectedSteps!.Add(3);

                var ExtraAttachments = AllExtraAttachmentFileEntities
                    .Where(e => e.ExtraAttachment!.ProvidedFormId == form[i].Id)
                    .ToList();

                if (ExtraAttachments.Any())
                    data[i].RejectedSteps!.Add(6);

                bool CheckIfThereIsRejectedDynamicFields = AllDynamicAttributeValueEntities
                    .Any(x => x.RecordId == data[i].Id);

                if (CheckIfThereIsRejectedDynamicFields)
                    data[i].RejectedSteps!.Add(4);

                bool CriterionAttachment = AllCriterionAttachmentEntities
                    .Any(x => x.ProvidedFormId == data[i].Id);

                if (CriterionAttachment)
                    data[i].RejectedSteps!.Add(5);

                bool CriterionItemAttachment = AllCriterionItemAttachmentEntities
                    .Any(x => x.ProvidedFormId == data[i].Id);

                if (CriterionItemAttachment)
                    data[i].RejectedSteps!.Add(5);

                if (data[i].RejectedSteps!.Count() > 0)
                {
                    form[i].needSing = true;

                    await _formRepository.UpdateAsync(form[i]);
                }
            }

            return new BaseResponse<List<FormListVm>> ("", true, 200, data);
        }
    }
}
