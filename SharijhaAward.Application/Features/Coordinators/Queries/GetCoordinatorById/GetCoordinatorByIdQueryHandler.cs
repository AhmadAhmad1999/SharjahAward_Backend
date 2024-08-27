using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionForAddAdminDashboard;
using SharijhaAward.Application.Features.Responsibilities.Queries.GetAllResponsibilities;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;
using SharijhaAward.Application.Features.EducationalInstitutions.Queries.GetAllEducationalInstitutions;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using System.Collections.Generic;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class GetCoordinatorByIdQueryHandler
        : IRequestHandler<GetCoordinatorByIdQuery, BaseResponse<GetCoordinatorByIdResponse>>
    {
        private readonly IAsyncRepository<ResponsibilityUser> _userRepository;
        private readonly IAsyncRepository<EduInstitutionCoordinator> _EduInstitutionCoordinatorRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;

        public GetCoordinatorByIdQueryHandler(
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository,
            IAsyncRepository<ResponsibilityUser> userRepository,
            IAsyncRepository<EduInstitutionCoordinator> EduInstitutionCoordinatorRepository,
            IMapper Mapper,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<Coordinator> CoordinatorRepository,
            IAsyncRepository<EducationalInstitution> EducationalInstitutionRepository)
        {
            _userRepository = userRepository;
            _EduInstitutionCoordinatorRepository = EduInstitutionCoordinatorRepository;
            _Mapper = Mapper;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _CoordinatorRepository = CoordinatorRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
            _EducationalInstitutionRepository = EducationalInstitutionRepository;
        }

        public async Task<BaseResponse<GetCoordinatorByIdResponse>> Handle(GetCoordinatorByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Coordinator? CoordinatorEntity = await _CoordinatorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CoordinatorId);

            if (CoordinatorEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Coordinator is not Found"
                    : "المنسق غير موجود";

                return new BaseResponse<GetCoordinatorByIdResponse>(ResponseMessage, false, 404);
            }

            CoordinatorDto data = _Mapper.Map<CoordinatorDto>(CoordinatorEntity);
            
            data.Name = Request.lang == "en"
                ? data.EnglishName
                : data.ArabicName;

            data.EntityCoordinator = _EduEntitiesCoordinatorRepository
                .Where(x => x.CoordinatorId == CoordinatorEntity.Id)
                .Include(x => x.EducationalEntity!)
                .AsEnumerable()
                .DistinctBy(x => x.EducationalEntityId)
                .Select(x => new EduEntityCoordinatorDto()
                {
                    Id = x.EducationalEntity!.Id,
                    ArabicName = x.EducationalEntity!.ArabicName,
                    EnglishName = x.EducationalEntity!.EnglishName,
                    Name = Request.lang == "en"
                        ? x.EducationalEntity!.EnglishName
                        : x.EducationalEntity!.ArabicName
                }).ToList();

            foreach (var EntityCoordinator in data.EntityCoordinator)
            {
                EntityCoordinator.EducationalInstitutions = _Mapper.Map<List<EducationalInstitutionListVM>>(await _EducationalInstitutionRepository
                    .Where(x => x.EducationalEntityId == EntityCoordinator.EducationalEntityId)
                    .ToListAsync());
            }

            //
            // Dynamic Fields..
            //

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard> DynamicAttributeSections = _DynamicAttributeSectionRepository
                .IncludeThenWhere(x => x.AttributeTableName!, x => x.RecordIdOnRelation == -1 &&
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
                    ? x.RecordIdAsGuid == Request.CoordinatorId
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
                .Where(u => u.UserId == Request.CoordinatorId)
                .ToListAsync();

            GetCoordinatorByIdResponse Response = new GetCoordinatorByIdResponse()
            {
                CoordinatorDto = data,
                DynamicAttributesSections = DynamicAttributeSections,
                ResponsibilityUsers = _Mapper.Map<List<ResponsibilityUserDto>>(ResponsibilitiesUser)
            };

            return new BaseResponse<GetCoordinatorByIdResponse>(ResponseMessage, true, 200, Response);
        }
    }
}
