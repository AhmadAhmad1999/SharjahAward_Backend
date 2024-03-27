using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionForAddAdminDashboard;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;

namespace SharijhaAward.Application.Features.Coordinators.Queries.GetCoordinatorById
{
    public class GetCoordinatorByIdQueryHandler
        : IRequestHandler<GetCoordinatorByIdQuery, BaseResponse<GetCoordinatorByIdRespnse>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<EduInstitutionCoordinator> _eduInstitutionCoordinatorRepository;
        private readonly IAsyncRepository<EducationalInstitution> _educationalInstitutionRepository;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;

        public GetCoordinatorByIdQueryHandler(IAsyncRepository<EducationalInstitution> educationalInstitutionRepository,
            IAsyncRepository<EduInstitutionCoordinator> eduInstitutionCoordinatorRepository,
            IAsyncRepository<Coordinator> coordinatorRepository, 
            IMapper Mapper,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<Coordinator> CoordinatorRepository)
        {
            _coordinatorRepository = coordinatorRepository;
            _eduInstitutionCoordinatorRepository = eduInstitutionCoordinatorRepository;
            _educationalInstitutionRepository = educationalInstitutionRepository;
            _Mapper = Mapper;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _CoordinatorRepository = CoordinatorRepository;
        }

        public async Task<BaseResponse<GetCoordinatorByIdRespnse>> Handle(GetCoordinatorByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Coordinator? CoordinatorEntity = await _CoordinatorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CoordinatorId);

            if (CoordinatorEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Coordinator is not Found"
                    : "المنسق غير موجود";

                return new BaseResponse<GetCoordinatorByIdRespnse>(ResponseMessage, false, 404);
            }

            var EduInstitutions = _eduInstitutionCoordinatorRepository.Where(i => i.CoordinatorId == CoordinatorEntity.Id).ToList();

            var data = _Mapper.Map<CoordinatorDto>(CoordinatorEntity);
            for(int i = 0; i < EduInstitutions.Count(); i++)
            {
                var Institutions = await _educationalInstitutionRepository.GetByIdAsync(EduInstitutions[i].Id);
                if(Institutions != null)
                {
                    data.SchoolName.Add(Request.lang=="en" ? Institutions.EnglishName : Institutions.ArabicName);
                }
               
            }
            data.Name = Request.lang == "en"
                ? data.EnglishName
                : data.ArabicName;

            //
            // Dynamic Fields..
            //

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<GetAllDynamicAttributeSectionsForAddListVMAdminDashboard> DynamicAttributeSections = _DynamicAttributeSectionRepository
                .IncludeThenWhere(x => x.AttributeTableName!, x => x.RecordIdOnRelation == CoordinatorEntity.Id &&
                    string.Equals(x.AttributeTableName!.Name, nameof(Helpers.Constants.TableNames.Coordinator),
                        StringComparison.OrdinalIgnoreCase))
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

            GetCoordinatorByIdRespnse Response = new GetCoordinatorByIdRespnse()
            {
                CoordinatorDto = data,
                DynamicAttributesSections = DynamicAttributeSections
            };

            return new BaseResponse<GetCoordinatorByIdRespnse>(ResponseMessage, true, 200, Response);
        }
    }
}
