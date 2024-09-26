using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeaturesFeatures.Commands.CreateDynamicAttribute;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDynamicAttributeHandler : IRequestHandler<CreateDynamicAttributeCommand, 
        BaseResponse<CreateDynamicAttributeResponse>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<GeneralValidation> _GeneralValidationRepository;
        private readonly IAsyncRepository<DependencyGroup> _DependencyGroupRepository;
        private readonly IAsyncRepository<Dependency> _DependencyRepository;
        private readonly IAsyncRepository<DependencyValidation> _DependencyValidationRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<ViewWhenRelation> _ViewWhenRelationRepository;
        private readonly IMapper _Mapper;
        public CreateDynamicAttributeHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
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
        public async Task<BaseResponse<CreateDynamicAttributeResponse>> Handle(CreateDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AttributeDataType? CheckIfAttributeDataTypeIdDoesExist = await _AttributeDataTypeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.AttributeDataTypeId);

            if (CheckIfAttributeDataTypeIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "Attribute data type is not Found"
                  : "نوع الحقل غير موجود";

                return new BaseResponse<CreateDynamicAttributeResponse>(ResponseMessage, false, 404);
            }

            DynamicAttributeSection? CheckIfDynamicAttributeSectionIdDoesExist = await _DynamicAttributeSectionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.DynamicAttributeSectionId);

            if (CheckIfDynamicAttributeSectionIdDoesExist == null)
            {
                ResponseMessage = Request.lang == "en"
                  ? "Section is not Found"
                  : "العنوان الرئيسي غير موجود";

                return new BaseResponse<CreateDynamicAttributeResponse>(ResponseMessage, false, 404);
            }

            if (CheckIfDynamicAttributeSectionIdDoesExist.TableTypeSection)
            {
                Request.IsUnique = false;
                Request.IsRequired = false;
            }

            DynamicAttribute? CheckIfDynamicAttributeNameIsUsed = await _DynamicAttributeRepository
                .FirstOrDefaultAsync(x => x.DynamicAttributeSectionId == Request.DynamicAttributeSectionId &&
                    (x.ArabicLabel.ToLower() == Request.ArabicLabel.ToLower() ||
                        x.EnglishLabel.ToLower() == Request.EnglishLabel.ToLower()));

            if (CheckIfDynamicAttributeNameIsUsed is not null)
            {
                if (CheckIfDynamicAttributeNameIsUsed.ArabicLabel.ToLower() == Request.ArabicLabel.ToLower())
                    ResponseMessage = Request.lang == "en"
                        ? "This dynamic field's arabic name is already used"
                        : "اسم هذا الحقل باللغة العربية مستخدم مسبقاً";

                else if (CheckIfDynamicAttributeNameIsUsed.ArabicLabel.ToLower() == Request.ArabicLabel.ToLower())
                    ResponseMessage = Request.lang == "en"
                        ? "This dynamic field's english name is already used"
                        : "اسم هذا الحقل باللغة العربية مستخدم مسبقاً";

                return new BaseResponse<CreateDynamicAttributeResponse>(ResponseMessage, false, 400);
            }

            int LastOrderIdInSection = await _DynamicAttributeRepository
                .Where(x => x.DynamicAttributeSectionId == CheckIfDynamicAttributeSectionIdDoesExist.Id)
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
                    // Add Dynamic Attribute Main Data..
                    DynamicAttribute NewDynamicAttributeEntity = _Mapper.Map<DynamicAttribute>(Request);
                    NewDynamicAttributeEntity.Status = DynamicAttributeStatus.Active;
                    NewDynamicAttributeEntity.OrderId = LastOrderIdInSection++;
                    NewDynamicAttributeEntity.ArabicTitle = NewDynamicAttributeEntity.ArabicLabel;
                    NewDynamicAttributeEntity.EnglishTitle = NewDynamicAttributeEntity.EnglishLabel;

                    await _DynamicAttributeRepository.AddAsync(NewDynamicAttributeEntity);

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
                            return new BaseResponse<CreateDynamicAttributeResponse>(ResponseMessage, false, 400);
                        }

                        await _DynamicAttributeListValueRepository.AddRangeAsync(Request.Values.Select(DynamicAttributeListValue =>
                            new DynamicAttributeListValue()
                            {
                                ArabicValue = DynamicAttributeListValue.ArabicValue,
                                EnglishValue = DynamicAttributeListValue.EnglishValue,
                                DynamicAttributeId = NewDynamicAttributeEntity.Id,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = null,
                                DeletedAt = null,
                                isDeleted = false,
                                LastModifiedAt = null,
                                LastModifiedBy = null
                            }));
                    }

                    // Add General Validaiton if The Request.GeneralValidationObject is NOT NULL..
                    if (Request.GeneralValidationObject is not null)
                    {
                        GeneralValidation NewGeneralValidationEntity = _Mapper.Map<GeneralValidation>(Request.GeneralValidationObject);
                        NewGeneralValidationEntity.DynamicAttributeId = NewDynamicAttributeEntity.Id;

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
                                NewDependencyEntity.MainDynamicAttributeId = NewDynamicAttributeEntity.Id;
                                await _DependencyRepository.AddAsync(NewDependencyEntity);
                            }

                            DependencyValidation NewDependencyValidationEntity = _Mapper.Map<DependencyValidation>(DependencyValidationDTO);
                            NewDependencyValidationEntity.DependencyGroupId = NewDependencyGroup.Id;
                            await _DependencyValidationRepository.AddAsync(NewDependencyValidationEntity);
                        }
                    }

                    // Add ViewWhen Relation Data..
                    if (Request.ViewWhenDtos? .Any() ?? false)
                    {
                        List<ViewWhenRelation> NewViewWhenRelationEntities = Request.ViewWhenDtos
                            .Select(x => new ViewWhenRelation()
                            {
                                DynamicAttributeId = NewDynamicAttributeEntity.Id,
                                DynamicAttributeListValueId = x.AttributeListValueId
                            }).ToList();

                        await _ViewWhenRelationRepository.AddRangeAsync(NewViewWhenRelationEntities);
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء الحقل بنجاح";

                    return new BaseResponse<CreateDynamicAttributeResponse>()
                    {
                        data = new CreateDynamicAttributeResponse()
                        {
                            CreateDynamicAttributeDto = new CreateDynamicAttributeDto()
                            {
                                Id = NewDynamicAttributeEntity.Id,
                                ArabicLabel = NewDynamicAttributeEntity.ArabicLabel,
                                EnglishLabel = NewDynamicAttributeEntity.EnglishLabel
                            }
                        },
                        success = true,
                        message = ResponseMessage,
                        statusCode = 200
                    };
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
