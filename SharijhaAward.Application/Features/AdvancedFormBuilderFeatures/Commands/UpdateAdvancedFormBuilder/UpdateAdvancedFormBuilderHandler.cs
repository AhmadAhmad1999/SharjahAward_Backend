using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Features.DynamicAttributeFeaturesFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.UpdateAdvancedFormBuilder
{
    public class UpdateAdvancedFormBuilderHandler : IRequestHandler<UpdateAdvancedFormBuilderCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderGeneralValidation> _AdvancedFormBuilderGeneralValidationRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependencyGroup> _AdvancedFormBuilderDependencyGroupRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependency> _AdvancedFormBuilderDependencyRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependencyValidation> _AdvancedFormBuilderDependencyValidationRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderViewWhenRelation> _AdvancedFormBuilderViewWhenRelationRepository;
        private readonly IMapper _Mapper;

        public UpdateAdvancedFormBuilderHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderGeneralValidation> AdvancedFormBuilderGeneralValidationRepository,
            IAsyncRepository<AdvancedFormBuilderDependencyGroup> AdvancedFormBuilderDependencyGroupRepository,
            IAsyncRepository<AdvancedFormBuilderDependency> AdvancedFormBuilderDependencyRepository,
            IAsyncRepository<AdvancedFormBuilderDependencyValidation> AdvancedFormBuilderDependencyValidationRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository,
            IAsyncRepository<AdvancedFormBuilderViewWhenRelation> AdvancedFormBuilderViewWhenRelationRepository,
            IMapper Mapper)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderGeneralValidationRepository = AdvancedFormBuilderGeneralValidationRepository;
            _AdvancedFormBuilderDependencyGroupRepository = AdvancedFormBuilderDependencyGroupRepository;
            _AdvancedFormBuilderDependencyRepository = AdvancedFormBuilderDependencyRepository;
            _AdvancedFormBuilderDependencyValidationRepository = AdvancedFormBuilderDependencyValidationRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
            _AdvancedFormBuilderViewWhenRelationRepository = AdvancedFormBuilderViewWhenRelationRepository;
            _Mapper = Mapper;
        }
        public async Task<BaseResponse<object>> Handle(UpdateAdvancedFormBuilderCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AdvancedFormBuilder? AdvancedFormBuilderOldData = await _AdvancedFormBuilderRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (AdvancedFormBuilderOldData == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (Request.AttributeDataTypeId != AdvancedFormBuilderOldData.AttributeDataTypeId)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Advanced form attribute type can't be updated"
                    : "لا يمكن تعديل نوع الحقل بعد إنشاءه";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            AdvancedFormBuilderGeneralValidation? AdvancedFormBuilderGeneralValidationEntity = await _AdvancedFormBuilderGeneralValidationRepository
                .FirstOrDefaultAsync(x => x.AdvancedFormBuilderId == Request.Id);

            List<AdvancedFormBuilderDependency> AdvancedFormBuilderDependenciesEntities = await _AdvancedFormBuilderDependencyRepository
                .Where(x => x.MainAdvancedFormBuilderId == Request.Id)
                .ToListAsync();

            List<AdvancedFormBuilderDependencyValidation> AdvancedFormBuilderDependencyValidationEntities = await _AdvancedFormBuilderDependencyValidationRepository
                .Where(x => AdvancedFormBuilderDependenciesEntities.Select(y => y.AdvancedFormBuilderDependencyGroupId).Contains(x.AdvancedFormBuilderDependencyGroupId))
                .ToListAsync();

            List<AdvancedFormBuilderViewWhenRelation> ViewWhenRelationEntities = await _AdvancedFormBuilderViewWhenRelationRepository
                .Where(x => x.AdvancedFormBuilderId == Request.Id)
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
                    if (AdvancedFormBuilderOldData.AdvancedFormBuilderSection!.TableTypeSection)
                    {
                        Request.IsRequired = false;
                    }

                    _Mapper.Map(Request, AdvancedFormBuilderOldData, typeof(UpdateAdvancedFormBuilderCommand),
                        typeof(AdvancedFormBuilder));

                    await _AdvancedFormBuilderRepository.UpdateAsync(AdvancedFormBuilderOldData);

                    List<AdvancedFormBuilderListValue> OldAdvancedFormBuilderValueEntities = await _AdvancedFormBuilderListValueRepository
                        .Where(x => x.AdvancedFormBuilderId == Request.Id)
                        .ToListAsync();

                    if (Request.Values is not null
                        ? Request.Values.Any()
                        : false)
                    {
                        List<AdvancedFormBuilderListValue> NewAdvancedFormBuilderListValuesEntities = Request.Values
                            .Where(x => x.Id == 0)
                            .Select(x => new AdvancedFormBuilderListValue()
                            {
                                ArabicValue = x.ArabicValue,
                                EnglishValue = x.EnglishValue,
                                AdvancedFormBuilderId = Request.Id
                            }).ToList();

                        if (NewAdvancedFormBuilderListValuesEntities.Any())
                            await _AdvancedFormBuilderListValueRepository.AddRangeAsync(NewAdvancedFormBuilderListValuesEntities);

                        IEnumerable<UpdateAdvancedFormBuilderValueDto> UpdatedAdvancedFormBuilderListValues = Request.Values
                            .Where(x => x.Id != 0);

                        foreach (UpdateAdvancedFormBuilderValueDto AdvancedFormBuilderValue in UpdatedAdvancedFormBuilderListValues)
                        {
                            AdvancedFormBuilderListValue? AdvancedFormBuilderListValueEntity = OldAdvancedFormBuilderValueEntities
                                .FirstOrDefault(x => x.Id == AdvancedFormBuilderValue.Id);

                            if (AdvancedFormBuilderListValueEntity is not null)
                            {
                                if (AdvancedFormBuilderListValueEntity.ArabicValue.ToLower() != AdvancedFormBuilderValue.ArabicValue.ToLower() ||
                                    AdvancedFormBuilderListValueEntity.EnglishValue.ToLower() != AdvancedFormBuilderValue.EnglishValue.ToLower())
                                {
                                    AdvancedFormBuilderListValueEntity.EnglishValue = AdvancedFormBuilderValue.EnglishValue;
                                    AdvancedFormBuilderListValueEntity.ArabicValue = AdvancedFormBuilderValue.ArabicValue;

                                    await _AdvancedFormBuilderListValueRepository.UpdateAsync(AdvancedFormBuilderListValueEntity);
                                }
                            }
                        }
                    }

                    List<AdvancedFormBuilderListValue> DeleteAdvancedFormBuilderListValuesEntities = OldAdvancedFormBuilderValueEntities
                        .Where(x => Request.Values != null
                            ? !Request.Values.Select(y => y.Id).Contains(x.Id)
                            : true)
                        .ToList();

                    if (DeleteAdvancedFormBuilderListValuesEntities.Any())
                        await _AdvancedFormBuilderListValueRepository.DeleteListAsync(DeleteAdvancedFormBuilderListValuesEntities);

                    if (AdvancedFormBuilderGeneralValidationEntity is not null)
                        await _AdvancedFormBuilderGeneralValidationRepository.DeleteAsync(AdvancedFormBuilderGeneralValidationEntity);

                    if (AdvancedFormBuilderDependenciesEntities.Any())
                        await _AdvancedFormBuilderDependencyRepository.DeleteListAsync(AdvancedFormBuilderDependenciesEntities);

                    if (AdvancedFormBuilderDependencyValidationEntities.Any())
                        await _AdvancedFormBuilderDependencyValidationRepository.DeleteListAsync(AdvancedFormBuilderDependencyValidationEntities);

                    if (ViewWhenRelationEntities.Any())
                        await _AdvancedFormBuilderViewWhenRelationRepository.DeleteListAsync(ViewWhenRelationEntities);

                    // Add General Validaiton if The Request.GeneralValidationObject is NOT NULL..
                    if (Request.GeneralValidationObject is not null)
                    {
                        AdvancedFormBuilderGeneralValidation NewAdvancedFormBuilderGeneralValidationEntity = _Mapper.Map<AdvancedFormBuilderGeneralValidation>(Request.GeneralValidationObject);
                        NewAdvancedFormBuilderGeneralValidationEntity.AdvancedFormBuilderId = Request.Id;

                        await _AdvancedFormBuilderGeneralValidationRepository.AddAsync(NewAdvancedFormBuilderGeneralValidationEntity);
                    }

                    // Add Dependency Validaiton if The Request.DependencyValidations is NOT NULL..
                    if (Request.DependencyValidations is not null)
                    {
                        foreach (CreateDependencyValidation DependencyValidationDTO in Request.DependencyValidations)
                        {
                            // Create New DependencyGroupId To Combine The Group Of Dependenies With Each Other and With Their Validation..
                            AdvancedFormBuilderDependencyGroup NewAdvancedFormBuilderGroup = new AdvancedFormBuilderDependencyGroup();
                            await _AdvancedFormBuilderDependencyGroupRepository.AddAsync(NewAdvancedFormBuilderGroup);

                            foreach (CreateDependency DependencyDTO in DependencyValidationDTO.Dependencies)
                            {
                                AdvancedFormBuilderDependency NewAdvancedFormBuilderDependencyEntity = _Mapper.Map<AdvancedFormBuilderDependency>(DependencyDTO);
                                NewAdvancedFormBuilderDependencyEntity.AdvancedFormBuilderDependencyGroupId = NewAdvancedFormBuilderGroup.Id;
                                NewAdvancedFormBuilderDependencyEntity.MainAdvancedFormBuilderId = Request.Id;
                                await _AdvancedFormBuilderDependencyRepository.AddAsync(NewAdvancedFormBuilderDependencyEntity);
                            }

                            AdvancedFormBuilderDependencyValidation NewAdvancedFormBuilderDependencyValidationEntity = _Mapper.Map<AdvancedFormBuilderDependencyValidation>(DependencyValidationDTO);
                            NewAdvancedFormBuilderDependencyValidationEntity.AdvancedFormBuilderDependencyGroupId = NewAdvancedFormBuilderGroup.Id;
                            await _AdvancedFormBuilderDependencyValidationRepository.AddAsync(NewAdvancedFormBuilderDependencyValidationEntity);
                        }
                    }

                    // Add ViewWhen Relation Data..
                    if (Request.ViewWhenDtos?.Any() ?? false)
                    {
                        List<AdvancedFormBuilderViewWhenRelation> NewAdvancedFormBuilderViewWhenRelationEntities = Request.ViewWhenDtos
                            .Select(x => new AdvancedFormBuilderViewWhenRelation()
                            {
                                AdvancedFormBuilderId = Request.Id,
                                AdvancedFormBuilderListValueId = x.AttributeListValueId
                            }).ToList();

                        await _AdvancedFormBuilderViewWhenRelationRepository.AddRangeAsync(NewAdvancedFormBuilderViewWhenRelationEntities);
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
