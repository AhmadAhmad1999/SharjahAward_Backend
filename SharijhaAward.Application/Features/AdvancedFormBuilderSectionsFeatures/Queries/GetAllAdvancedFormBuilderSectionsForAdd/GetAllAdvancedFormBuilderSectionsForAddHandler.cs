using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Queries.GetAdvancedFormBuilderById;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Text.RegularExpressions;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderSectionsFeatures.Queries.GetAllAdvancedFormBuilderSectionsForAdd
{
    public class GetAllAdvancedFormBuilderSectionsForAddHandler : IRequestHandler<GetAllAdvancedFormBuilderSectionsForAddQuery,
        BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<AdvancedFormBuilderSection> _AdvancedFormBuilderSectionRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IAsyncRepository<AttributeDataType> _AttributeDataTypeRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderTableValue> _AdvancedFormBuilderTableValueRepository;
        private readonly IAsyncRepository<VirtualTableForSection> _VirtualTableForSectionRepository;
        public GetAllAdvancedFormBuilderSectionsForAddHandler(IMapper Mapper,
            IAsyncRepository<AdvancedFormBuilderSection> AdvancedFormBuilderSectionRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository,
            IAsyncRepository<AttributeDataType> AttributeDataTypeRepository,
            IAsyncRepository<AdvancedFormBuilderValue> AdvancedFormBuilderValueRepository,
            IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueRepository,
            IAsyncRepository<VirtualTableForSection> VirtualTableForSectionRepository)
        {
            _Mapper = Mapper;
            _AdvancedFormBuilderSectionRepository = AdvancedFormBuilderSectionRepository;
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
            _AttributeDataTypeRepository = AttributeDataTypeRepository;
            _AdvancedFormBuilderValueRepository = AdvancedFormBuilderValueRepository;
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderTableValueRepository = AdvancedFormBuilderTableValueRepository;
            _VirtualTableForSectionRepository = VirtualTableForSectionRepository;
        }
        public async Task<BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>>> 
            Handle(GetAllAdvancedFormBuilderSectionsForAddQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string Language = !string.IsNullOrEmpty(Request.lang)
                ? Request.lang.ToLower() : "ar";

            VirtualTableForSection? VirtualTableForSectionEntity = await _VirtualTableForSectionRepository
                .FirstOrDefaultAsync(x => x.Id == Request.VirtualTableForSectionId);

            if (VirtualTableForSectionEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Virtual table is not Found"
                    : "الجدول الافتراضي غير موجود";

                return new BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>>(ResponseMessage, false, 404);
            }

            List<GetAllAdvancedFormBuilderSectionsForAddListVM> AdvancedFormBuilderSections = await _AdvancedFormBuilderSectionRepository
                .Where(x => x.VirtualTableForSectionId == Request.VirtualTableForSectionId)
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

            List<AdvancedFormBuilderValue> AlreadyInsertedAdvancedFormBuilderValues = await _AdvancedFormBuilderValueRepository
                .Where(x => x.VirtualTableId == Request.VirtualTableForSectionId)
                .ToListAsync();

            List<AdvancedFormBuilderTableValue> AlreadyInsertedAdvancedFormBuilderTableValues = await _AdvancedFormBuilderTableValueRepository
                .Where(x => x.VirtualTableId == Request.VirtualTableForSectionId).ToListAsync();

            foreach (GetAllAdvancedFormBuilderSectionsForAddListVM AdvancedFormBuilderSection in AdvancedFormBuilderSections)
            {
                if (!AdvancedFormBuilderSection.TableTypeSection)
                {
                    AdvancedFormBuilderSection.AdvancedFormBuilders = await _AdvancedFormBuilderRepository
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
                            MaxSizeInKB = x.MaxSizeInKB
                        }).ToListAsync();

                    foreach (AdvancedFormBuilderListWithListValuesVM AdvancedFormBuilderInSection in AdvancedFormBuilderSection.AdvancedFormBuilders)
                    {
                        AdvancedFormBuilderInSection.AdvancedFormBuilderListValues = _Mapper.Map<List<AdvancedFormBuilderListValueListVM>>(
                            await _AdvancedFormBuilderListValueRepository
                                .Where(x => x.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id).ToListAsync());

                        List<AdvancedFormBuilderListValueListVM> CheckIfThereisNoValue = new List<AdvancedFormBuilderListValueListVM>();

                        if (Language.ToLower() == "en")
                            CheckIfThereisNoValue = AdvancedFormBuilderInSection.AdvancedFormBuilderListValues
                                .Where(x => !Regex.IsMatch(x.Value, @"\p{IsArabic}")).ToList();

                        else
                            CheckIfThereisNoValue = AdvancedFormBuilderInSection.AdvancedFormBuilderListValues
                                .Where(x => Regex.IsMatch(x.Value, @"\p{IsArabic}")).ToList();

                        if (CheckIfThereisNoValue.Count() > 0)
                            AdvancedFormBuilderInSection.AdvancedFormBuilderListValues = CheckIfThereisNoValue;

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
                                    AdvancedFormBuilderInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
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
                        .Where(x => AdvancedFormBuilderSection.AdvancedFormBuilders.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                        .Include(x => x.AdvancedFormBuilder!)
                        .GroupBy(x => x.RowId)
                        .ToListAsync();

                    List<AdvancedFormBuilderListWithListValuesVM> AdvancedFormBuildersEntities = await _AdvancedFormBuilderRepository
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
                            MaxSizeInKB = x.MaxSizeInKB
                        }).ToListAsync();

                    foreach (IGrouping<int, AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueEntity in AdvancedFormBuilderTableValueEntities)
                    {
                        foreach (AdvancedFormBuilderTableValue OneAdvancedFormBuilderTableValueEntity in AdvancedFormBuilderTableValueEntity)
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
                                RowId = AdvancedFormBuilderTableValueEntity.Key
                            };

                            AdvancedFormBuilderInSection.AdvancedFormBuilderListValues = _Mapper.Map<List<AdvancedFormBuilderListValueListVM>>(
                                await _AdvancedFormBuilderListValueRepository
                                    .Where(x => x.AdvancedFormBuilderId == AdvancedFormBuilderInSection.Id).ToListAsync());

                            List<AdvancedFormBuilderListValueListVM> CheckIfThereisNoValue = new List<AdvancedFormBuilderListValueListVM>();

                            if (Language.ToLower() == "en")
                                CheckIfThereisNoValue = AdvancedFormBuilderInSection.AdvancedFormBuilderListValues
                                    .Where(x => !Regex.IsMatch(x.Value, @"\p{IsArabic}")).ToList();

                            else
                                CheckIfThereisNoValue = AdvancedFormBuilderInSection.AdvancedFormBuilderListValues
                                    .Where(x => Regex.IsMatch(x.Value, @"\p{IsArabic}")).ToList();

                            if (CheckIfThereisNoValue.Count() > 0)
                                AdvancedFormBuilderInSection.AdvancedFormBuilderListValues = CheckIfThereisNoValue;

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
                                        AdvancedFormBuilderInSection.InsertedValueAsBinaryFilePath = CheckIfValueIsAlreadyInserted.Value;
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

            GetAllAdvancedFormBuilderSectionsForAddListVM? MainInformationDynamicSection = AdvancedFormBuilderSections
                .FirstOrDefault(x => x.Name.ToLower() == "Main Information".ToLower() ||
                    x.Name == "المعلومات الأساسية");

            if (MainInformationDynamicSection is not null)
            {
                int IndexOfMainInformationSection = AdvancedFormBuilderSections.IndexOf(MainInformationDynamicSection);

                GetAllAdvancedFormBuilderSectionsForAddListVM? FirstDynamicSection = AdvancedFormBuilderSections.FirstOrDefault();

                if (FirstDynamicSection is not null)
                {
                    AdvancedFormBuilderSections[0] = MainInformationDynamicSection;
                    AdvancedFormBuilderSections[IndexOfMainInformationSection] = FirstDynamicSection;
                }
            }

            return new BaseResponse<List<GetAllAdvancedFormBuilderSectionsForAddListVM>>(ResponseMessage, true, 200, AdvancedFormBuilderSections);
        }
    }
}
