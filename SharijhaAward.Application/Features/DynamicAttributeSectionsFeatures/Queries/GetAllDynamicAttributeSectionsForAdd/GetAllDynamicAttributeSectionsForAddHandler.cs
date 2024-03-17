using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.CreateDynamicAttributeSection;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System.Collections.Generic;
using System.IO;
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
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        public GetAllDynamicAttributeSectionsForAddHandler(IMapper Mapper,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> ProvidedFormRepository)
        {
            _Mapper = Mapper;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
        }
        public async Task<BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>> Handle(GetAllDynamicAttributeSectionsForAddQuery Request,
            CancellationToken cancellationToken)
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
                    : "الاستمارة المقدمة غير موجود";

                return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>(ResponseMessage, false, 404);
            }

            List<GetAllDynamicAttributeSectionsForAddListVM> DynamicAttributeSections = _DynamicAttributeSectionRepository
                .IncludeThenWhere(x => x.AttributeTableName!, x => x.RecordIdOnRelation == ProvidedFormEntity.categoryId &&
                    x.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower())
                .Select(x => new GetAllDynamicAttributeSectionsForAddListVM()
                {
                    Id = x.Id,
                    Name = Language == "ar"
                        ? x.ArabicName
                        : x.EnglishName
                }).ToList();

            if (DynamicAttributeSections.Count <= 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no sections"
                    : "لا يوجد أقسام";

                return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>(ResponseMessage, false, 204, DynamicAttributeSections, 0);
            }

            IReadOnlyList<AttributeDataType> DataTypes = await _AttributeDataTypeRepository.ListAllAsync();

            List<DynamicAttributeValue> AlreadyInsertedDynamicAttributeValues = await _DynamicAttributeValueRepository
                .Where(x => x.RecordId != null 
                    ? x.RecordId == Request.ProvidedFormId
                    : false).ToListAsync();

            foreach (GetAllDynamicAttributeSectionsForAddListVM DynamicAttributeSection in DynamicAttributeSections)
            {
                DynamicAttributeSection.DynamicAttributes = await _DynamicAttributeRepository
                    .Where(x => x.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                        DynamicAttributeSections.Select(y => y.Id).Contains(x.DynamicAttributeSectionId) &&
                        x.DynamicAttributeSectionId == DynamicAttributeSection.Id)
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

            return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>(ResponseMessage, true, 200, DynamicAttributeSections);
        }
    }
}
