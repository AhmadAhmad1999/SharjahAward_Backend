using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributeFeaturesFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.UpdateDynamicAttribute
{
    public class UpdateDynamicAttributeHandler : IRequestHandler<UpdateDynamicAttributeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<GeneralValidation> _GeneralValidationRepository;
        private readonly IAsyncRepository<DependencyGroup> _DependencyGroupRepository;
        private readonly IAsyncRepository<Dependency> _DependencyRepository;
        private readonly IAsyncRepository<DependencyValidation> _DependencyValidationRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<ViewWhenRelation> _ViewWhenRelationRepository;
        private readonly IMapper _Mapper;

        public UpdateDynamicAttributeHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<GeneralValidation> GeneralValidationRepository,
            IAsyncRepository<DependencyGroup> DependencyGroupRepository,
            IAsyncRepository<Dependency> DependencyRepository,
            IAsyncRepository<DependencyValidation> DependencyValidationRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<ViewWhenRelation> ViewWhenRelationRepository,
            IMapper Mapper)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _GeneralValidationRepository = GeneralValidationRepository;
            _DependencyGroupRepository = DependencyGroupRepository;
            _DependencyRepository = DependencyRepository;
            _DependencyValidationRepository = DependencyValidationRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _ViewWhenRelationRepository = ViewWhenRelationRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttribute? CheckIfDynamicAttributeNameIsUsed = await _DynamicAttributeRepository
                .FirstOrDefaultAsync(x => x.DynamicAttributeSectionId == Request.DynamicAttributeSectionId &&
                    (x.ArabicLabel.ToLower() == Request.ArabicLabel.ToLower() ||
                        x.EnglishLabel.ToLower() == Request.EnglishLabel.ToLower()) &&
                    x.Id != Request.Id);

            if (CheckIfDynamicAttributeNameIsUsed is not null)
            {
                if (CheckIfDynamicAttributeNameIsUsed.ArabicLabel.ToLower() == Request.ArabicLabel.ToLower())
                    ResponseMessage = Request.lang == "en"
                        ? "This dynamic field's arabic name is already used"
                        : "اسم هذا الحقل باللغة العربية مستخدم مسبقاً";

                else if (CheckIfDynamicAttributeNameIsUsed.EnglishLabel.ToLower() == Request.EnglishLabel.ToLower())
                    ResponseMessage = Request.lang == "en"
                        ? "This dynamic field's english name is already used"
                        : "اسم هذا الحقل باللغة العربية مستخدم مسبقاً";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            DynamicAttribute? DynamicAttributeOldData = await _DynamicAttributeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (DynamicAttributeOldData == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (DynamicAttributeOldData.DynamicAttributeSection!.ArabicName == "المعلومات الأساسية" &&
                DynamicAttributeOldData.DynamicAttributeSection!.EnglishName == "Main Information")
            {
                DynamicAttributeOldData.ArabicLabel = Request.ArabicLabel;
                DynamicAttributeOldData.ArabicPlaceHolder = Request.ArabicPlaceHolder;
                DynamicAttributeOldData.EnglishLabel = Request.EnglishLabel;
                DynamicAttributeOldData.EnglishPlaceHolder = Request.EnglishPlaceHolder;
                DynamicAttributeOldData.IsRequired = Request.IsRequired;

                await _DynamicAttributeRepository.UpdateAsync(DynamicAttributeOldData);

                ResponseMessage = Request.lang == "en"
                    ? "Field has been updated successfully"
                    : "تم تعديل الحقل بنجاح";

                return new BaseResponse<object>(ResponseMessage, true, 200);
            }

            if (Request.AttributeDataTypeId != DynamicAttributeOldData.AttributeDataTypeId)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Dynamic attribute type can't be updated"
                    : "لا يمكن تعديل نوع الحقل بعد إنشاءه";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            GeneralValidation? GeneralValidationEntity = await _GeneralValidationRepository
                .FirstOrDefaultAsync(x => x.DynamicAttributeId == Request.Id);

            List<Dependency> DependenciesEntities = await _DependencyRepository
                .Where(x => x.MainDynamicAttributeId == Request.Id)
                .ToListAsync();

            List<DependencyValidation> DependencyValidationEntities = await _DependencyValidationRepository
                .Where(x => DependenciesEntities.Select(y => y.DependencyGroupId).Contains(x.DependencyGroupId))
                .ToListAsync();

            List<ViewWhenRelation> ViewWhenRelationEntities = await _ViewWhenRelationRepository
                .Where(x => x.DynamicAttributeId == Request.Id)
                .ToListAsync();

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    if (DynamicAttributeOldData.DynamicAttributeSection!.TableTypeSection)
                    {
                        Request.IsRequired = false;
                    }

                    UpdateDynamicAttributeValidator Validator = new UpdateDynamicAttributeValidator();
                    ValidationResult ValidationResult = await Validator.ValidateAsync(Request);

                    if (ValidationResult.Errors.Count > 0)
                        throw new ValidationException(ValidationResult.Errors);

                    _Mapper.Map(Request, DynamicAttributeOldData, typeof(UpdateDynamicAttributeCommand),
                        typeof(DynamicAttribute));

                    await _DynamicAttributeRepository.UpdateAsync(DynamicAttributeOldData);

                    List<DynamicAttributeListValue> OldDynamicAttributeValueEntities = await _DynamicAttributeListValueRepository
                        .Where(x => x.DynamicAttributeId == Request.Id)
                        .ToListAsync();

                    if (Request.Values is not null
                        ? Request.Values.Any()
                        : false)
                    {
                        List<DynamicAttributeListValue> NewDynamicAttributeListValuesEntities = Request.Values
                            .Where(x => x.Id == 0)
                            .Select(x => new DynamicAttributeListValue()
                            {
                                ArabicValue = x.ArabicValue,
                                EnglishValue = x.EnglishValue,
                                DynamicAttributeId = Request.Id
                            }).ToList();

                        if (NewDynamicAttributeListValuesEntities.Any())
                            await _DynamicAttributeListValueRepository.AddRangeAsync(NewDynamicAttributeListValuesEntities);

                        IEnumerable<UpdateDynamicAttributeValueDto> UpdatedDynamicAttributeListValues = Request.Values
                            .Where(x => x.Id != 0);

                        foreach (UpdateDynamicAttributeValueDto DynamicAttributeValue in UpdatedDynamicAttributeListValues)
                        {
                            DynamicAttributeListValue? DynamicAttributeListValueEntity = OldDynamicAttributeValueEntities
                                .FirstOrDefault(x => x.Id == DynamicAttributeValue.Id);

                            if (DynamicAttributeListValueEntity is not null)
                            {
                                if (DynamicAttributeListValueEntity.ArabicValue.ToLower() != DynamicAttributeValue.ArabicValue.ToLower() ||
                                    DynamicAttributeListValueEntity.EnglishValue.ToLower() != DynamicAttributeValue.EnglishValue.ToLower())
                                {
                                    DynamicAttributeListValueEntity.EnglishValue = DynamicAttributeValue.EnglishValue;
                                    DynamicAttributeListValueEntity.ArabicValue = DynamicAttributeValue.ArabicValue;

                                    await _DynamicAttributeListValueRepository.UpdateAsync(DynamicAttributeListValueEntity);
                                }
                            }
                        }
                    }

                    List<DynamicAttributeListValue> DeleteDynamicAttributeListValuesEntities = OldDynamicAttributeValueEntities
                        .Where(x => Request.Values != null
                            ? !Request.Values.Select(y => y.Id).Contains(x.Id)
                            : true)
                        .ToList();

                    if (DeleteDynamicAttributeListValuesEntities.Any())
                        await _DynamicAttributeListValueRepository.DeleteListAsync(DeleteDynamicAttributeListValuesEntities);

                    if (GeneralValidationEntity is not null)
                        await _GeneralValidationRepository.DeleteAsync(GeneralValidationEntity);

                    if (DependenciesEntities.Any())
                        await _DependencyRepository.DeleteListAsync(DependenciesEntities);

                    if (DependencyValidationEntities.Any())
                        await _DependencyValidationRepository.DeleteListAsync(DependencyValidationEntities);

                    if (ViewWhenRelationEntities.Any())
                        await _ViewWhenRelationRepository.DeleteListAsync(ViewWhenRelationEntities);

                    // Add General Validaiton if The Request.GeneralValidationObject is NOT NULL..
                    if (Request.GeneralValidationObject is not null)
                    {
                        GeneralValidation NewGeneralValidationEntity = _Mapper.Map<GeneralValidation>(Request.GeneralValidationObject);
                        NewGeneralValidationEntity.DynamicAttributeId = Request.Id;

                        await _GeneralValidationRepository.AddAsync(NewGeneralValidationEntity);
                    }

                    // Add Dependency Validaiton if The Request.DependencyValidations is NOT NULL..
                    if (Request.DependencyValidations is not null)
                    {
                        foreach (CreateDependencyValidation DependencyValidationDTO in Request.DependencyValidations)
                        {
                            // Create New DependencyGroupId To Combine The Group Of Dependenies With Each Other and With Their Validation..
                            DependencyGroup NewDependencyGroup = new DependencyGroup();
                            await _DependencyGroupRepository.AddAsync(NewDependencyGroup);

                            foreach (CreateDependency DependencyDTO in DependencyValidationDTO.Dependencies)
                            {
                                Dependency NewDependencyEntity = _Mapper.Map<Dependency>(DependencyDTO);
                                NewDependencyEntity.DependencyGroupId = NewDependencyGroup.Id;
                                NewDependencyEntity.MainDynamicAttributeId = Request.Id;
                                await _DependencyRepository.AddAsync(NewDependencyEntity);
                            }

                            DependencyValidation NewDependencyValidationEntity = _Mapper.Map<DependencyValidation>(DependencyValidationDTO);
                            NewDependencyValidationEntity.DependencyGroupId = NewDependencyGroup.Id;
                            await _DependencyValidationRepository.AddAsync(NewDependencyValidationEntity);
                        }
                    }

                    // Add ViewWhen Relation Data..
                    if (Request.ViewWhenDtos?.Any() ?? false)
                    {
                        List<ViewWhenRelation> NewViewWhenRelationEntities = Request.ViewWhenDtos
                            .Select(x => new ViewWhenRelation()
                            {
                                DynamicAttributeId = Request.Id,
                                DynamicAttributeListValueId = x.AttributeListValueId
                            }).ToList();

                        await _ViewWhenRelationRepository.AddRangeAsync(NewViewWhenRelationEntities);
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Field has been updated successfully"
                        : "تم تعديل الحقل بنجاح";

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
