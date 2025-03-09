using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAddForUser
{
    public class GetAllDynamicAttributeSectionsForAddForUserHandler : IRequestHandler<GetAllDynamicAttributeSectionsForAddForUserQuery,
        BaseResponse<List<RolesListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IAsyncRepository<ViewWhenRelation> _ViewWhenRelationRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public GetAllDynamicAttributeSectionsForAddForUserHandler(IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository,
            IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository,
            IAsyncRepository<ViewWhenRelation> _ViewWhenRelationRepository,
            IAsyncRepository<UserRole> _UserRoleRepository,
            IUserRepository _UserRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._DynamicAttributeSectionRepository = _DynamicAttributeSectionRepository;
            this._DynamicAttributeListValueRepository = _DynamicAttributeListValueRepository;
            this._AttributeDataTypeRepository = _AttributeDataTypeRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._DynamicAttributeRepository = _DynamicAttributeRepository;
            this._DynamicAttributeTableValueRepository = _DynamicAttributeTableValueRepository;
            this._ViewWhenRelationRepository = _ViewWhenRelationRepository;
            this._UserRoleRepository = _UserRoleRepository;
            this._UserRepository = _UserRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }
        public async Task<BaseResponse<List<RolesListVM>>> Handle(GetAllDynamicAttributeSectionsForAddForUserQuery Request, CancellationToken cancellationToken)
        {
            List<UserRole> UserRoleEntities = await _UserRoleRepository
                .Where(x => x.UserId == Request.UserId)
                .ToListAsync();

            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            SharijhaAward.Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.UserId);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not Found"
                    : "المستخدم غير موجود";

                return new BaseResponse<List<RolesListVM>>(ResponseMessage, false, 404);
            }

            List<GetAllDynamicAttributeSectionsForAddListVM> DynamicAttributeSections = await _DynamicAttributeSectionRepository
                .IncludeThenWhere(x => x.AttributeTableName!, x => UserRoleEntities.Select(y => y.RoleId).Any(y => y == x.RecordIdOnRelation) &&
                    x.AttributeTableName!.Name.ToLower() == TableNames.Roles.ToString().ToLower())
                .OrderBy(x => x.OrderId)
                .Select(x => new GetAllDynamicAttributeSectionsForAddListVM()
                {
                    Id = x.Id,
                    Name = Language == "ar"
                        ? x.ArabicName
                        : x.EnglishName,
                    TableTypeSection = x.TableTypeSection,
                    RecordIdOnRelation = x.RecordIdOnRelation
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
                    ? UserRoleEntities.Select(y => y.UserId).Any(y => y == x.RecordId)
                    : false)
                .ToListAsync();

            List<DynamicAttributeTableValue> AlreadyInsertedDynamicAttributeTableValues = await _DynamicAttributeTableValueRepository
                .Where(x => UserRoleEntities.Select(y => y.UserId).Any(y => y == x.RecordId))
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
                    }
                }
                else
                {
                    List<IGrouping<int, DynamicAttributeTableValue>> DynamicAttributeTableValueEntities = await _DynamicAttributeTableValueRepository
                        .Where(x => AllDynamicAttributeEntitiesInSections.Select(y => y.Id).Contains(x.DynamicAttributeId) &&
                            UserRoleEntities.Select(y => y.UserId).Any(y => y == x.RecordId) &&
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

            List<RolesListVM> Response = DynamicAttributeSections
                .GroupBy(x => x.RecordIdOnRelation)
                .Select(x => new RolesListVM()
                {
                    RoleId = x.Key!.Value,
                    RoleName = Request.lang == "en"
                        ? UserRoleEntities
                            .FirstOrDefault(y => y.RoleId == x.Key!.Value)!
                            .Role!.EnglishName
                        : UserRoleEntities
                            .FirstOrDefault(y => y.RoleId == x.Key!.Value)!
                            .Role!.ArabicName,
                    DynamicAttributes = x.ToList()
                }).ToList();

            foreach (var item in Response)
            {
                GetAllDynamicAttributeSectionsForAddListVM? MainInformationDynamicSection = item.DynamicAttributes
                    .FirstOrDefault(x => x.Name.ToLower() == "Main Information".ToLower() ||
                        x.Name == "المعلومات الأساسية");

                if (MainInformationDynamicSection is not null)
                {
                    int IndexOfMainInformationSection = item.DynamicAttributes.IndexOf(MainInformationDynamicSection);

                    GetAllDynamicAttributeSectionsForAddListVM? FirstDynamicSection = item.DynamicAttributes.FirstOrDefault();

                    if (FirstDynamicSection is not null)
                    {
                        item.DynamicAttributes[0] = MainInformationDynamicSection;
                        item.DynamicAttributes[IndexOfMainInformationSection] = FirstDynamicSection;
                    }
                }
            }

            return new BaseResponse<List<RolesListVM>>(ResponseMessage, true, 200, Response);
        }
    }
}
