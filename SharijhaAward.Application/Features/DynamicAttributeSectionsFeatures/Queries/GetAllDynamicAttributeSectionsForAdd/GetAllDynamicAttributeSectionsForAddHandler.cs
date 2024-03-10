using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetDynamicAttributeById;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.IO;
namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForAdd
{
    public class GetAllDynamicAttributeSectionsForAddHandler : IRequestHandler<GetAllDynamicAttributeSectionsForAddQuery,
        BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;

        public GetAllDynamicAttributeSectionsForAddHandler(IMapper Mapper,
            IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _Mapper = Mapper;
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }
        public async Task<BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>> Handle(GetAllDynamicAttributeSectionsForAddQuery Request,
            CancellationToken cancellationToken)
        {
            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            List<GetAllDynamicAttributeSectionsForAddListVM> DynamicAttributeSections =
                _DynamicAttributeSectionRepository.IncludeThenWhere(x => x.AttributeTableName!,
                    x => x.RecordIdOnRelation == Request.CategoryId &&
                    x.AttributeTableName!.Name.ToLower() == TableNames.Category.ToString().ToLower())
                .Select(x => new GetAllDynamicAttributeSectionsForAddListVM()
                {
                    Id = x.Id,
                    Name = Language == "ar"
                        ? x.ArabicName
                        : x.EnglishName
                }).ToList();

            string ResponseMessage = string.Empty;

            if (DynamicAttributeSections.Count <= 0)
            {
                ResponseMessage = Request.lang == "en"
                    ? "There is no sections"
                    : "لا يوجد أقسام";

                return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>(ResponseMessage, true, 204, DynamicAttributeSections, 0);
            }

            IReadOnlyList<AttributeDataType> DataTypes = await _AttributeDataTypeRepository.ListAllAsync();

            List<DynamicAttributeValue> AlreadyInsertedDynamicAttributeValues = await _DynamicAttributeValueRepository
                .Where(x => x.RecordId == Request.CategoryId).ToListAsync();

            foreach (GetAllDynamicAttributeSectionsForAddListVM DynamicAttributeSection in DynamicAttributeSections)
            {
                DynamicAttributeSection.DynamicAttributes = await _DynamicAttributeListValueRepository
                    .Include(x => x.DynamicAttribute!)
                    .Where(x => x.DynamicAttribute!.Status == Domain.Constants.DynamicAttribute.DynamicAttributeStatus.Active &&
                        DynamicAttributeSections.Select(y => y.Id).Contains(x.DynamicAttribute!.DynamicAttributeSectionId) &&
                        x.DynamicAttribute.DynamicAttributeSectionId == DynamicAttributeSection.Id)
                    .GroupBy(x => x.DynamicAttribute)
                    .Select(x => new DynamicAttributeListWithListValuesVM()
                    {
                        Id = x.Key!.Id,
                        Key = x.Key!.Key,
                        AttributeDataTypeId = x.Key!.AttributeDataTypeId,
                        Label = Language.ToLower() == "ar"
                            ? x.Key!.ArabicLabel
                            : x.Key!.EnglishLabel,
                        PlaceHolder = Language.ToLower() == "ar"
                            ? x.Key!.ArabicPlaceHolder
                            : x.Key!.EnglishPlaceHolder,
                        isRequired = x.Key!.IsRequired,
                        DynamicAttributeListValues = _Mapper.Map<List<DynamicAttributeListValueListVM>>(x.ToList())
                    }).ToListAsync();

                DynamicAttributeSection.DynamicAttributes.ForEach(DynamicAttributeInSection =>
                {
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
                                using FileStream Stream = new FileStream(CheckIfValueIsAlreadyInserted.Value, FileMode.Open);

                                DynamicAttributeInSection.InsertedValueAsBinaryFile = new FormFile(Stream, 0, Stream.Length, null,
                                    Path.GetFileName(CheckIfValueIsAlreadyInserted.Value));
                            }
                        }
                        else
                        {
                            DynamicAttributeValue? CheckIfValueIsAlreadyInserted = AlreadyInsertedDynamicAttributeValues
                                .FirstOrDefault(y => y.DynamicAttributeId == DynamicAttributeInSection.Id);

                            if (CheckIfValueIsAlreadyInserted != null)
                                DynamicAttributeInSection.InsertedValueAsString = CheckIfValueIsAlreadyInserted.Value;
                        }
                    }
                });
            }

            return new BaseResponse<List<GetAllDynamicAttributeSectionsForAddListVM>>(ResponseMessage, true, 200, DynamicAttributeSections);
        }
    }
}
