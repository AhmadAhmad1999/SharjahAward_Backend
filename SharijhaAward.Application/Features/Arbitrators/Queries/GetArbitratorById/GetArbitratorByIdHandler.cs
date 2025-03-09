using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionForAddAdminDashboard;
using SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class GetArbitratorByIdHandler : IRequestHandler<GetArbitratorByIdQuery, BaseResponse<GetArbitratorByIdResponse>>
    {
        private readonly IAsyncRepository<ResponsibilityUser> _userRepository;
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository;
        private readonly IAsyncRepository<SubcommitteeCategory> _SubcommitteeCategoryRepository;

        public GetArbitratorByIdHandler(IAsyncRepository<Arbitrator> _ArbitratorRepository,
            IAsyncRepository<ResponsibilityUser> _userRepository,
            IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository,
            IMapper _Mapper,
            IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository,
            IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository,
            IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository,
            IAsyncRepository<SubcommitteeCategory> _SubcommitteeCategoryRepository)
        {
            this._userRepository = _userRepository;
            this._ArbitratorRepository = _ArbitratorRepository;
            this._CategoryArbitratorRepository = _CategoryArbitratorRepository;
            this._Mapper = _Mapper;
            this._DynamicAttributeSectionRepository = _DynamicAttributeSectionRepository;
            this._DynamicAttributeListValueRepository = _DynamicAttributeListValueRepository;
            this._AttributeDataTypeRepository = _AttributeDataTypeRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._DynamicAttributeRepository = _DynamicAttributeRepository;
            this._ArbitratorClassRepository = _ArbitratorClassRepository;
            this._SubcommitteeCategoryRepository = _SubcommitteeCategoryRepository;
        }
        public async Task<BaseResponse<GetArbitratorByIdResponse>> Handle(GetArbitratorByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitrator? ArbitratorEntity = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ArbitratorId);

            if (ArbitratorEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator is not found"
                    : "المحكم غير موجود";

                return new BaseResponse<GetArbitratorByIdResponse>(ResponseMessage, false, 404);
            }

            ArbitratorDto ArbitratorDto = _Mapper.Map<ArbitratorDto>(ArbitratorEntity);

            // Classes..
            IEnumerable<ArbitratorClass> ArbitratorClasses = _ArbitratorClassRepository
                .Where(x => x.ArbitratorId == Request.ArbitratorId)
                .AsEnumerable();

            ArbitratorDto.ArbitratorCateogryClasses = await _CategoryArbitratorRepository
                .Where(x => x.ArbitratorId == Request.ArbitratorId)
                .Select(x => new ArbitratorCategoryDto()
                {
                    Id = x.CategoryId,
                    ArabicName = x.Category!.ArabicName,
                    EnglishName = x.Category!.EnglishName,
                    CategoryName = Request.lang == "en"
                        ? x.Category!.EnglishName
                        : x.Category!.ArabicName,
                    RelatedToClasses = x.Category!.RelatedToClasses != null
                        ? x.Category!.RelatedToClasses.Value : false,
                    Classes = ArbitratorClasses
                        .Where(y => y.CategoryEducationalClass!.CategoryId == x.CategoryId)
                        .AsEnumerable()
                        .Select(y => new CategoryClassesDto()
                        {
                            Id = y.CategoryEducationalClassId,
                            ClassName = Request.lang == "en"
                                ? y.CategoryEducationalClass!.EducationalClass!.EnglishName
                                : y.CategoryEducationalClass!.EducationalClass!.ArabicName
                        }).ToList()
                }).ToListAsync();

            ArbitratorDto.SubcommitteeOfficerCategories = await _SubcommitteeCategoryRepository
                .Where(x => x.ArbitratorId == Request.ArbitratorId)
                .Select(x => new ArbitratorCategoryDto()
                {
                    ArabicName = x.Category!.ArabicName,
                    CategoryName = Request.lang == "en"
                        ? x.Category!.EnglishName
                        : x.Category!.ArabicName,
                    EnglishName = x.Category!.EnglishName,
                    Id = x.Category!.Id,
                    RelatedToClasses = x.Category!.RelatedToClasses != null
                        ? x.Category!.RelatedToClasses.Value : false,
                    Classes = ArbitratorClasses
                        .Where(y => y.CategoryEducationalClass!.CategoryId == x.CategoryId)
                        .AsEnumerable()
                        .Select(y => new CategoryClassesDto()
                        {
                            Id = y.CategoryEducationalClassId,
                            ClassName = Request.lang == "en"
                                ? y.CategoryEducationalClass!.EducationalClass!.EnglishName
                                : y.CategoryEducationalClass!.EducationalClass!.ArabicName
                        }).ToList()
                }).ToListAsync();

            //
            // Dynamic Fields..
            //

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard> DynamicAttributeSections = _DynamicAttributeSectionRepository
                .IncludeThenWhere(x => x.AttributeTableName!, x => x.RecordIdOnRelation == -2 &&
                    x.AttributeTableName!.Name.ToLower() == Helpers.Constants.TableNames.Coordinator.ToString().ToLower())
                .Select(x => new GetAllDynamicAttributeSectionsForAddListVMAdminDashboard()
                {
                    Id = x.Id,
                    Name = Language == "ar"
                        ? x.ArabicName
                        : x.EnglishName
                }).ToList();

            IReadOnlyList<AttributeDataType> DataTypes = await _AttributeDataTypeRepository.ListAllAsync();

            List<DynamicAttributeValue> AlreadyInsertedDynamicAttributeValues = await _DynamicAttributeValueRepository
                .Where(x => x.RecordIdAsGuid != null
                    ? x.RecordIdAsGuid == Request.ArbitratorId
                    : false).ToListAsync();

            foreach (GetAllDynamicAttributeSectionsForAddListVMAdminDashboard DynamicAttributeSection in DynamicAttributeSections)
            {
                DynamicAttributeSection.DynamicAttributes = await _DynamicAttributeRepository
                    .Where(x => x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                        DynamicAttributeSections.Select(y => y.Id).Contains(x.DynamicAttributeSectionId) &&
                        x.DynamicAttributeSectionId == DynamicAttributeSection.Id)
                    .Select(x => new DynamicAttributeListWithListValuesVMAdminDashboard()
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

                foreach (DynamicAttributeListWithListValuesVMAdminDashboard DynamicAttributeInSection in DynamicAttributeSection.DynamicAttributes)
                {
                    DynamicAttributeInSection.DynamicAttributeListValues = _Mapper.Map<List<DynamicAttributeListValueListVM>>(
                        await _DynamicAttributeListValueRepository
                            .Where(x => x.DynamicAttributeId == DynamicAttributeInSection.Id).ToListAsync());

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
                                DynamicAttributeInSection.isAccepted = true;
                            }
                        }
                        else
                        {
                            DynamicAttributeValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeValues
                                .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                            if (CheckIfValueIsAlreadyInserted != null)
                            {
                                DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value;
                                DynamicAttributeInSection.isAccepted = true;
                            }
                        }
                    }
                }
            }

            var ResponsibilitiesUser = await _userRepository
                .Where(u => u.UserId == Request.ArbitratorId)
                .ToListAsync();

            GetArbitratorByIdResponse Response = new GetArbitratorByIdResponse()
            {
                ArbitratorDto = ArbitratorDto,
                DynamicAttributesSections = DynamicAttributeSections,
                ResponsibilityUsers = _Mapper.Map<List<ResponsibilityUserDto>>(ResponsibilitiesUser)
            };

            return new BaseResponse<GetArbitratorByIdResponse>(ResponseMessage, true, 200, Response);
        }
    }
}
