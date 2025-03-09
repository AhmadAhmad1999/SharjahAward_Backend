using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EventModel;
using SharijhaAward.Domain.Entities.IdentityModels;

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
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;
        private readonly IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository;
        private readonly IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository;
        private readonly IAsyncRepository<Role> _RoleRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllDynamicAttributeSectionsForAddHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IAsyncRepository<ViewWhenRelation> ViewWhenRelationRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository,
            IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository,
            IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository,
            IAsyncRepository<Role> _RoleRepository,
            IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            _ViewWhenRelationRepository = ViewWhenRelationRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
            this._EventRepository = _EventRepository;
            this._PersonalInviteeVirtualTableRepository = _PersonalInviteeVirtualTableRepository;
            this._GroupInviteeVirtualTableRepository = _GroupInviteeVirtualTableRepository;
            this._RoleRepository = _RoleRepository;
            this._EducationalInstitutionRepository = _EducationalInstitutionRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
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

                int? AlreadyInsertedValueForEducationType = null;
                int? AlreadyInsertedValueForEmirate = null;

                if (ProvidedFormEntity.Category!.RelatedToEducationalEntities)
                {
                    GetAllDynamicAttributeSectionsForAddListVM? MainInformationSectionId = DynamicAttributeSections
                        .FirstOrDefault(x => x.Name.ToLower() == "Main Information".ToLower() ||
                            x.Name == "المعلومات الأساسية");

                    if (MainInformationSectionId is not null)
                    {
                        DynamicAttribute? EducationalInstitutionDynamicAttribute = AllDynamicAttributeEntitiesInSections
                            .FirstOrDefault(x => x.EnglishTitle.ToLower() == "Educational Institution".ToLower() &&
                                x.ArabicTitle == "المؤسسة التعليمية" &&
                                x.DynamicAttributeSectionId == MainInformationSectionId.Id);
                        
                        if (EducationalInstitutionDynamicAttribute is not null)
                        {
                            DynamicAttributeValue? EducationalInstitutionDynamicAttributeValue = await _DynamicAttributeValueRepository
                                .FirstOrDefaultAsync(x => x.RecordId == Request.ProvidedFormId &&
                                    x.DynamicAttributeId == EducationalInstitutionDynamicAttribute.Id);

                            if (EducationalInstitutionDynamicAttributeValue is not null)
                            {
                                DynamicAttributeListValue? EducationalInstitutionDynamicAttributeListValue = await _DynamicAttributeListValueRepository
                                    .FirstOrDefaultAsync(x => x.Id.ToString() == EducationalInstitutionDynamicAttributeValue.Value);
                                
                                if (EducationalInstitutionDynamicAttributeListValue is not null)
                                {
                                    EducationalInstitution? EducationalInstitutionEntity = await _EducationalInstitutionRepository
                                        .FirstOrDefaultAsync(x => x.EnglishName.ToLower() == EducationalInstitutionDynamicAttributeListValue.EnglishValue.ToLower() &&
                                            x.ArabicName == EducationalInstitutionDynamicAttributeListValue.ArabicValue);

                                    if (EducationalInstitutionEntity is not null)
                                    {
                                        AlreadyInsertedValueForEducationType = (int)EducationalInstitutionEntity
                                            .EducationType;

                                        AlreadyInsertedValueForEmirate = (int)EducationalInstitutionEntity
                                            .Emirates;
                                    }
                                }
                            }
                        }

                        AttributeDataType? AttributeDataTypeEntity = await _AttributeDataTypeRepository
                            .FirstOrDefaultAsync(x => x.Id == 8);

                        List<DynamicAttribute> ExtraDynamicAttributes = new List<DynamicAttribute>()
                        {
                            new DynamicAttribute()
                            {
                                Id = -10,
                                ArabicLabel = "نوع التعليم",
                                EnglishLabel = "Education Type",
                                ArabicPlaceHolder = "نوع التعليم",
                                EnglishPlaceHolder = "Education Type",
                                IsRequired = true,
                                ArabicTitle = "نوع التعليم",
                                EnglishTitle = "Education Type",
                                AttributeDataTypeId = 8,
                                Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                                DynamicAttributeSectionId = MainInformationSectionId.Id,
                                AttributeDataType = AttributeDataTypeEntity
                            }, new DynamicAttribute()
                            {
                                Id = -11,
                                ArabicLabel = "الإمارة",
                                EnglishLabel = "Emirate",
                                ArabicPlaceHolder = "الإمارة",
                                EnglishPlaceHolder = "Emirate",
                                IsRequired = true,
                                ArabicTitle = "الإمارة",
                                EnglishTitle = "Emirate",
                                AttributeDataTypeId = 8,
                                Status = Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active,
                                DynamicAttributeSectionId = MainInformationSectionId.Id,
                                AttributeDataType = AttributeDataTypeEntity
                            }
                        };

                        AllDynamicAttributeEntitiesInSections.AddRange(ExtraDynamicAttributes);
                    }
                }

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
                                    }).ToList(),
                                AttributeDataTypeName = x.AttributeDataType!.Name
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
                                        if (CheckIfValueIsAlreadyInserted.Value.Contains("wwwroot"))
                                        {
                                            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                                            string WWWRootFilePath = isHttps
                                                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                                                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                                            DynamicAttributeInSection.InsertedValueAsBinaryFilePath = (WWWRootFilePath + CheckIfValueIsAlreadyInserted.Value.Split("wwwroot")[1]).Replace("\\", "/");
                                        }
                                        else
                                        {
                                            DynamicAttributeInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
                                        }
                                        DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                        DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.isAccepted == true || CheckIfValueIsAlreadyInserted.isAccepted == null
                                            ? null
                                            : CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                    }
                                }
                                else if (DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "Phone Number".ToLower())
                                {
                                    DynamicAttributeValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeValues
                                        .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                                    if (CheckIfValueIsAlreadyInserted != null)
                                    {
                                        DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value.Replace("0097105", string.Empty);
                                        DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                        DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.isAccepted == true || CheckIfValueIsAlreadyInserted.isAccepted == null
                                            ? null
                                            : CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                    }
                                }
                                else
                                {
                                    DynamicAttributeValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeValues
                                        .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                                    if (CheckIfValueIsAlreadyInserted != null)
                                    {
                                        if (DynamicAttributeInSection.EnglishTitle.ToLower() == "Educational Institution".ToLower() &&
                                            DynamicAttributeInSection.ArabicTitle == "المؤسسة التعليمية")
                                        {
                                            DynamicAttributeSection.DynamicAttributes
                                                .FirstOrDefault(x => x.EnglishTitle.ToLower() == "Education Type".ToLower())!.InsertedValueAsString = AlreadyInsertedValueForEducationType.ToString();
                                            
                                            DynamicAttributeSection.DynamicAttributes
                                                .FirstOrDefault(x => x.EnglishTitle.ToLower() == "Emirate".ToLower())!.InsertedValueAsString = AlreadyInsertedValueForEmirate.ToString();
                                        }

                                        DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value;
                                        DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                        DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.isAccepted == true || CheckIfValueIsAlreadyInserted.isAccepted == null
                                            ? null
                                            : CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        List<IGrouping<int, DynamicAttributeTableValue>> DynamicAttributeTableValueEntities = await _DynamicAttributeTableValueRepository
                            .Where(x => AllDynamicAttributeEntitiesInSections.Select(y => y.Id).Contains(x.DynamicAttributeId) &&
                                x.RecordId == Request.ProvidedFormId && x.DynamicAttribute!.DynamicAttributeSectionId == DynamicAttributeSection.Id)
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
                                        }).ToList(),
                                    AttributeDataTypeName = x.AttributeDataType!.Name
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
                                    }).ToList(),
                                AttributeDataTypeName = x.AttributeDataType!.Name
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
                                            }).ToList(),
                                        AttributeDataTypeName = OneDynamicAttributeTableValueEntity.DynamicAttribute!.AttributeDataType!.Name
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
                                                if (CheckIfValueIsAlreadyInserted.Value.Contains("wwwroot"))
                                                {
                                                    bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                                                    string WWWRootFilePath = isHttps
                                                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                                                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                                                    DynamicAttributeInSection.InsertedValueAsBinaryFilePath = (WWWRootFilePath + CheckIfValueIsAlreadyInserted.Value.Split("wwwroot")[1]).Replace("\\", "/");
                                                }
                                                else
                                                {
                                                    DynamicAttributeInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
                                                }

                                                DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                                DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                            }
                                        }
                                        else if (DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "Phone Number".ToLower())
                                        {
                                            DynamicAttributeTableValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeTableValues
                                                .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                                            if (CheckIfValueIsAlreadyInserted != null)
                                            {
                                                DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value.Replace("0097105", string.Empty);
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
                                                if (DynamicAttributeInSection.EnglishTitle.ToLower() == "Educational Institution".ToLower() &&
                                                    DynamicAttributeInSection.ArabicTitle == "المؤسسة التعليمية")
                                                {
                                                    DynamicAttributeSection.DynamicAttributes
                                                        .FirstOrDefault(x => x.EnglishTitle.ToLower() == "Education Type".ToLower())!.InsertedValueAsString = AlreadyInsertedValueForEducationType.ToString();

                                                    DynamicAttributeSection.DynamicAttributes
                                                        .FirstOrDefault(x => x.EnglishTitle.ToLower() == "Emirate".ToLower())!.InsertedValueAsString = AlreadyInsertedValueForEmirate.ToString();
                                                }

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

                    DynamicAttributeSection.rejected = DynamicAttributeSection
                        .DynamicAttributes.Any(x => x.isAccepted != null ? !x.isAccepted.Value : false);
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

                    MainInformationDynamicSection.DynamicAttributes = MainInformationDynamicSection.DynamicAttributes
                        .OrderBy(x =>
                        {
                            if ((x.EnglishTitle.ToLower() == "Education Type".ToLower() && x.ArabicTitle == "نوع التعليم") ||
                                (x.EnglishTitle.ToLower() == "Emirate".ToLower() && x.ArabicTitle == "الإمارة")) return 0;  // Highest priority
                            if (x.EnglishTitle.ToLower() == "Educational Institution".ToLower() && x.ArabicTitle == "المؤسسة التعليمية") return 2;  // Lower priority than "a" and "b"
                            return 1;  // Default priority
                        }).ToList();
                }

                return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>(ResponseMessage, true, 200, DynamicAttributeSections);
            }
            else if (Request.EventId is not null)
            {
                string ResponseMessage = string.Empty;

                string Language = !string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() : "ar";

                Domain.Entities.EventModel.Event? EventEntity = await _EventRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.EventId);

                if (EventEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Event is not Found"
                        : "الفعالية غير موجودة";

                    return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>(ResponseMessage, false, 404);
                }

                int RecordId = 0;

                if (Request.PersonalInviteeNumber is not null)
                {
                    PersonalInviteeVirtualTable? PersonalInviteeVirtualTableEntity = await _PersonalInviteeVirtualTableRepository
                        .FirstOrDefaultAsync(x => x.UniqueIntegerId == Request.PersonalInviteeNumber);

                    if (PersonalInviteeVirtualTableEntity is not null)
                        RecordId = PersonalInviteeVirtualTableEntity.Id;
                }
                else if (Request.GroupInviteeNumber is not null)
                {
                    GroupInviteeVirtualTable? GroupInviteeVirtualTableEntity = await _GroupInviteeVirtualTableRepository
                        .FirstOrDefaultAsync(x => x.UniqueIntegerId == Request.GroupInviteeNumber);

                    if (GroupInviteeVirtualTableEntity is not null)
                        RecordId = GroupInviteeVirtualTableEntity.Id;
                }
                else if (Request.PersonalInviteeId is not null)
                    RecordId = Request.PersonalInviteeId.Value;
                else if (Request.GroupInviteeId is not null)
                    RecordId = Request.GroupInviteeId.Value;

                List<GetAllDynamicAttributeSectionsForAddListVM> DynamicAttributeSections = await _DynamicAttributeSectionRepository
                    .IncludeThenWhere(x => x.AttributeTableName!, x => x.RecordIdOnRelation == EventEntity.Id &&
                        x.InviteeType == Request.InviteeType &&
                        x.AttributeTableNameId == 4)
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
                        ? x.RecordId == RecordId
                        : false)
                    .ToListAsync();

                List<DynamicAttributeTableValue> AlreadyInsertedDynamicAttributeTableValues = await _DynamicAttributeTableValueRepository
                    .Where(x => x.RecordId == RecordId)
                    .ToListAsync();

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
                                    }).ToList(),
                                AttributeDataTypeName = x.AttributeDataType!.Name
                            }).ToList();

                        if (Request.InviteeType == Domain.Constants.InviteeTypes.Group &&
                            (DynamicAttributeSection.Name == "Main Information".ToLower() ||
                                DynamicAttributeSection.Name == "المعلومات الأساسية"))
                        {
                            DynamicAttributeSection.DynamicAttributes.Add(new DynamicAttributeListWithListValuesVM()
                            {
                                Id = -1,
                                AttributeDataTypeId = 6,
                                Label = Language.ToLower() == "ar"
                                    ? "عدد الحضور المتوقع"
                                    : "Expected attendance",
                                PlaceHolder = Language.ToLower() == "ar"
                                    ? "عدد الحضور المتوقع"
                                    : "Expected attendance",
                                isRequired = true,
                                ArabicTitle = "عدد الحضور المتوقع",
                                EnglishTitle = "Expected attendance",
                                RowId = -1,
                                ViewWhenForAddDtos = new List<ViewWhenForAddDto>(),
                                AttributeDataTypeName = "Number"
                            });
                        }

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
                                        if (CheckIfValueIsAlreadyInserted.Value.Contains("wwwroot"))
                                        {
                                            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                                            string WWWRootFilePath = isHttps
                                                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                                                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                                            DynamicAttributeInSection.InsertedValueAsBinaryFilePath = (WWWRootFilePath + CheckIfValueIsAlreadyInserted.Value.Split("wwwroot")[1]).Replace("\\", "/");
                                        }
                                        else
                                        {
                                            DynamicAttributeInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
                                        }

                                        DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                        DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.isAccepted == true || CheckIfValueIsAlreadyInserted.isAccepted == null
                                            ? null
                                            : CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                    }
                                }
                                else if (DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "Phone Number".ToLower())
                                {
                                    DynamicAttributeValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeValues
                                        .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                                    if (CheckIfValueIsAlreadyInserted != null)
                                    {
                                        DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value.Replace("0097105", string.Empty);
                                        DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                        DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.isAccepted == true || CheckIfValueIsAlreadyInserted.isAccepted == null
                                            ? null
                                            : CheckIfValueIsAlreadyInserted.ReasonForRejecting;
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
                                        DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.isAccepted == true || CheckIfValueIsAlreadyInserted.isAccepted == null
                                            ? null
                                            : CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                    }
                                }
                            }

                            if (DynamicAttributeInSection.Label == "عدد الحضور المتوقع" ||
                                DynamicAttributeInSection.Label == "Expected attendance")
                            {
                                GroupInviteeVirtualTable? GroupInviteeVirtualTableEntity = await _GroupInviteeVirtualTableRepository
                                    .FirstOrDefaultAsync(x => Request.GroupInviteeId != null
                                        ? x.Id == Request.GroupInviteeId
                                        : x.UniqueIntegerId == Request.GroupInviteeNumber);

                                if (GroupInviteeVirtualTableEntity is not null)
                                    DynamicAttributeInSection.InsertedValueAsString = GroupInviteeVirtualTableEntity.NumberOfExpectedAttendance.ToString();
                            }
                        }
                    }
                    else
                    {
                        List<IGrouping<int, DynamicAttributeTableValue>> DynamicAttributeTableValueEntities = await _DynamicAttributeTableValueRepository
                            .Where(x => AllDynamicAttributeEntitiesInSections.Select(y => y.Id).Contains(x.DynamicAttributeId) &&
                                x.RecordId == RecordId && 
                                x.DynamicAttribute!.DynamicAttributeSectionId == DynamicAttributeSection.Id)
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
                                        }).ToList(),
                                    AttributeDataTypeName = x.AttributeDataType!.Name
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
                                    }).ToList(),
                                AttributeDataTypeName = x.AttributeDataType!.Name
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
                                            }).ToList(),
                                        AttributeDataTypeName = OneDynamicAttributeTableValueEntity.DynamicAttribute!.AttributeDataType!.Name
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
                                                if (CheckIfValueIsAlreadyInserted.Value.Contains("wwwroot"))
                                                {
                                                    bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                                                    string WWWRootFilePath = isHttps
                                                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                                                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                                                    DynamicAttributeInSection.InsertedValueAsBinaryFilePath = (WWWRootFilePath + CheckIfValueIsAlreadyInserted.Value.Split("wwwroot")[1]).Replace("\\", "/");
                                                }
                                                else
                                                {
                                                    DynamicAttributeInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
                                                }

                                                DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                                DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                            }
                                        }
                                        else if (DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "Phone Number".ToLower())
                                        {
                                            DynamicAttributeTableValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeTableValues
                                                .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                                            if (CheckIfValueIsAlreadyInserted != null)
                                            {
                                                DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value.Replace("0097105", string.Empty);
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

                    DynamicAttributeSection.rejected = DynamicAttributeSection
                        .DynamicAttributes.Any(x => x.isAccepted != null ? !x.isAccepted.Value : false);
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
                                }).ToList(),
                            AttributeDataTypeName = x.AttributeDataType!.Name
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
                                    if (CheckIfValueIsAlreadyInserted.Value.Contains("wwwroot"))
                                    {
                                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                                        string WWWRootFilePath = isHttps
                                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                                        DynamicAttributeInSection.InsertedValueAsBinaryFilePath = (WWWRootFilePath + CheckIfValueIsAlreadyInserted.Value.Split("wwwroot")[1]).Replace("\\", "/");
                                    }
                                    else
                                    {
                                        DynamicAttributeInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
                                    }

                                    DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
                                    DynamicAttributeInSection.ReasonForRejecting = CheckIfValueIsAlreadyInserted.ReasonForRejecting;
                                }
                            }
                            else if (DynamicAttributeInSection.AttributeDataTypeName.ToLower() == "Phone Number".ToLower())
                            {
                                DynamicAttributeValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeValues
                                    .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                                if (CheckIfValueIsAlreadyInserted != null)
                                {
                                    DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value.Replace("0097105", string.Empty);
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
