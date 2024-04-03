using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Classes.Queries.GetAllClasses;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionForAddAdminDashboard;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.Arbitrators.Queries.GetArbitratorById
{
    public class GetArbitratorByIdHandler : IRequestHandler<GetArbitratorByIdQuery, BaseResponse<GetArbitratorByIdResponse>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository;
        public GetArbitratorByIdHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository,
            IMapper Mapper,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<ArbitratorClass> ArbitratorClassRepository)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
            _Mapper = Mapper;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _ArbitratorClassRepository = ArbitratorClassRepository;
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

            ArbitratorDto.ArbitratorCategories = await _CategoryArbitratorRepository
                .Where(x => x.ArbitratorId == Request.ArbitratorId)
                .Include(x => x.Category!)
                .Select(x => new ArbitratorCategoryDto()
                {
                    Id = x.Category!.Id,
                    ArabicName = x.Category!.ArabicName,
                    EnglishName = x.Category!.EnglishName
                }).ToListAsync();

            //
            // Dynamic Fields..
            //

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard> DynamicAttributeSections = _DynamicAttributeSectionRepository
                .IncludeThenWhere(x => x.AttributeTableName!, x => x.RecordIdOnRelation == ArbitratorEntity.Id &&
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
                                DynamicAttributeInSection.isAccepted = CheckIfValueIsAlreadyInserted.isAccepted;
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
                            }
                        }
                    }
                }
            }

            // Classes..
            List<GetAllClassesListVM> ArbitratorClasses = await _ArbitratorClassRepository
                .Where(x => x.ArbitratorId == Request.ArbitratorId)
                .Include(x => x.EducationalClass!)
                .Select(x => x.EducationalClass!)
                .Select(x => new GetAllClassesListVM()
                {
                    Id = x.Id,
                    ArabicName = x.ArabicName,
                    EnglishName = x.EnglishName
                }).ToListAsync();

            GetArbitratorByIdResponse Response = new GetArbitratorByIdResponse()
            {
                ArbitratorDto = ArbitratorDto,
                DynamicAttributesSections = DynamicAttributeSections,
                ArbitratorClasses = ArbitratorClasses
            };

            return new BaseResponse<GetArbitratorByIdResponse>(ResponseMessage, true, 200, Response);
        }
    }
}
