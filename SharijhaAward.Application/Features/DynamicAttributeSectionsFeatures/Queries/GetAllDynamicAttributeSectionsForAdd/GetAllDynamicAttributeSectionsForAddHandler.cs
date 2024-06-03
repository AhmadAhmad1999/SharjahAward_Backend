using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Text.RegularExpressions;
namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class GetAllDynamicAttributeSectionsForAddHandler : IRequestHandler<GetAllDynamicAttributeSectionsForAddQuery,
        BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        public GetAllDynamicAttributeSectionsForAddHandler(IMapper Mapper,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository)
        {
            _Mapper = Mapper;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
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

                List<DynamicAttributeValue> AlreadyInsertedDynamicAttributeValues = await _DynamicAttributeValueRepository
                    .Where(x => x.RecordId != null
                        ? x.RecordId == Request.ProvidedFormId
                        : false).ToListAsync();

                List<DynamicAttributeTableValue> AlreadyInsertedDynamicAttributeTableValues = await _DynamicAttributeTableValueRepository
                    .Where(x => x.RecordId == Request.ProvidedFormId).ToListAsync();

                foreach (GetAllDynamicAttributeSectionsForAddListVM DynamicAttributeSection in DynamicAttributeSections)
                {
                    if (!DynamicAttributeSection.TableTypeSection)
                    {
                        DynamicAttributeSection.DynamicAttributes = await _DynamicAttributeRepository
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
                                EnglishTitle = x.EnglishTitle
                            }).ToListAsync();

                        foreach (DynamicAttributeListWithListValuesVM DynamicAttributeInSection in DynamicAttributeSection.DynamicAttributes)
                        {
                            DynamicAttributeInSection.DynamicAttributeListValues = _Mapper.Map<List<DynamicAttributeListValueListVM>>(
                                await _DynamicAttributeListValueRepository
                                    .Where(x => x.DynamicAttributeId == DynamicAttributeInSection.Id).ToListAsync());

                            List<DynamicAttributeListValueListVM> CheckIfThereisNoValue = new List<DynamicAttributeListValueListVM>();

                            if (Language.ToLower() == "en")
                                CheckIfThereisNoValue = DynamicAttributeInSection.DynamicAttributeListValues
                                    .Where(x => !Regex.IsMatch(x.Value, @"\p{IsArabic}")).ToList();

                            else
                                CheckIfThereisNoValue = DynamicAttributeInSection.DynamicAttributeListValues
                                    .Where(x => Regex.IsMatch(x.Value, @"\p{IsArabic}")).ToList();

                            if (CheckIfThereisNoValue.Count() > 0)
                                DynamicAttributeInSection.DynamicAttributeListValues = CheckIfThereisNoValue;

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
                            .Where(x => DynamicAttributeSection.DynamicAttributes.Select(y => y.Id).Contains(x.DynamicAttributeId))
                            .Include(x => x.DynamicAttribute!)
                            .GroupBy(x => x.RowId)
                            .ToListAsync();

                        List<DynamicAttributeListWithListValuesVM> DynamicAttributesEntities = await _DynamicAttributeRepository
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
                                MaxSizeInKB = x.MaxSizeInKB
                            }).ToListAsync();

                        foreach (IGrouping<int, DynamicAttributeTableValue> DynamicAttributeTableValueEntity in DynamicAttributeTableValueEntities)
                        {
                            foreach (DynamicAttributeTableValue OneDynamicAttributeTableValueEntity in DynamicAttributeTableValueEntity)
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
                                    RowId = DynamicAttributeTableValueEntity.Key
                                };

                                DynamicAttributeInSection.DynamicAttributeListValues = _Mapper.Map<List<DynamicAttributeListValueListVM>>(
                                    await _DynamicAttributeListValueRepository
                                        .Where(x => x.DynamicAttributeId == DynamicAttributeInSection.Id).ToListAsync());

                                List<DynamicAttributeListValueListVM> CheckIfThereisNoValue = new List<DynamicAttributeListValueListVM>();

                                if (Language.ToLower() == "en")
                                    CheckIfThereisNoValue = DynamicAttributeInSection.DynamicAttributeListValues
                                        .Where(x => !Regex.IsMatch(x.Value, @"\p{IsArabic}")).ToList();

                                else
                                    CheckIfThereisNoValue = DynamicAttributeInSection.DynamicAttributeListValues
                                        .Where(x => Regex.IsMatch(x.Value, @"\p{IsArabic}")).ToList();

                                if (CheckIfThereisNoValue.Count() > 0)
                                    DynamicAttributeInSection.DynamicAttributeListValues = CheckIfThereisNoValue;

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
                    DynamicAttributeSection.DynamicAttributes = await _DynamicAttributeRepository
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
                            MaxSizeInKB = x.MaxSizeInKB
                        }).ToListAsync();

                    foreach (DynamicAttributeListWithListValuesVM DynamicAttributeInSection in DynamicAttributeSection.DynamicAttributes)
                    {
                        DynamicAttributeInSection.DynamicAttributeListValues = _Mapper.Map<List<DynamicAttributeListValueListVM>>(
                            await _DynamicAttributeListValueRepository
                                .Where(x => x.DynamicAttributeId == DynamicAttributeInSection.Id).ToListAsync());

                        List<DynamicAttributeListValueListVM> CheckIfThereisNoValue = new List<DynamicAttributeListValueListVM>();

                        if (Language.ToLower() == "en")
                            CheckIfThereisNoValue = DynamicAttributeInSection.DynamicAttributeListValues
                                .Where(x => !Regex.IsMatch(x.Value, @"\p{IsArabic}")).ToList();

                        else
                            CheckIfThereisNoValue = DynamicAttributeInSection.DynamicAttributeListValues
                                .Where(x => Regex.IsMatch(x.Value, @"\p{IsArabic}")).ToList();

                        if (CheckIfThereisNoValue.Count() > 0)
                            DynamicAttributeInSection.DynamicAttributeListValues = CheckIfThereisNoValue;

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
