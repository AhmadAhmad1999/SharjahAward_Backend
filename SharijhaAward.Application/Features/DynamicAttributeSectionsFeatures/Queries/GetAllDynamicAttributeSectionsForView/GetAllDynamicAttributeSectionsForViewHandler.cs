using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using RestSharp;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView
{
    public class GetAllDynamicAttributeSectionsForViewHandler : IRequestHandler<GetAllDynamicAttributeSectionsForViewQuery,
        BaseResponse<List<DynamicAttributeSectionListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;

        public GetAllDynamicAttributeSectionsForViewHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _CategoryRepository = CategoryRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
        }
        public async Task<BaseResponse<List<DynamicAttributeSectionListVM>>> Handle(GetAllDynamicAttributeSectionsForViewQuery Request,
            CancellationToken cancellationToken)
        {
            if (Request.CategoryId is not null)
            {
                string Language = !string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() : "ar";

                string ResponseMessage = string.Empty;

                Category? CategoryEntity = await _CategoryRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.CategoryId);

                if (CategoryEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Category is not found"
                        : "الفئة غير موجودة";

                    return new BaseResponse<List<DynamicAttributeSectionListVM>>(ResponseMessage, false, 404);
                }
                
                List<DynamicAttributeSectionListVM> DynamicAttributeSections = new List<DynamicAttributeSectionListVM>();

                if (Request.page != 0 && Request.perPage != -1)
                    DynamicAttributeSections = await _DynamicAttributeSectionRepository
                        .IncludeThenWhere(x => x.AttributeTableName!,
                            x => x.RecordIdOnRelation == Request.CategoryId &&
                            x.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower())
                        .OrderBy(x => x.OrderId)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .Select(x => new DynamicAttributeSectionListVM()
                        {
                            Id = x.Id,
                            Name = Language == "ar"
                                ? x.ArabicName
                                : x.EnglishName,
                            TableTypeSection = x.TableTypeSection
                        }).ToListAsync();

                else
                    DynamicAttributeSections = await _DynamicAttributeSectionRepository
                        .IncludeThenWhere(x => x.AttributeTableName!,
                            x => x.RecordIdOnRelation == Request.CategoryId &&
                            x.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower())
                        .OrderBy(x => x.OrderId)
                        .Select(x => new DynamicAttributeSectionListVM()
                        {
                            Id = x.Id,
                            Name = Language == "ar"
                                ? x.ArabicName
                                : x.EnglishName,
                            TableTypeSection = x.TableTypeSection
                        }).ToListAsync();

                if (DynamicAttributeSections.FirstOrDefault(x => x.Name.ToLower() == "Main Information".ToLower() ||
                    x.Name == "المعلومات الأساسية") == null)
                {
                    DynamicAttributeSection PersonalInformationSection = new DynamicAttributeSection()
                    {
                        isDeleted = false,
                        DeletedAt = null,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        ArabicName = "المعلومات الأساسية",
                        EnglishName = "Main Information",
                        AttributeTableNameId = 1,
                        RecordIdOnRelation = Request.CategoryId,
                        TableTypeSection = false
                    };

                    await _DynamicAttributeSectionRepository.AddAsync(PersonalInformationSection);

                    DynamicAttributeSections.Add(new DynamicAttributeSectionListVM()
                    {
                        Id = PersonalInformationSection.Id,
                        Name = Language == "en"
                            ? PersonalInformationSection.EnglishName
                            : PersonalInformationSection.ArabicName
                    });

                    List<DynamicAttribute> MainInformationDynamicAttribute = new List<DynamicAttribute>()
                    {
                        new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = PersonalInformationSection.Id,
                            EnglishLabel = "Full name (identical to Emirates ID)",
                            EnglishTitle = "Full name (identical to Emirates ID)",
                            ArabicLabel = "الاسم الكامل (مطابق للهوية الإماراتية)",
                            ArabicTitle = "الاسم الكامل (مطابق للهوية الإماراتية)",
                            AttributeDataTypeId = 1,
                            IsRequired = true,
                            IsUnique = false,
                            LinkedToAnotherAttribute = false,
                            MaxSizeInKB = null,
                            Status = DynamicAttributeStatus.Active,
                            ArabicPlaceHolder = "الاسم الكامل",
                            EnglishPlaceHolder = "Full name",
                            OrderId = 1
                        }, new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = PersonalInformationSection.Id,
                            EnglishLabel = "Nationality",
                            EnglishTitle = "Nationality",
                            ArabicLabel = "الجنسية",
                            ArabicTitle = "الجنسية",
                            AttributeDataTypeId = 8,
                            IsRequired = true,
                            IsUnique = false,
                            LinkedToAnotherAttribute = false,
                            MaxSizeInKB = null,
                            Status = DynamicAttributeStatus.Active,
                            ArabicPlaceHolder = "الإمارات العربية المتحدة",
                            EnglishPlaceHolder = "United Arab Emirates",
                            OrderId = 2
                        }, new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = PersonalInformationSection.Id,
                            EnglishLabel = "Gender",
                            EnglishTitle = "Gender",
                            ArabicLabel = "الجنس",
                            ArabicTitle = "الجنس",
                            AttributeDataTypeId = 8,
                            IsRequired = true,
                            IsUnique = false,
                            LinkedToAnotherAttribute = false,
                            MaxSizeInKB = null,
                            Status = DynamicAttributeStatus.Active,
                            ArabicPlaceHolder = "ذكر",
                            EnglishPlaceHolder = "Male",
                            OrderId = 3
                        }, new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = PersonalInformationSection.Id,
                            EnglishLabel = "Date of birth",
                            EnglishTitle = "Date of birth",
                            ArabicLabel = "تاريخ الميلاد",
                            ArabicTitle = "تاريخ الميلاد",
                            AttributeDataTypeId = 7,
                            IsRequired = true,
                            IsUnique = false,
                            LinkedToAnotherAttribute = false,
                            MaxSizeInKB = null,
                            Status = DynamicAttributeStatus.Active,
                            ArabicPlaceHolder = DateTime.UtcNow.ToShortDateString(),
                            EnglishPlaceHolder = DateTime.UtcNow.ToShortDateString(),
                            OrderId = 4
                        }, new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = PersonalInformationSection.Id,
                            EnglishLabel = "Emirates ID number",
                            EnglishTitle = "Emirates ID number",
                            ArabicLabel = "رقم الهوية الإماراتية",
                            ArabicTitle = "رقم الهوية الإماراتية",
                            AttributeDataTypeId = 10,
                            IsRequired = true,
                            IsUnique = false,
                            LinkedToAnotherAttribute = false,
                            MaxSizeInKB = null,
                            Status = DynamicAttributeStatus.Active,
                            ArabicPlaceHolder = "xxx-xxxx-xxxxxxx-x",
                            EnglishPlaceHolder = "xxx-xxxx-xxxxxxx-x",
                            OrderId = 5
                        }
                    };

                    if (CategoryEntity.RelatedToClasses is not null
                        ? CategoryEntity.RelatedToClasses.Value
                        : false)
                    {
                        MainInformationDynamicAttribute.Add(new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = PersonalInformationSection.Id,
                            EnglishLabel = "Class",
                            EnglishTitle = "Class",
                            ArabicLabel = "الصف",
                            ArabicTitle = "الصف",
                            AttributeDataTypeId = 8,
                            IsRequired = true,
                            IsUnique = false,
                            LinkedToAnotherAttribute = false,
                            MaxSizeInKB = null,
                            Status = DynamicAttributeStatus.Active,
                            ArabicPlaceHolder = "الصف مرتبط بالفئة",
                            EnglishPlaceHolder = "The class is related to the category",
                            OrderId = 6
                        });
                    }

                    if(CategoryEntity.RelatedToEducationalEntities)
                    {
                        MainInformationDynamicAttribute.Add(new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = PersonalInformationSection.Id,
                            EnglishLabel = "Educational Entity",
                            EnglishTitle = "Educational Entity",
                            ArabicLabel = "الجهة التعليمية",
                            ArabicTitle = "الجهة التعليمية",
                            AttributeDataTypeId = 8,
                            IsRequired = true,
                            IsUnique = false,
                            LinkedToAnotherAttribute = false,
                            MaxSizeInKB = null,
                            Status = DynamicAttributeStatus.Active,
                            ArabicPlaceHolder = "الجهة التعليمية مرتبطة بالفئة",
                            EnglishPlaceHolder = "The educational entity is related to the category",
                            OrderId = 7
                        });
                    }

                    await _DynamicAttributeRepository.AddRangeAsync(MainInformationDynamicAttribute);

                    DynamicAttribute? NationalityDynamicAttributes = MainInformationDynamicAttribute
                        .FirstOrDefault(x => x.AttributeDataTypeId == 8 && x.EnglishTitle.ToLower() == "Nationality".ToLower());

                    string BaseUrl = "https://restcountries.com/v3.1/";

                    RestClient RestClient = new RestClient(BaseUrl);
                    RestRequest RestRequest = new RestRequest("all", Method.Get);

                    RestResponse<List<NationalityResponse>> Response = RestClient.Execute<List<NationalityResponse>>(RestRequest);

                    if (Response.IsSuccessful)
                    {
                        List<NationalityResponse> Nationalities = Response.Data!;

                        List<NationalityDto> FormattedResponse = new List<NationalityDto>();

                        foreach (NationalityResponse Nationality in Nationalities!)
                        {
                            NationalityDto nationalityDto = new NationalityDto
                            {
                                ArabicName = Nationality.Translations.ara.common,
                                EnglishName = Nationality.Name.Common
                            };

                            FormattedResponse.Add(nationalityDto);
                        }

                        if (NationalityDynamicAttributes is not null)
                        {
                            IEnumerable<DynamicAttributeListValue> NewNationalitiesValues = FormattedResponse
                                .Select(x => new DynamicAttributeListValue()
                                {
                                    isDeleted = false,
                                    DeletedAt = null,
                                    CreatedAt = DateTime.UtcNow,
                                    CreatedBy = null,
                                    LastModifiedAt = null,
                                    LastModifiedBy = null,
                                    DynamicAttributeId = NationalityDynamicAttributes.Id,
                                    EnglishValue = x.EnglishName,
                                    ArabicValue = x.ArabicName
                                });

                            await _DynamicAttributeListValueRepository.AddRangeAsync(NewNationalitiesValues);
                        }
                    }

                    DynamicAttribute? GenderDynamicAttributes = MainInformationDynamicAttribute
                        .FirstOrDefault(x => x.AttributeDataTypeId == 8 && x.EnglishTitle.ToLower() == "Gender".ToLower());

                    if (GenderDynamicAttributes is not null)
                    {
                        List<DynamicAttributeListValue> GendersValues = new List<DynamicAttributeListValue>()
                        {
                            new DynamicAttributeListValue()
                            {
                                isDeleted = false,
                                DeletedAt = null,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = null,
                                LastModifiedAt = null,
                                LastModifiedBy = null,
                                DynamicAttributeId = GenderDynamicAttributes.Id,
                                EnglishValue = "Male",
                                ArabicValue = "ذكر"
                            }, new DynamicAttributeListValue()
                            {
                                isDeleted = false,
                                DeletedAt = null,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = null,
                                LastModifiedAt = null,
                                LastModifiedBy = null,
                                DynamicAttributeId = GenderDynamicAttributes.Id,
                                EnglishValue = "Female",
                                ArabicValue =  "أنثى"
                            }
                        };

                        await _DynamicAttributeListValueRepository.AddRangeAsync(GendersValues);
                    }

                    DynamicAttribute? ClassDynamicAttributes = MainInformationDynamicAttribute
                        .FirstOrDefault(x => x.AttributeDataTypeId == 8 && x.EnglishTitle.ToLower() == "Class".ToLower());

                    if (ClassDynamicAttributes is not null)
                    {
                        List<DynamicAttributeListValue> NewEducationalClasses = await _CategoryEducationalClassRepository
                            .Where(x => x.CategoryId == Request.CategoryId)
                            .Select(x => new DynamicAttributeListValue()
                            {
                                isDeleted = false,
                                DeletedAt = null,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = null,
                                LastModifiedAt = null,
                                LastModifiedBy = null,
                                DynamicAttributeId = ClassDynamicAttributes.Id,
                                ArabicValue = x.EducationalClass!.ArabicName,
                                EnglishValue = x.EducationalClass!.EnglishName
                            }).ToListAsync();

                        await _DynamicAttributeListValueRepository.AddRangeAsync(NewEducationalClasses);
                    }

                    DynamicAttribute? EducationalEntityDynamicAttributes = MainInformationDynamicAttribute
                        .FirstOrDefault(x => x.AttributeDataTypeId == 8 && x.EnglishTitle.ToLower() == "Educational Entity".ToLower());

                    if (EducationalEntityDynamicAttributes is not null)
                    {
                        List<DynamicAttributeListValue> NewEducationalEntities = await _EducationalEntityRepository
                            .Select(x => new DynamicAttributeListValue()
                            {
                                isDeleted = false,
                                DeletedAt = null,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = null,
                                LastModifiedAt = null,
                                LastModifiedBy = null,
                                DynamicAttributeId = EducationalEntityDynamicAttributes.Id,
                                ArabicValue = x.ArabicName,
                                EnglishValue = x.EnglishName
                            }).ToListAsync();

                        await _DynamicAttributeListValueRepository.AddRangeAsync(NewEducationalEntities);
                    }
                }

                foreach (DynamicAttributeSectionListVM DynamicAttributeSection in DynamicAttributeSections)
                {
                    DynamicAttributeSection.DynamicAttributes = _DynamicAttributeRepository
                        .WhereThenInclude(x => x.DynamicAttributeSectionId == DynamicAttributeSection.Id,
                            x => x.AttributeDataType!)
                        .OrderBy(x => x.OrderId)
                        .Select(x => new DynamicAttributeListVM()
                        {
                            Id = x.Id,
                            AttributeDataTypeName = x.AttributeDataType!.Name,
                            Label = Language.ToLower() == "ar"
                                ? x.ArabicLabel
                                : x.EnglishLabel,
                            PlaceHolder = Language.ToLower() == "ar"
                                ? x.ArabicPlaceHolder
                                : x.EnglishPlaceHolder,
                            Status = x.Status.ToString()
                        }).ToList();
                }

                DynamicAttributeSectionListVM? MainInformationDynamicSection = DynamicAttributeSections
                    .FirstOrDefault(x => x.Name.ToLower() == "Main Information".ToLower() ||
                        x.Name == "المعلومات الأساسية");

                if (MainInformationDynamicSection is not null)
                {
                    int IndexOfMainInformationSection = DynamicAttributeSections.IndexOf(MainInformationDynamicSection);

                    DynamicAttributeSectionListVM? FirstDynamicSection = DynamicAttributeSections.FirstOrDefault();

                    if (FirstDynamicSection is not null)
                    {
                        DynamicAttributeSections[0] = MainInformationDynamicSection;
                        DynamicAttributeSections[IndexOfMainInformationSection] = FirstDynamicSection;
                    }
                }

                int TotalCount = await _DynamicAttributeSectionRepository.GetCountAsync(x => x.RecordIdOnRelation == Request.CategoryId &&
                    x.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower());

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<DynamicAttributeSectionListVM>>(ResponseMessage, true, 200, DynamicAttributeSections, PaginationParameter);
            }
            else if (Request.isArbitrator is not null)
            {
                string Language = !string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() : "ar";

                string ResponseMessage = string.Empty;

                List<DynamicAttributeSectionListVM> DynamicAttributeSections = new List<DynamicAttributeSectionListVM>();

                if (Request.page != 0 && Request.perPage != -1)
                    DynamicAttributeSections = _DynamicAttributeSectionRepository
                        .IncludeThenWhere(x => x.AttributeTableName!,
                            x => Request.isArbitrator.Value
                                ? (x.AttributeTableName!.Name.ToLower() == TableNames.Arbitrator.ToString().ToLower() &&
                                    x.RecordIdOnRelation == -1)
                                : (x.AttributeTableName!.Name.ToLower() == TableNames.Coordinator.ToString().ToLower() &&
                                    x.RecordIdOnRelation == -2))
                        .OrderBy(x => x.OrderId)
                        .Skip((Request.page - 1) * Request.perPage)
                        .Take(Request.perPage)
                        .Select(x => new DynamicAttributeSectionListVM()
                        {
                            Id = x.Id,
                            Name = Language == "ar"
                                ? x.ArabicName
                                : x.EnglishName,
                            TableTypeSection = x.TableTypeSection
                        }).ToList();

                else
                    DynamicAttributeSections = _DynamicAttributeSectionRepository
                        .IncludeThenWhere(x => x.AttributeTableName!,
                            x => Request.isArbitrator.Value
                                ? (x.AttributeTableName!.Name.ToLower() == TableNames.Arbitrator.ToString().ToLower() &&
                                    x.RecordIdOnRelation == -1)
                                : (x.AttributeTableName!.Name.ToLower() == TableNames.Coordinator.ToString().ToLower() &&
                                    x.RecordIdOnRelation == -2))
                        .OrderBy(x => x.OrderId)
                        .Select(x => new DynamicAttributeSectionListVM()
                        {
                            Id = x.Id,
                            Name = Language == "ar"
                                ? x.ArabicName
                                : x.EnglishName,
                            TableTypeSection = x.TableTypeSection
                        }).ToList();

                foreach (DynamicAttributeSectionListVM DynamicAttributeSection in DynamicAttributeSections)
                {
                    DynamicAttributeSection.DynamicAttributes = _DynamicAttributeRepository
                        .WhereThenInclude(x => x.DynamicAttributeSectionId == DynamicAttributeSection.Id,
                            x => x.AttributeDataType!)
                        .OrderBy(x => x.OrderId)
                        .Select(x => new DynamicAttributeListVM()
                        {
                            Id = x.Id,
                            AttributeDataTypeName = x.AttributeDataType!.Name,
                            Label = Language.ToLower() == "ar"
                                ? x.ArabicLabel
                                : x.EnglishLabel,
                            PlaceHolder = Language.ToLower() == "ar"
                                ? x.ArabicPlaceHolder
                                : x.EnglishPlaceHolder,
                            Status = x.Status.ToString()
                        }).ToList();
                }

                int TotalCount = await _DynamicAttributeSectionRepository.GetCountAsync(x => Request.isArbitrator.Value
                    ? (x.AttributeTableName!.Name.ToLower() == TableNames.Arbitrator.ToString().ToLower() &&
                        x.RecordIdOnRelation == -1)
                    : (x.AttributeTableName!.Name.ToLower() == TableNames.Coordinator.ToString().ToLower() &&
                        x.RecordIdOnRelation == -2));

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<DynamicAttributeSectionListVM>>(ResponseMessage, true, 200, DynamicAttributeSections, PaginationParameter);
            }
            return new BaseResponse<List<DynamicAttributeSectionListVM>>();
        }
    }
    public class NationalityResponse
    {
        public Translations Translations { get; set; } = null!;
        public Name Name { get; set; } = null!;
    }
    public class Translations
    {
        public Ara ara { get; set; } = null!;
    }
    public class Ara
    {
        public string official { get; set; } = null!;
        public string common { get; set; } = null!;
    }
    public class Name
    {
        public string Common { get; set; } = null!;
    }
    public class NationalityDto
    {
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
    }
}
