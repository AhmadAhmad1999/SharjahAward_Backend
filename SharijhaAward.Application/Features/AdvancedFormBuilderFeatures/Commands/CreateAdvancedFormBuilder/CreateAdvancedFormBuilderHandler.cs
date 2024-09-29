using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributeFeaturesFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.CreateAdvancedFormBuilder
{
    public class CreateAdvancedFormBuilderHandler : IRequestHandler<CreateAdvancedFormBuilderCommand,
        BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderGeneralValidation> _AdvancedFormBuilderGeneralValidationRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependencyGroup> _AdvancedFormBuilderDependencyGroupRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependency> _DependencyRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependencyValidation> _DependencyValidationRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderViewWhenRelation> _AdvancedFormBuilderViewWhenRelationRepository;
        private readonly IMapper _Mapper;
        public CreateAdvancedFormBuilderHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderGeneralValidation> AdvancedFormBuilderGeneralValidationRepository,
            IAsyncRepository<AdvancedFormBuilderDependencyGroup> AdvancedFormBuilderDependencyGroupRepository,
            IAsyncRepository<AdvancedFormBuilderDependency> DependencyRepository,
            IAsyncRepository<AdvancedFormBuilderDependencyValidation> DependencyValidationRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository,
            IAsyncRepository<AdvancedFormBuilderViewWhenRelation> AdvancedFormBuilderViewWhenRelationRepository,
            IMapper Mapper)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderGeneralValidationRepository = AdvancedFormBuilderGeneralValidationRepository;
            _AdvancedFormBuilderDependencyGroupRepository = AdvancedFormBuilderDependencyGroupRepository;
            _DependencyRepository = DependencyRepository;
            _DependencyValidationRepository = DependencyValidationRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
            _AdvancedFormBuilderViewWhenRelationRepository = AdvancedFormBuilderViewWhenRelationRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(CreateAdvancedFormBuilderCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AttributeDataType? CheckIfAttributeDataTypeIdDoesExist = await _AttributeDataTypeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.AttributeDataTypeId);

            if (CheckIfAttributeDataTypeIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "Attribute data type is not Found"
                  : "نوع الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            AdvancedFormBuilderSection? CheckIfAdvancedFormBuilderSectionIdDoesExist = await _AdvancedFormBuilderSectionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.AdvancedFormBuilderSectionId);

            if (CheckIfAdvancedFormBuilderSectionIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "Section is not Found"
                  : "العنوان الرئيسي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (CheckIfAdvancedFormBuilderSectionIdDoesExist.TableTypeSection)
            {
                Request.IsUnique = false;
                Request.IsRequired = false;
            }

            AdvancedFormBuilder? CheckIfAdvancedFormBuilderNameIsUsed = await _AdvancedFormBuilderRepository
                .FirstOrDefaultAsync(x => x.AdvancedFormBuilderSectionId == Request.AdvancedFormBuilderSectionId &&
                    (x.ArabicLabel.ToLower() == Request.ArabicLabel.ToLower() ||
                        x.EnglishLabel.ToLower() == Request.EnglishLabel.ToLower()));

            if (CheckIfAdvancedFormBuilderNameIsUsed is not null)
            {
                if (CheckIfAdvancedFormBuilderNameIsUsed.ArabicLabel.ToLower() == Request.ArabicLabel.ToLower())
                    ResponseMessage = Request.lang == "en"
                        ? "This advanced form field's arabic name is already used"
                        : "اسم هذا الحقل باللغة العربية مستخدم مسبقاً";

                else if (CheckIfAdvancedFormBuilderNameIsUsed.ArabicLabel.ToLower() == Request.ArabicLabel.ToLower())
                    ResponseMessage = Request.lang == "en"
                        ? "This advanced form field's english name is already used"
                        : "اسم هذا الحقل باللغة العربية مستخدم مسبقاً";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            int LastOrderIdInSection = await _AdvancedFormBuilderRepository
                .Where(x => x.AdvancedFormBuilderSectionId == CheckIfAdvancedFormBuilderSectionIdDoesExist.Id)
                .OrderBy(x => x.OrderId)
                .Select(x => x.OrderId)
                .LastOrDefaultAsync();

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromSeconds(30)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    // Add Advanced Form Builder Attribute Main Data..
                    AdvancedFormBuilder NewAdvancedFormBuilderEntity = _Mapper.Map<AdvancedFormBuilder>(Request);
                    NewAdvancedFormBuilderEntity.Status = DynamicAttributeStatus.Active;
                    NewAdvancedFormBuilderEntity.OrderId = LastOrderIdInSection++;
                    NewAdvancedFormBuilderEntity.ArabicTitle = NewAdvancedFormBuilderEntity.ArabicLabel;
                    NewAdvancedFormBuilderEntity.EnglishTitle = NewAdvancedFormBuilderEntity.EnglishLabel;

                    await _AdvancedFormBuilderRepository.AddAsync(NewAdvancedFormBuilderEntity);

                    string? AttributeDataTypeName = _AttributeDataTypeRepository
                        .FirstOrDefault(x => x.Id == Request.AttributeDataTypeId)?.Name;

                    if (!string.IsNullOrEmpty(AttributeDataTypeName)
                        ? AttributeDataTypeName.ToLower().Contains("List".ToLower())
                        : false)
                    {
                        if (Request.Values == null)
                        {
                            ResponseMessage = Request.lang == "en"
                                ? "This field must have values"
                                : "يجب أن يتم تعبئة قيم لهذا الحقل";

                            Transaction.Dispose();
                            return new BaseResponse<object>(ResponseMessage, false, 400);
                        }

                        await _AdvancedFormBuilderListValueRepository.AddRangeAsync(Request.Values.Select(AdvancedFormBuilderListValue =>
                            new AdvancedFormBuilderListValue()
                            {
                                ArabicValue = AdvancedFormBuilderListValue.ArabicValue,
                                EnglishValue = AdvancedFormBuilderListValue.EnglishValue,
                                AdvancedFormBuilderId = NewAdvancedFormBuilderEntity.Id,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = null,
                                DeletedAt = null,
                                isDeleted = false,
                                LastModifiedAt = null,
                                LastModifiedBy = null
                            }));
                    }

                    // Add General Validaiton if The Request.AdvancedFormBuilderGeneralValidationObject is NOT NULL..
                    if (Request.GeneralValidationObject is not null)
                    {
                        AdvancedFormBuilderGeneralValidation NewAdvancedFormBuilderGeneralValidationEntity = _Mapper.Map<AdvancedFormBuilderGeneralValidation>(Request.GeneralValidationObject);
                        NewAdvancedFormBuilderGeneralValidationEntity.AdvancedFormBuilderId = NewAdvancedFormBuilderEntity.Id;

                        await _AdvancedFormBuilderGeneralValidationRepository.AddAsync(NewAdvancedFormBuilderGeneralValidationEntity);
                    }

                    // Add AdvancedFormBuilderDependency Validaiton if The Request.DependencyValidations is NOT NULL..
                    if (Request.DependencyValidations is not null)
                    {
                        foreach (CreateDependencyValidation DependencyValidationDTO in Request.DependencyValidations)
                        {
                            // Create New AdvancedFormBuilderDependencyGroupId To Combine The Group Of Dependenies With Each Other and With Their Validation..
                            AdvancedFormBuilderDependencyGroup NewAdvancedFormBuilderDependencyGroup = new AdvancedFormBuilderDependencyGroup();
                            await _AdvancedFormBuilderDependencyGroupRepository.AddAsync(NewAdvancedFormBuilderDependencyGroup);

                            foreach (CreateDependency DependencyDTO in DependencyValidationDTO.Dependencies)
                            {
                                AdvancedFormBuilderDependency NewDependencyEntity = _Mapper.Map<AdvancedFormBuilderDependency>(DependencyDTO);
                                NewDependencyEntity.AdvancedFormBuilderDependencyGroupId = NewAdvancedFormBuilderDependencyGroup.Id;
                                NewDependencyEntity.MainAdvancedFormBuilderId = NewAdvancedFormBuilderEntity.Id;
                                await _DependencyRepository.AddAsync(NewDependencyEntity);
                            }

                            AdvancedFormBuilderDependencyValidation NewDependencyValidationEntity = _Mapper.Map<AdvancedFormBuilderDependencyValidation>(DependencyValidationDTO);
                            NewDependencyValidationEntity.AdvancedFormBuilderDependencyGroupId = NewAdvancedFormBuilderDependencyGroup.Id;
                            await _DependencyValidationRepository.AddAsync(NewDependencyValidationEntity);
                        }
                    }

                    // Add ViewWhen Relation Data..
                    if (Request.ViewWhenDtos?.Any() ?? false)
                    {
                        List<AdvancedFormBuilderViewWhenRelation> NewViewWhenRelationEntities = Request.ViewWhenDtos
                            .Select(x => new AdvancedFormBuilderViewWhenRelation()
                            {
                                AdvancedFormBuilderId = NewAdvancedFormBuilderEntity.Id,
                                AdvancedFormBuilderListValueId = x.AttributeListValueId
                            }).ToList();

                        await _AdvancedFormBuilderViewWhenRelationRepository.AddRangeAsync(NewViewWhenRelationEntities);
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الحقل بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
