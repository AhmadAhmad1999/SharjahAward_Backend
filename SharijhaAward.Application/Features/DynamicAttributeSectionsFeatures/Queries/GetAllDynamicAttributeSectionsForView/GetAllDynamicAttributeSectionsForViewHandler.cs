﻿using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using RestSharp;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Queries.GetAllDynamicAttributeSectionsForView
{
    public class GetAllDynamicAttributeSectionsForViewHandler : IRequestHandler<GetAllDynamicAttributeSectionsForViewQuery,
        BaseResponse<List<DynamicAttributeSectionListVM>>>
    {
        private readonly IAsyncRepository<DynamicAttributeSection> _DynamicAttributeSectionRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<Category> _CategoryRepository;

        public GetAllDynamicAttributeSectionsForViewHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<Category> CategoryRepository)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _CategoryRepository = CategoryRepository;
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

                if (Request.page != 0 && Request.pageSize != -1)
                    DynamicAttributeSections = _DynamicAttributeSectionRepository
                        .IncludeThenWhere(x => x.AttributeTableName!,
                            x => x.RecordIdOnRelation == Request.CategoryId &&
                            x.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower())
                        .OrderBy(x => x.OrderId)
                        .Skip((Request.page - 1) * Request.pageSize)
                        .Take(Request.pageSize)
                        .Select(x => new DynamicAttributeSectionListVM()
                        {
                            Id = x.Id,
                            Name = Language == "ar"
                                ? x.ArabicName
                                : x.EnglishName
                        }).ToList();

                else
                    DynamicAttributeSections = _DynamicAttributeSectionRepository
                        .IncludeThenWhere(x => x.AttributeTableName!,
                            x => x.RecordIdOnRelation == Request.CategoryId &&
                            x.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower())
                        .OrderBy(x => x.OrderId)
                        .Select(x => new DynamicAttributeSectionListVM()
                        {
                            Id = x.Id,
                            Name = Language == "ar"
                                ? x.ArabicName
                                : x.EnglishName
                        }).ToList();

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
                        RecordIdOnRelation = Request.CategoryId
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
                            ArabicLabel = "الاسم الكامل (مطابق للهوية الإماراتية)",
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
                            ArabicLabel = "الجنسية",
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
                            ArabicLabel = "الجنس",
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
                            ArabicLabel = "تاريخ الميلاد",
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
                            ArabicLabel = "رقم الهوية الإماراتية",
                            AttributeDataTypeId = 10,
                            IsRequired = true,
                            IsUnique = false,
                            LinkedToAnotherAttribute = false,
                            MaxSizeInKB = null,
                            Status = DynamicAttributeStatus.Active,
                            ArabicPlaceHolder = string.Empty,
                            EnglishPlaceHolder = string.Empty,
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
                            ArabicLabel = "الصف",
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

                    await _DynamicAttributeRepository.AddRangeAsync(MainInformationDynamicAttribute);

                    DynamicAttribute? NationalityDynamicAttributes = MainInformationDynamicAttribute
                        .FirstOrDefault(x => x.AttributeDataTypeId == 8 && x.EnglishLabel.ToLower() == "Nationality".ToLower());

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
                            IEnumerable<DynamicAttributeListValue> EnglishNationalitiesValues = FormattedResponse
                                .Select(x => new DynamicAttributeListValue()
                                {
                                    isDeleted = false,
                                    DeletedAt = null,
                                    CreatedAt = DateTime.UtcNow,
                                    CreatedBy = null,
                                    LastModifiedAt = null,
                                    LastModifiedBy = null,
                                    DynamicAttributeId = NationalityDynamicAttributes.Id,
                                    Value = x.EnglishName
                                });

                            await _DynamicAttributeListValueRepository.AddRangeAsync(EnglishNationalitiesValues);

                            IEnumerable<DynamicAttributeListValue> ArabicNationalitiesValues = FormattedResponse
                                .Select(x => new DynamicAttributeListValue()
                                {
                                    isDeleted = false,
                                    DeletedAt = null,
                                    CreatedAt = DateTime.UtcNow,
                                    CreatedBy = null,
                                    LastModifiedAt = null,
                                    LastModifiedBy = null,
                                    DynamicAttributeId = NationalityDynamicAttributes.Id,
                                    Value = x.ArabicName
                                });

                            await _DynamicAttributeListValueRepository.AddRangeAsync(ArabicNationalitiesValues);
                        }
                    }

                    DynamicAttribute? GenderDynamicAttributes = MainInformationDynamicAttribute
                        .FirstOrDefault(x => x.AttributeDataTypeId == 8 && x.EnglishLabel.ToLower() == "Gender".ToLower());

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
                                Value = "Male"
                            }, new DynamicAttributeListValue()
                            {
                                isDeleted = false,
                                DeletedAt = null,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = null,
                                LastModifiedAt = null,
                                LastModifiedBy = null,
                                DynamicAttributeId = GenderDynamicAttributes.Id,
                                Value = "Female"
                            }, new DynamicAttributeListValue()
                            {
                                isDeleted = false,
                                DeletedAt = null,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = null,
                                LastModifiedAt = null,
                                LastModifiedBy = null,
                                DynamicAttributeId = GenderDynamicAttributes.Id,
                                Value = "ذكر"
                            }, new DynamicAttributeListValue()
                            {
                                isDeleted = false,
                                DeletedAt = null,
                                CreatedAt = DateTime.UtcNow,
                                CreatedBy = null,
                                LastModifiedAt = null,
                                LastModifiedBy = null,
                                DynamicAttributeId = GenderDynamicAttributes.Id,
                                Value = "أنثى"
                            }
                        };

                        await _DynamicAttributeListValueRepository.AddRangeAsync(GendersValues);
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

                int TotalCount = await _DynamicAttributeSectionRepository.GetCountAsync(null);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<DynamicAttributeSectionListVM>>(ResponseMessage, true, 200, DynamicAttributeSections, PaginationParameter);
            }
            else if (Request.isArbitrator is not null)
            {
                string Language = !string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() : "ar";

                string ResponseMessage = string.Empty;

                List<DynamicAttributeSectionListVM> DynamicAttributeSections = new List<DynamicAttributeSectionListVM>();

                if (Request.page != 0 && Request.pageSize != -1)
                    DynamicAttributeSections = _DynamicAttributeSectionRepository
                        .IncludeThenWhere(x => x.AttributeTableName!,
                            x => Request.isArbitrator.Value
                                ? (x.AttributeTableName!.Name.ToLower() == TableNames.Arbitrator.ToString().ToLower() &&
                                    x.RecordIdOnRelation == -1)
                                : (x.AttributeTableName!.Name.ToLower() == TableNames.Coordinator.ToString().ToLower() &&
                                    x.RecordIdOnRelation == -2))
                        .OrderBy(x => x.OrderId)
                        .Skip((Request.page - 1) * Request.pageSize)
                        .Take(Request.pageSize)
                        .Select(x => new DynamicAttributeSectionListVM()
                        {
                            Id = x.Id,
                            Name = Language == "ar"
                                ? x.ArabicName
                                : x.EnglishName
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
                                : x.EnglishName
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

                int TotalCount = await _DynamicAttributeSectionRepository.GetCountAsync(null);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

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
