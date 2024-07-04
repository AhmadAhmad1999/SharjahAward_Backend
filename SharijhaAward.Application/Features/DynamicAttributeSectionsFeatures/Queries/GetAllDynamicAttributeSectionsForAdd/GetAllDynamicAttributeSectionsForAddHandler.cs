using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class GetAllDynamicAttributeSectionsForAddHandler : IRequestHandler<GetAllDynamicAttributeSectionsForAddQuery,
        BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IAsyncRepository<ViewWhenRelation> _ViewWhenRelationRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        public GetAllDynamicAttributeSectionsForAddHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IAsyncRepository<ViewWhenRelation> ViewWhenRelationRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            _ViewWhenRelationRepository = ViewWhenRelationRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
        }
        public async Task<BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>> 
            Handle(GetAllDynamicAttributeSectionsForAddQuery Request, CancellationToken cancellationToken)
        {
            if (Request.ProvidedFormId is not null)
            {
                string ResponseMessage = string.Empty;

                string Language = !string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() : "ar";

                Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.ProvidedFormId);

                if (ProvidedFormEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Provided form is not Found"
                        : "الاستمارة المقدمة غير موجودة";

                    return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>(ResponseMessage, false, 404);
                }

                List<GetAllDynamicAttributeSectionsForAddListVM> DynamicAttributeSections = await _DynamicAttributeSectionRepository
                    .IncludeThenWhere(x => x.AttributeTableName!, x => x.RecordIdOnRelation == ProvidedFormEntity.categoryId &&
                        x.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower())
                    .OrderBy(x => x.OrderId)
                    .Select(x => new GetAllDynamicAttributeSectionsForAddListVM()
                    {
                        Id = x.Id,
                        Name = Language == "ar"
                            ? x.ArabicName
                            : x.EnglishName,
                        TableTypeSection = x.TableTypeSection
                    }).ToListAsync();

                IReadOnlyList<AttributeDataType> DataTypes = await _AttributeDataTypeRepository.ListAllAsync();

                List<DynamicAttribute> AllDynamicAttributeEntitiesInSections = await _DynamicAttributeRepository
                    .Where(x => DynamicAttributeSections.Select(y => y.Id).Contains(x.DynamicAttributeSectionId))
                    .ToListAsync();

                List<ViewWhenRelation> AllViewWhenRelationEntities = await _ViewWhenRelationRepository
                    .Where(x => AllDynamicAttributeEntitiesInSections.Select(y => y.Id).Any(y => y == x.DynamicAttributeId) ||
                        AllDynamicAttributeEntitiesInSections.Select(y => y.DynamicAttributeSectionId).Any(y => y == x.DynamicAttributeSectionId))
                    .ToListAsync();

                List<DynamicAttributeValue> AlreadyInsertedDynamicAttributeValues = await _DynamicAttributeValueRepository
                    .Where(x => x.RecordId != null
                        ? x.RecordId == Request.ProvidedFormId
                        : false).ToListAsync();
                
                List<DynamicAttributeTableValue> AlreadyInsertedDynamicAttributeTableValues = await _DynamicAttributeTableValueRepository
                    .Where(x => x.RecordId == Request.ProvidedFormId).ToListAsync();

                List<DynamicAttributeListValue> AllInsertedDynamicAttributeListValueEntities = await _DynamicAttributeListValueRepository
                    .Where(x => AllDynamicAttributeEntitiesInSections.Select(y => y.Id).Contains(x.DynamicAttributeId))
                    .ToListAsync();

                foreach (GetAllDynamicAttributeSectionsForAddListVM DynamicAttributeSection in DynamicAttributeSections)
                {
                    DynamicAttributeSection.ViewWhenForAddDtos = AllViewWhenRelationEntities
                        .Where(y => y.DynamicAttributeSectionId == DynamicAttributeSection.Id)
                        .Select(y => new ViewWhenForAddDto()
                        {
                            Id = y.Id,
                            DynamicAttributeListValueId = y.DynamicAttributeListValueId
                        }).ToList();

                    if (!DynamicAttributeSection.TableTypeSection)
                    {
                        DynamicAttributeSection.DynamicAttributes = AllDynamicAttributeEntitiesInSections
                            .Where(x => x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                                DynamicAttributeSections.Select(y => y.Id).Contains(x.DynamicAttributeSectionId) &&
                                x.DynamicAttributeSectionId == DynamicAttributeSection.Id)
                            .OrderBy(x => x.OrderId)
                            .Select(x => new DynamicAttributeListWithListValuesVM()
                            {
                                Id = x.Id,
                                AttributeDataTypeId = x.AttributeDataTypeId,
                                Label = Language.ToLower() == "ar"
                                    ? x.ArabicLabel
                                    : x.EnglishLabel,
                                PlaceHolder = Language.ToLower() == "ar"
                                    ? x.ArabicPlaceHolder
                                    : x.EnglishPlaceHolder,
                                isRequired = x.IsRequired,
                                MaxSizeInKB = x.MaxSizeInKB,
                                ArabicTitle = x.ArabicTitle,
                                EnglishTitle = x.EnglishTitle,
                                RowId = -1,
                                ViewWhenForAddDtos = AllViewWhenRelationEntities
                                    .Where(y => y.DynamicAttributeId == x.Id)
                                    .Select(y => new ViewWhenForAddDto()
                                    {
                                        Id = y.Id,
                                        DynamicAttributeListValueId = y.DynamicAttributeListValueId
                                    }).ToList()
                            }).ToList();

                        foreach (DynamicAttributeListWithListValuesVM DynamicAttributeInSection in DynamicAttributeSection.DynamicAttributes)
                        {
                            DynamicAttributeInSection.DynamicAttributeListValues = AllInsertedDynamicAttributeListValueEntities
                                .Where(x => x.DynamicAttributeId == DynamicAttributeInSection.Id)
                                .Select(x => new DynamicAttributeListValueListVM()
                                {
                                    Id = x.Id,
                                    EnglishValue = x.EnglishValue,
                                    ArabicValue = x.ArabicValue,
                                    Value = Request.lang == "en"
                                        ? x.EnglishValue
                                        : x.ArabicValue
                                }).ToList();

                            DynamicAttributeInSection.AttributeDataTypeName = DataTypes
                                .FirstOrDefault(y => y.Id == DynamicAttributeInSection.AttributeDataTypeId)!.Name;

                            if (AlreadyInsertedDynamicAttributeValues.Count() > 0)
                            {
                                if (DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "File".ToLower() ||
                                    DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "Image".ToLower())
                                {
                                    DynamicAttributeValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeValues
                                        .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                                    if (CheckIfValueIsAlreadyInserted != null)
                                    {
                                        DynamicAttributeInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
                                        DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                        DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                    }
                                }
                                else
                                {
                                    DynamicAttributeValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeValues
                                        .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                                    if (CheckIfValueIsAlreadyInserted != null)
                                    {
                                        DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value;
                                        DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                        DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        List<IGrouping<int, DynamicAttributeTableValue>> DynamicAttributeTableValueEntities = await _DynamicAttributeTableValueRepository
                            .Where(x => AllDynamicAttributeEntitiesInSections.Select(y => y.Id).Contains(x.DynamicAttributeId) &&
                                x.RecordId == Request.ProvidedFormId)
                            .Include(x => x.DynamicAttribute!)
                            .GroupBy(x => x.RowId)
                            .ToListAsync();

                        if (!DynamicAttributeTableValueEntities.Any())
                        {
                            DynamicAttributeSection.DynamicAttributes = AllDynamicAttributeEntitiesInSections
                                .Where(x => x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                                    DynamicAttributeSections.Select(y => y.Id).Contains(x.DynamicAttributeSectionId) &&
                                    x.DynamicAttributeSectionId == DynamicAttributeSection.Id)
                                .OrderBy(x => x.OrderId)
                                .Select(x => new DynamicAttributeListWithListValuesVM()
                                {
                                    Id = x.Id,
                                    AttributeDataTypeId = x.AttributeDataTypeId,
                                    Label = Language.ToLower() == "ar"
                                        ? x.ArabicLabel
                                        : x.EnglishLabel,
                                    PlaceHolder = Language.ToLower() == "ar"
                                        ? x.ArabicPlaceHolder
                                        : x.EnglishPlaceHolder,
                                    isRequired = x.IsRequired,
                                    MaxSizeInKB = x.MaxSizeInKB,
                                    ArabicTitle = x.ArabicTitle,
                                    EnglishTitle = x.EnglishTitle,
                                    RowId = 0,
                                    ViewWhenForAddDtos = AllViewWhenRelationEntities
                                        .Where(y => y.DynamicAttributeId == x.Id)
                                        .Select(y => new ViewWhenForAddDto()
                                        {
                                            Id = y.Id,
                                            DynamicAttributeListValueId = y.DynamicAttributeListValueId
                                        }).ToList()
                                }).ToList();

                            foreach (DynamicAttributeListWithListValuesVM DynamicAttributeInSection in DynamicAttributeSection.DynamicAttributes)
                            {
                                DynamicAttributeInSection.DynamicAttributeListValues = AllInsertedDynamicAttributeListValueEntities
                                    .DistinctBy(x => x.Id)
                                    .Where(x => x.DynamicAttributeId == DynamicAttributeInSection.Id)
                                    .Select(x => new DynamicAttributeListValueListVM()
                                    {
                                        Id = x.Id,
                                        EnglishValue = x.EnglishValue,
                                        ArabicValue = x.ArabicValue,
                                        Value = Request.lang == "en"
                                            ? x.EnglishValue
                                            : x.ArabicValue
                                    }).ToList();

                                DynamicAttributeInSection.AttributeDataTypeName = DataTypes
                                    .FirstOrDefault(y => y.Id == DynamicAttributeInSection.AttributeDataTypeId)!.Name;
                            }

                            DynamicAttributeSection.BaseDynamicAttributes = DynamicAttributeSection.DynamicAttributes;
                        }

                        DynamicAttributeSection.BaseDynamicAttributes = AllDynamicAttributeEntitiesInSections
                            .Where(x => x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                                DynamicAttributeSections.Select(y => y.Id).Contains(x.DynamicAttributeSectionId) &&
                                x.DynamicAttributeSectionId == DynamicAttributeSection.Id)
                            .OrderBy(x => x.OrderId)
                            .Select(x => new DynamicAttributeListWithListValuesVM()
                            {
                                Id = x.Id,
                                AttributeDataTypeId = x.AttributeDataTypeId,
                                Label = Language.ToLower() == "ar"
                                    ? x.ArabicLabel
                                    : x.EnglishLabel,
                                PlaceHolder = Language.ToLower() == "ar"
                                    ? x.ArabicPlaceHolder
                                    : x.EnglishPlaceHolder,
                                isRequired = x.IsRequired,
                                MaxSizeInKB = x.MaxSizeInKB,
                                ArabicTitle = x.ArabicTitle,
                                EnglishTitle = x.EnglishTitle,
                                RowId = 0,
                                ViewWhenForAddDtos = AllViewWhenRelationEntities
                                    .Where(y => y.DynamicAttributeId == x.Id)
                                    .Select(y => new ViewWhenForAddDto()
                                    {
                                        Id = y.Id,
                                        DynamicAttributeListValueId = y.DynamicAttributeListValueId
                                    }).ToList()
                            }).ToList();

                        foreach (DynamicAttributeListWithListValuesVM DynamicAttributeInSection in DynamicAttributeSection.DynamicAttributes)
                        {
                            DynamicAttributeInSection.DynamicAttributeListValues = AllInsertedDynamicAttributeListValueEntities
                                .DistinctBy(x => x.Id)
                                .Where(x => x.DynamicAttributeId == DynamicAttributeInSection.Id)
                                .Select(x => new DynamicAttributeListValueListVM()
                                {
                                    Id = x.Id,
                                    EnglishValue = x.EnglishValue,
                                    ArabicValue = x.ArabicValue,
                                    Value = Request.lang == "en"
                                        ? x.EnglishValue
                                        : x.ArabicValue
                                }).ToList();

                            DynamicAttributeInSection.AttributeDataTypeName = DataTypes
                                .FirstOrDefault(y => y.Id == DynamicAttributeInSection.AttributeDataTypeId)!.Name;
                        }

                        foreach (IGrouping<int, DynamicAttributeTableValue> DynamicAttributeTableValueEntity in DynamicAttributeTableValueEntities)
                        {
                            foreach (DynamicAttributeTableValue OneDynamicAttributeTableValueEntity in DynamicAttributeTableValueEntity)
                            {
                                if (!DynamicAttributeSection.DynamicAttributes
                                    .Any(y => y.Id == OneDynamicAttributeTableValueEntity.DynamicAttributeId &&
                                        y.RowId == DynamicAttributeTableValueEntity.Key))
                                {
                                    DynamicAttributeListWithListValuesVM DynamicAttributeInSection = new DynamicAttributeListWithListValuesVM()
                                    {
                                        Id = OneDynamicAttributeTableValueEntity.DynamicAttributeId,
                                        AttributeDataTypeId = OneDynamicAttributeTableValueEntity.DynamicAttribute!.AttributeDataTypeId,
                                        Label = Language.ToLower() == "ar"
                                            ? OneDynamicAttributeTableValueEntity.DynamicAttribute!.ArabicLabel
                                            : OneDynamicAttributeTableValueEntity.DynamicAttribute!.EnglishLabel,
                                        PlaceHolder = Language.ToLower() == "ar"
                                            ? OneDynamicAttributeTableValueEntity.DynamicAttribute!.ArabicPlaceHolder
                                            : OneDynamicAttributeTableValueEntity.DynamicAttribute!.EnglishPlaceHolder,
                                        isRequired = OneDynamicAttributeTableValueEntity.DynamicAttribute!.IsRequired,
                                        MaxSizeInKB = OneDynamicAttributeTableValueEntity.DynamicAttribute!.MaxSizeInKB,
                                        RowId = DynamicAttributeTableValueEntity.Key,
                                        ViewWhenForAddDtos = AllViewWhenRelationEntities
                                            .Where(y => y.DynamicAttributeId == OneDynamicAttributeTableValueEntity.DynamicAttributeId)
                                            .Select(y => new ViewWhenForAddDto()
                                            {
                                                Id = y.Id,
                                                DynamicAttributeListValueId = y.DynamicAttributeListValueId
                                            }).ToList()
                                    };

                                    DynamicAttributeInSection.DynamicAttributeListValues = AllInsertedDynamicAttributeListValueEntities
                                        .Where(x => x.DynamicAttributeId == DynamicAttributeInSection.Id)
                                        .Select(x => new DynamicAttributeListValueListVM()
                                        {
                                            Id = x.Id,
                                            EnglishValue = x.EnglishValue,
                                            ArabicValue = x.ArabicValue,
                                            Value = Request.lang == "en"
                                                ? x.EnglishValue
                                                : x.ArabicValue
                                        }).ToList();

                                    DynamicAttributeInSection.AttributeDataTypeName = DataTypes
                                        .FirstOrDefault(y => y.Id == DynamicAttributeInSection.AttributeDataTypeId)!.Name;

                                    if (AlreadyInsertedDynamicAttributeTableValues.Count() > 0)
                                    {
                                        if (DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "File".ToLower() ||
                                            DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "Image".ToLower())
                                        {
                                            DynamicAttributeTableValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeTableValues
                                                .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id &&
                                                    y.RowId == DynamicAttributeTableValueEntity.Key);

                                            if (CheckIfValueIsAlreadyInserted != null)
                                            {
                                                DynamicAttributeInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
                                                DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                                DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                            }
                                        }
                                        else
                                        {
                                            DynamicAttributeTableValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeTableValues
                                                .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id &&
                                                    y.RowId == DynamicAttributeTableValueEntity.Key);

                                            if (CheckIfValueIsAlreadyInserted != null)
                                            {
                                                DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value;
                                                DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                                DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                            }
                                        }
                                    }

                                    DynamicAttributeSection.DynamicAttributes.Add(DynamicAttributeInSection);
                                }
                            }
                        }
                    }
                }

                GetAllDynamicAttributeSectionsForAddListVM? MainInformationDynamicSection = DynamicAttributeSections
                    .FirstOrDefault(x => x.Name.ToLower() == "Main Information".ToLower() ||
                        x.Name == "المعلومات الأساسية");

                if (MainInformationDynamicSection is not null)
                {
                    int IndexOfMainInformationSection = DynamicAttributeSections.IndexOf(MainInformationDynamicSection);

                    GetAllDynamicAttributeSectionsForAddListVM? FirstDynamicSection = DynamicAttributeSections.FirstOrDefault();

                    if (FirstDynamicSection is not null)
                    {
                        DynamicAttributeSections[0] = MainInformationDynamicSection;
                        DynamicAttributeSections[IndexOfMainInformationSection] = FirstDynamicSection;
                    }
                }

                return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>(ResponseMessage, true, 200, DynamicAttributeSections);
            }
            else if (Request.isArbitrator is not null)
            {
                string ResponseMessage = string.Empty;

                string Language = !string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() : "ar";

                List<GetAllDynamicAttributeSectionsForAddListVM> DynamicAttributeSections = await _DynamicAttributeSectionRepository
                    .IncludeThenWhere(x => x.AttributeTableName!,
                        x => Request.isArbitrator.Value
                            ? x.AttributeTableName!.Name.ToLower() == TableNames.Arbitrator.ToString().ToLower() &&
                                x.RecordIdOnRelation == -1
                            : x.AttributeTableName!.Name.ToLower() == TableNames.Coordinator.ToString().ToLower() &&
                                x.RecordIdOnRelation == -2)
                    .OrderBy(x => x.OrderId)
                    .Select(x => new GetAllDynamicAttributeSectionsForAddListVM()
                    {
                        Id = x.Id,
                        Name = Language == "ar"
                            ? x.ArabicName
                            : x.EnglishName,
                        TableTypeSection = x.TableTypeSection
                    }).ToListAsync();

                IReadOnlyList<AttributeDataType> DataTypes = await _AttributeDataTypeRepository.ListAllAsync();

                List<DynamicAttribute> AllDynamicAttributeEntitiesInSections = await _DynamicAttributeRepository
                    .Where(x => DynamicAttributeSections.Select(y => y.Id).Contains(x.DynamicAttributeSectionId))
                    .ToListAsync();

                List<ViewWhenRelation> AllViewWhenRelationEntities = await _ViewWhenRelationRepository
                    .Where(x => AllDynamicAttributeEntitiesInSections.Select(y => y.Id).Any(y => y == x.DynamicAttributeId) ||
                        AllDynamicAttributeEntitiesInSections.Select(y => y.DynamicAttributeSectionId).Any(y => y == x.DynamicAttributeSectionId))
                    .ToListAsync();

                List<DynamicAttributeListValue> AllInsertedDynamicAttributeListValueEntities = await _DynamicAttributeListValueRepository
                    .Where(x => AllDynamicAttributeEntitiesInSections.Select(y => y.Id).Contains(x.DynamicAttributeId))
                    .ToListAsync();

                List<DynamicAttributeValue> AlreadyInsertedDynamicAttributeValues = new List<DynamicAttributeValue>();

                if (Request.ArbitratorId is not null)
                {
                    AlreadyInsertedDynamicAttributeValues = await _DynamicAttributeValueRepository
                        .Where(x => x.RecordId != null
                            ? x.RecordId == Request.ArbitratorId
                            : false).ToListAsync();
                }
                else if (Request.CoordinatorId is not null)
                {
                    AlreadyInsertedDynamicAttributeValues = await _DynamicAttributeValueRepository
                        .Where(x => x.RecordId != null
                            ? x.RecordId == Request.CoordinatorId
                            : false).ToListAsync();
                }

                foreach (GetAllDynamicAttributeSectionsForAddListVM DynamicAttributeSection in DynamicAttributeSections)
                {
                    DynamicAttributeSection.ViewWhenForAddDtos = AllViewWhenRelationEntities
                        .Where(y => y.DynamicAttributeSectionId == DynamicAttributeSection.Id)
                        .Select(y => new ViewWhenForAddDto()
                        {
                            Id = y.Id,
                            DynamicAttributeListValueId = y.DynamicAttributeListValueId
                        }).ToList();

                    DynamicAttributeSection.DynamicAttributes = AllDynamicAttributeEntitiesInSections
                        .Where(x => x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                            DynamicAttributeSections.Select(y => y.Id).Contains(x.DynamicAttributeSectionId) &&
                            x.DynamicAttributeSectionId == DynamicAttributeSection.Id)
                        .OrderBy(x => x.OrderId)
                        .Select(x => new DynamicAttributeListWithListValuesVM()
                        {
                            Id = x.Id,
                            AttributeDataTypeId = x.AttributeDataTypeId,
                            Label = Language.ToLower() == "ar"
                                ? x.ArabicLabel
                                : x.EnglishLabel,
                            PlaceHolder = Language.ToLower() == "ar"
                                ? x.ArabicPlaceHolder
                                : x.EnglishPlaceHolder,
                            isRequired = x.IsRequired,
                            MaxSizeInKB = x.MaxSizeInKB,
                            RowId = -1,
                            ViewWhenForAddDtos = AllViewWhenRelationEntities
                                .Where(y => y.DynamicAttributeId == x.Id)
                                .Select(y => new ViewWhenForAddDto()
                                {
                                    Id = y.Id,
                                    DynamicAttributeListValueId = y.DynamicAttributeListValueId
                                }).ToList()
                        }).ToList();

                    foreach (DynamicAttributeListWithListValuesVM DynamicAttributeInSection in DynamicAttributeSection.DynamicAttributes)
                    {
                        DynamicAttributeInSection.DynamicAttributeListValues = AllInsertedDynamicAttributeListValueEntities
                            .Where(x => x.DynamicAttributeId == DynamicAttributeInSection.Id)
                            .Select(x => new DynamicAttributeListValueListVM() 
                            { 
                                Id = x.Id,
                                EnglishValue = x.EnglishValue,
                                ArabicValue = x.ArabicValue,
                                Value = Request.lang == "en"
                                    ? x.EnglishValue
                                    : x.ArabicValue
                            }).ToList();

                        DynamicAttributeInSection.AttributeDataTypeName = DataTypes
                            .FirstOrDefault(y => y.Id == DynamicAttributeInSection.AttributeDataTypeId)!.Name;

                        if (AlreadyInsertedDynamicAttributeValues.Count() > 0)
                        {
                            if (DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "File".ToLower() ||
                                DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "Image".ToLower())
                            {
                                DynamicAttributeValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeValues
                                    .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                                if (CheckIfValueIsAlreadyInserted != null)
                                {
                                    DynamicAttributeInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
                                    DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                    DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                }
                            }
                            else
                            {
                                DynamicAttributeValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeValues
                                    .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                                if (CheckIfValueIsAlreadyInserted != null)
                                {
                                    DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value;
                                    DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                    DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                }
                            }
                        }
                    }
                }

                return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>(ResponseMessage, true, 200, DynamicAttributeSections);
            }

            return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>();
        }
    }
}
