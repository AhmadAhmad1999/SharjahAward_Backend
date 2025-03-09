using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAdvancedFormBuilderById;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForAdd
{
    public class GetAllAdvancedFormBuilderSectionsForAddHandler : IRequestHandler<GetAllAdvancedFormBuilderSectionsForAddQuery,
        BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderViewWhenRelation> _AdvancedFormBuilderViewWhenRelationRepository;
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderTableValue> _AdvancedFormBuilderTableValueRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllAdvancedFormBuilderSectionsForAddHandler(IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository,
            IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository,
            IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderViewWhenRelation> _AdvancedFormBuilderViewWhenRelationRepository,
            IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository,
            IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository,
            IAsyncRepository<AdvancedFormBuilderTableValue> _AdvancedFormBuilderTableValueRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._AdvancedFormBuilderSectionRepository = _AdvancedFormBuilderSectionRepository;
            this._AdvancedFormBuilderListValueRepository = _AdvancedFormBuilderListValueRepository;
            this._AttributeDataTypeRepository = _AttributeDataTypeRepository;
            this._AdvancedFormBuilderRepository = _AdvancedFormBuilderRepository;
            this._AdvancedFormBuilderViewWhenRelationRepository = _AdvancedFormBuilderViewWhenRelationRepository;
            this._VirtualTableForSectionRepository = _VirtualTableForSectionRepository;
            this._AdvancedFormBuilderValueRepository = _AdvancedFormBuilderValueRepository;
            this._AdvancedFormBuilderTableValueRepository = _AdvancedFormBuilderTableValueRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }
        public async Task<BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>>>
            Handle(GetAllAdvancedFormBuilderSectionsForAddQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            VirtualTableForSection? VirtualTableForSectionEntity = await _VirtualTableForSectionRepository
                .FirstOrDefaultAsync(x => x.PrivateHashKey.Replace("/", "s1qa") == Request.PrivateHashKey.Replace("/", "s1qa"));

            if (VirtualTableForSectionEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Provided form is not Found"
                    : "الاستمارة المقدمة غير موجودة";

                return new BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>>(ResponseMessage, false, 404);
            }

            List<GetAllAdvancedFormBuilderSectionsForAddListVM> AdvancedFormBuilderSections = await _AdvancedFormBuilderSectionRepository
                .IncludeThenWhere(x => x.VirtualTableForSection!, x => x.VirtualTableForSectionId == VirtualTableForSectionEntity.Id)
                .OrderBy(x => x.OrderId)
                .Select(x => new GetAllAdvancedFormBuilderSectionsForAddListVM()
                {
                    Id = x.Id,
                    Name = Language == "ar"
                        ? x.ArabicName
                        : x.EnglishName,
                    TableTypeSection = x.TableTypeSection
                }).ToListAsync();

            IReadOnlyList<AttributeDataType> DataTypes = await _AttributeDataTypeRepository.ListAllAsync();

            List<AdvancedFormBuilder> AllAdvancedFormBuilderEntitiesInSections = await _AdvancedFormBuilderRepository
                .Where(x => AdvancedFormBuilderSections.Select(y => y.Id).Contains(x.AdvancedFormBuilderSectionId))
                .ToListAsync();

            List<AdvancedFormBuilderViewWhenRelation> AllAdvancedFormBuilderViewWhenRelationEntities = await _AdvancedFormBuilderViewWhenRelationRepository
                .Where(x => AllAdvancedFormBuilderEntitiesInSections.Select(y => y.Id).Any(y => y == x.AdvancedFormBuilderId) ||
                    AllAdvancedFormBuilderEntitiesInSections.Select(y => y.AdvancedFormBuilderSectionId).Any(y => y == x.AdvancedFormBuilderSectionId))
                .ToListAsync();

            List<AdvancedFormBuilderValue> AlreadyInsertedAdvancedFormBuilderValues = await _AdvancedFormBuilderValueRepository
                .Where(x => Request.VirtualTableId != null
                    ? x.VirtualTableId == Request.VirtualTableId
                    : false)
                .ToListAsync(); ;

            List<AdvancedFormBuilderTableValue> AlreadyInsertedAdvancedFormBuilderTableValues = await _AdvancedFormBuilderTableValueRepository
                .Where(x => Request.VirtualTableId != null
                    ? x.VirtualTableId == Request.VirtualTableId
                    : false)
                .ToListAsync();

            List<AdvancedFormBuilderListValue> AllInsertedAdvancedFormBuilderListValueEntities = await _AdvancedFormBuilderListValueRepository
                .Where(x => AllAdvancedFormBuilderEntitiesInSections.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                .ToListAsync();

            foreach (GetAllAdvancedFormBuilderSectionsForAddListVM AdvancedFormBuilderSection in AdvancedFormBuilderSections)
            {
                AdvancedFormBuilderSection.ViewWhenForAddDtos = AllAdvancedFormBuilderViewWhenRelationEntities
                    .Where(y => y.AdvancedFormBuilderSectionId == AdvancedFormBuilderSection.Id)
                    .Select(y => new ViewWhenForAddDto()
                    {
                        Id = y.Id,
                        DynamicAttributeListValueId = y.AdvancedFormBuilderListValueId
                    }).ToList();

                if (!AdvancedFormBuilderSection.TableTypeSection)
                {
                    AdvancedFormBuilderSection.AdvancedFormBuilders = AllAdvancedFormBuilderEntitiesInSections
                        .Where(x => x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                            AdvancedFormBuilderSections.Select(y => y.Id).Contains(x.AdvancedFormBuilderSectionId) &&
                            x.AdvancedFormBuilderSectionId == AdvancedFormBuilderSection.Id)
                        .OrderBy(x => x.OrderId)
                        .Select(x => new AdvancedFormBuilderListWithListValuesVM()
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
                            ViewWhenForAddDtos = AllAdvancedFormBuilderViewWhenRelationEntities
                                .Where(y => y.AdvancedFormBuilderId == x.Id)
                                .Select(y => new ViewWhenForAddDto()
                                {
                                    Id = y.Id,
                                    DynamicAttributeListValueId = y.AdvancedFormBuilderListValueId
                                }).ToList(),
                            AttributeDataTypeName = x.AttributeDataType!.Name
                        }).ToList();

                    foreach (AdvancedFormBuilderListWithListValuesVM AdvancedFormBuilderInSection in AdvancedFormBuilderSection.AdvancedFormBuilders)
                    {
                        AdvancedFormBuilderInSection.AdvancedFormBuilderListValues = AllInsertedAdvancedFormBuilderListValueEntities
                            .Where(x => x.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id)
                            .Select(x => new AdvancedFormBuilderListValueListVM()
                            {
                                Id = x.Id,
                                EnglishValue = x.EnglishValue,
                                ArabicValue = x.ArabicValue,
                                Value = Request.lang == "en"
                                    ? x.EnglishValue
                                    : x.ArabicValue
                            }).ToList();

                        AdvancedFormBuilderInSection.AttributeDataTypeName = DataTypes
                            .FirstOrDefault(y => y.Id == AdvancedFormBuilderInSection.AttributeDataTypeId)!.Name;

                        if (AlreadyInsertedAdvancedFormBuilderValues.Count() > 0)
                        {
                            if (AdvancedFormBuilderInSection.AttributeDataTypeName.ToLower() == "File".ToLower() ||
                                AdvancedFormBuilderInSection.AttributeDataTypeName.ToLower() == "Image".ToLower())
                            {
                                AdvancedFormBuilderValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedAdvancedFormBuilderValues
                                    .FirstOrDefault(y => y.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id);

                                if (CheckIfValueIsAlreadyInserted != null)
                                {
                                    if (CheckIfValueIsAlreadyInserted.Value.Contains("wwwroot"))
                                    {
                                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                                        string WWWRootFilePath = isHttps
                                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                                        AdvancedFormBuilderInSection.InsertedValueAsBinaryFilePath = (WWWRootFilePath + CheckIfValueIsAlreadyInserted.Value.Split("wwwroot")[1]).Replace("\\", "/");
                                    }
                                    else
                                    {
                                        AdvancedFormBuilderInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
                                    }
                                }
                            }
                            else if (AdvancedFormBuilderInSection.AttributeDataTypeName.ToLower() == "Phone Number".ToLower())
                            {
                                AdvancedFormBuilderValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedAdvancedFormBuilderValues
                                    .FirstOrDefault(y => y.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id);

                                if (CheckIfValueIsAlreadyInserted != null)
                                {
                                    AdvancedFormBuilderInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value.Replace("0097105", string.Empty);
                                }
                            }
                            else
                            {
                                AdvancedFormBuilderValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedAdvancedFormBuilderValues
                                    .FirstOrDefault(y => y.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id);

                                if (CheckIfValueIsAlreadyInserted != null)
                                {
                                    AdvancedFormBuilderInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value;
                                }
                            }
                        }
                    }
                }
                else
                {
                    List<IGrouping<int, AdvancedFormBuilderTableValue>> AdvancedFormBuilderTableValueEntities = await _AdvancedFormBuilderTableValueRepository
                        .Where(x => Request.VirtualTableId != null 
                            ? (AllAdvancedFormBuilderEntitiesInSections.Select(y => y.Id).Contains(x.AdvancedFormBuilderId) &&
                                x.VirtualTableId == Request.VirtualTableId && x.AdvancedFormBuilder!.AdvancedFormBuilderSectionId == AdvancedFormBuilderSection.Id)
                            : false)
                        .GroupBy(x => x.RowId)
                        .ToListAsync();

                    if (!AdvancedFormBuilderTableValueEntities.Any())
                    {
                        AdvancedFormBuilderSection.AdvancedFormBuilders = AllAdvancedFormBuilderEntitiesInSections
                            .Where(x => x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                                AdvancedFormBuilderSections.Select(y => y.Id).Contains(x.AdvancedFormBuilderSectionId) &&
                                x.AdvancedFormBuilderSectionId == AdvancedFormBuilderSection.Id)
                            .OrderBy(x => x.OrderId)
                            .Select(x => new AdvancedFormBuilderListWithListValuesVM()
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
                                ViewWhenForAddDtos = AllAdvancedFormBuilderViewWhenRelationEntities
                                    .Where(y => y.AdvancedFormBuilderId == x.Id)
                                    .Select(y => new ViewWhenForAddDto()
                                    {
                                        Id = y.Id,
                                        DynamicAttributeListValueId = y.AdvancedFormBuilderListValueId
                                    }).ToList(),
                                AttributeDataTypeName = x.AttributeDataType!.Name
                            }).ToList();

                        foreach (AdvancedFormBuilderListWithListValuesVM AdvancedFormBuilderInSection in AdvancedFormBuilderSection.AdvancedFormBuilders)
                        {
                            AdvancedFormBuilderInSection.AdvancedFormBuilderListValues = AllInsertedAdvancedFormBuilderListValueEntities
                                .DistinctBy(x => x.Id)
                                .Where(x => x.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id)
                                .Select(x => new AdvancedFormBuilderListValueListVM()
                                {
                                    Id = x.Id,
                                    EnglishValue = x.EnglishValue,
                                    ArabicValue = x.ArabicValue,
                                    Value = Request.lang == "en"
                                        ? x.EnglishValue
                                        : x.ArabicValue
                                }).ToList();

                            AdvancedFormBuilderInSection.AttributeDataTypeName = DataTypes
                                .FirstOrDefault(y => y.Id == AdvancedFormBuilderInSection.AttributeDataTypeId)!.Name;
                        }
                    }

                    foreach (AdvancedFormBuilderListWithListValuesVM AdvancedFormBuilderInSection in AdvancedFormBuilderSection.AdvancedFormBuilders)
                    {
                        AdvancedFormBuilderInSection.AdvancedFormBuilderListValues = AllInsertedAdvancedFormBuilderListValueEntities
                            .DistinctBy(x => x.Id)
                            .Where(x => x.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id)
                            .Select(x => new AdvancedFormBuilderListValueListVM()
                            {
                                Id = x.Id,
                                EnglishValue = x.EnglishValue,
                                ArabicValue = x.ArabicValue,
                                Value = Request.lang == "en"
                                    ? x.EnglishValue
                                    : x.ArabicValue
                            }).ToList();

                        AdvancedFormBuilderInSection.AttributeDataTypeName = DataTypes
                            .FirstOrDefault(y => y.Id == AdvancedFormBuilderInSection.AttributeDataTypeId)!.Name;
                    }

                    foreach (IGrouping<int, AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueEntity in AdvancedFormBuilderTableValueEntities)
                    {
                        foreach (AdvancedFormBuilderTableValue OneAdvancedFormBuilderTableValueEntity in AdvancedFormBuilderTableValueEntity)
                        {
                            if (!AdvancedFormBuilderSection.AdvancedFormBuilders
                                .Any(y => y.Id == OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilderId &&
                                    y.RowId == AdvancedFormBuilderTableValueEntity.Key))
                            {
                                AdvancedFormBuilderListWithListValuesVM AdvancedFormBuilderInSection = new AdvancedFormBuilderListWithListValuesVM()
                                {
                                    Id = OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilderId,
                                    AttributeDataTypeId = OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilder!.AttributeDataTypeId,
                                    Label = Language.ToLower() == "ar"
                                        ? OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilder!.ArabicLabel
                                        : OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilder!.EnglishLabel,
                                    PlaceHolder = Language.ToLower() == "ar"
                                        ? OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilder!.ArabicPlaceHolder
                                        : OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilder!.EnglishPlaceHolder,
                                    isRequired = OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilder!.IsRequired,
                                    MaxSizeInKB = OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilder!.MaxSizeInKB,
                                    RowId = AdvancedFormBuilderTableValueEntity.Key,
                                    ViewWhenForAddDtos = AllAdvancedFormBuilderViewWhenRelationEntities
                                        .Where(y => y.AdvancedFormBuilderId == OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilderId)
                                        .Select(y => new ViewWhenForAddDto()
                                        {
                                            Id = y.Id,
                                            DynamicAttributeListValueId = y.AdvancedFormBuilderListValueId
                                        }).ToList(),
                                    AttributeDataTypeName = OneAdvancedFormBuilderTableValueEntity.AdvancedFormBuilder!.AttributeDataType!.Name
                                };

                                AdvancedFormBuilderInSection.AdvancedFormBuilderListValues = AllInsertedAdvancedFormBuilderListValueEntities
                                    .Where(x => x.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id)
                                    .Select(x => new AdvancedFormBuilderListValueListVM()
                                    {
                                        Id = x.Id,
                                        EnglishValue = x.EnglishValue,
                                        ArabicValue = x.ArabicValue,
                                        Value = Request.lang == "en"
                                            ? x.EnglishValue
                                            : x.ArabicValue
                                    }).ToList();

                                AdvancedFormBuilderInSection.AttributeDataTypeName = DataTypes
                                    .FirstOrDefault(y => y.Id == AdvancedFormBuilderInSection.AttributeDataTypeId)!.Name;

                                if (AlreadyInsertedAdvancedFormBuilderTableValues.Count() > 0)
                                {
                                    if (AdvancedFormBuilderInSection.AttributeDataTypeName.ToLower() == "File".ToLower() ||
                                        AdvancedFormBuilderInSection.AttributeDataTypeName.ToLower() == "Image".ToLower())
                                    {
                                        AdvancedFormBuilderTableValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedAdvancedFormBuilderTableValues
                                            .FirstOrDefault(y => y.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id &&
                                                y.RowId == AdvancedFormBuilderTableValueEntity.Key);

                                        if (CheckIfValueIsAlreadyInserted != null)
                                        {
                                            if (CheckIfValueIsAlreadyInserted.Value.Contains("wwwroot"))
                                            {
                                                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                                                string WWWRootFilePath = isHttps
                                                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}"
                                                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}";

                                                AdvancedFormBuilderInSection.InsertedValueAsBinaryFilePath = (WWWRootFilePath + CheckIfValueIsAlreadyInserted.Value.Split("wwwroot")[1]).Replace("\\", "/");
                                            }
                                            else
                                            {
                                                AdvancedFormBuilderInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
                                            }
                                        }
                                    }
                                    else if (AdvancedFormBuilderInSection.AttributeDataTypeName.ToLower() == "Phone Number".ToLower())
                                    {
                                        AdvancedFormBuilderTableValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedAdvancedFormBuilderTableValues
                                            .FirstOrDefault(y => y.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id);

                                        if (CheckIfValueIsAlreadyInserted != null)
                                        {
                                            AdvancedFormBuilderInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value.Replace("0097105", string.Empty);
                                        }
                                    }
                                    else
                                    {
                                        AdvancedFormBuilderTableValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedAdvancedFormBuilderTableValues
                                            .FirstOrDefault(y => y.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id &&
                                                y.RowId == AdvancedFormBuilderTableValueEntity.Key);

                                        if (CheckIfValueIsAlreadyInserted != null)
                                        {
                                            AdvancedFormBuilderInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value;
                                        }
                                    }
                                }

                                AdvancedFormBuilderSection.AdvancedFormBuilders.Add(AdvancedFormBuilderInSection);
                            }
                        }
                    }
                }
            }

            return new BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>>(ResponseMessage, true, 200, AdvancedFormBuilderSections);
        }
    }
}
