﻿using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Queries.GetAllDynamicAttributesBySectionId;
using SharijhaAward.Application.Helpers.Constants;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System.Text.Json;
using System.Net.Http;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;

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
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;
        private readonly IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository;
        private readonly IAsyncRepository<Role> _RoleRepository;

        public GetAllDynamicAttributeSectionsForViewHandler(IAsyncRepository<DynamicAttributeSection> DynamicAttributeSectionRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<Category> CategoryRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository,
            IAsyncRepository<Domain.Entities.EventModel.Event> _EventRepository,
            IAsyncRepository<Role> _RoleRepository)
        {
            _DynamicAttributeSectionRepository = DynamicAttributeSectionRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _CategoryRepository = CategoryRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
            this._EducationalInstitutionRepository = _EducationalInstitutionRepository;
            this._EventRepository = _EventRepository;
            this._RoleRepository = _RoleRepository;
        }
        public async Task<BaseResponse<List<DynamicAttributeSectionListVM>>> Handle(GetAllDynamicAttributeSectionsForViewQuery Request,
            CancellationToken cancellationToken)
        {
            if (Request.CategoryId is not null &&
                Request.CategoryId != 0)
            {
                string Language = !string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() : "ar";

                string ResponseMessage = string.Empty;

                Category? CategoryEntity = await _CategoryRepository
                    .IncludeThenFirstOrDefaultAsync(x => x.Parent!, x => x.Id == Request.CategoryId);

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

                if (Request.RoleId is null ||
                    Request.RoleId is 0)
                {
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

                        if (CategoryEntity.RelatedToEducationalEntities)
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
                                EnglishLabel = "Educational Institution",
                                EnglishTitle = "Educational Institution",
                                ArabicLabel = "المؤسسة التعليمية",
                                ArabicTitle = "المؤسسة التعليمية",
                                AttributeDataTypeId = 8,
                                IsRequired = true,
                                IsUnique = false,
                                LinkedToAnotherAttribute = false,
                                MaxSizeInKB = null,
                                Status = DynamicAttributeStatus.Active,
                                ArabicPlaceHolder = "المؤسسة التعليمية مرتبطة بالفئة",
                                EnglishPlaceHolder = "The educational institution is related to the category",
                                OrderId = 7
                            });

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
                                OrderId = 8
                            });
                        }

                        await _DynamicAttributeRepository.AddRangeAsync(MainInformationDynamicAttribute);

                        DynamicAttribute? NationalityDynamicAttributes = MainInformationDynamicAttribute
                            .FirstOrDefault(x => x.AttributeDataTypeId == 8 && x.EnglishTitle.ToLower() == "Nationality".ToLower());

                        // Fetch content from the URL
                        string json = await File.ReadAllTextAsync($"{Request.WWWRootFilePath}/Nationalities/Nationalities.json");

                        var Nationalities = JsonSerializer.Deserialize<List<NationalityResponse>>(json, new JsonSerializerOptions
                        {
                            PropertyNamingPolicy = JsonNamingPolicy.CamelCase // Matches JSON camelCase properties to PascalCase C# properties
                        });

                        if (NationalityDynamicAttributes is not null)
                        {
                            IEnumerable<DynamicAttributeListValue> NewNationalitiesValues = Nationalities!
                                .Select(x => new DynamicAttributeListValue()
                                {
                                    isDeleted = false,
                                    DeletedAt = null,
                                    CreatedAt = DateTime.UtcNow,
                                    CreatedBy = null,
                                    LastModifiedAt = null,
                                    LastModifiedBy = null,
                                    DynamicAttributeId = NationalityDynamicAttributes.Id,
                                    EnglishValue = x.Name.Common,
                                    ArabicValue = x.Translations.ara.common,
                                });

                            await _DynamicAttributeListValueRepository.AddRangeAsync(NewNationalitiesValues);
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

                        DynamicAttribute? EducationalInstitutionDynamicAttributes = MainInformationDynamicAttribute
                            .FirstOrDefault(x => x.AttributeDataTypeId == 8 && x.EnglishTitle.ToLower() == "Educational Institution".ToLower());

                        if (EducationalInstitutionDynamicAttributes is not null)
                        {
                            List<DynamicAttributeListValue> NewEducationalInstitutionsEntities = await _EducationalInstitutionRepository
                                .Where(x => CategoryEntity.CycleId == x.EducationalEntity!.CycleId)
                                .Select(x => new DynamicAttributeListValue()
                                {
                                    isDeleted = false,
                                    DeletedAt = null,
                                    CreatedAt = DateTime.UtcNow,
                                    CreatedBy = null,
                                    LastModifiedAt = null,
                                    LastModifiedBy = null,
                                    DynamicAttributeId = EducationalInstitutionDynamicAttributes.Id,
                                    ArabicValue = x.ArabicName,
                                    EnglishValue = x.EnglishName
                                }).ToListAsync();

                            await _DynamicAttributeListValueRepository.AddRangeAsync(NewEducationalInstitutionsEntities);
                        }

                        //DynamicAttribute? EducationalEntityDynamicAttributes = MainInformationDynamicAttribute
                        //    .FirstOrDefault(x => x.AttributeDataTypeId == 8 && x.EnglishTitle.ToLower() == "Educational Entity".ToLower());

                        //if (EducationalEntityDynamicAttributes is not null)
                        //{
                        //    List<DynamicAttributeListValue> NewEducationalEntities = await _EducationalEntityRepository
                        //        .Where(x => CategoryEntity.CycleId == x.CycleId)
                        //        .Select(x => new DynamicAttributeListValue()
                        //        {
                        //            isDeleted = false,
                        //            DeletedAt = null,
                        //            CreatedAt = DateTime.UtcNow,
                        //            CreatedBy = null,
                        //            LastModifiedAt = null,
                        //            LastModifiedBy = null,
                        //            DynamicAttributeId = EducationalEntityDynamicAttributes.Id,
                        //            ArabicValue = x.ArabicName,
                        //            EnglishValue = x.EnglishName
                        //        }).ToListAsync();

                        //    await _DynamicAttributeListValueRepository.AddRangeAsync(NewEducationalEntities);
                        //}
                    }
                    else
                    {
                        DynamicAttributeSectionListVM PersonalInformationSection = DynamicAttributeSections
                            .FirstOrDefault(x => x.Name.ToLower() == "Main Information".ToLower() ||
                                x.Name == "المعلومات الأساسية")!;

                        List<DynamicAttribute> MainInformationDynamicAttribute = new List<DynamicAttribute>();

                        DynamicAttribute? ClassDynamicAttributes = await _DynamicAttributeRepository
                            .FirstOrDefaultAsync(x => x.AttributeDataTypeId == 8 && x.EnglishTitle.ToLower() == "Class".ToLower() &&
                                x.DynamicAttributeSectionId == PersonalInformationSection.Id);

                        DynamicAttribute? EducationalEntityDynamicAttributes = await _DynamicAttributeRepository
                            .FirstOrDefaultAsync(x => x.AttributeDataTypeId == 8 &&
                                x.EnglishTitle.ToLower() == "Educational Entity".ToLower() &&
                                x.DynamicAttributeSectionId == PersonalInformationSection.Id);

                        DynamicAttribute? EducationalInstitutionDynamicAttributes = await _DynamicAttributeRepository
                            .FirstOrDefaultAsync(x => x.AttributeDataTypeId == 8 &&
                                x.EnglishTitle.ToLower() == "Educational Institution".ToLower() &&
                                x.DynamicAttributeSectionId == PersonalInformationSection.Id);

                        if ((CategoryEntity.RelatedToClasses is not null
                            ? CategoryEntity.RelatedToClasses.Value
                            : false) && ClassDynamicAttributes == null)
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

                        if (CategoryEntity.RelatedToEducationalEntities &&
                            EducationalInstitutionDynamicAttributes == null)
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
                                EnglishLabel = "Educational Institution",
                                EnglishTitle = "Educational Institution",
                                ArabicLabel = "المؤسسة التعليمية",
                                ArabicTitle = "المؤسسة التعليمية",
                                AttributeDataTypeId = 8,
                                IsRequired = true,
                                IsUnique = false,
                                LinkedToAnotherAttribute = false,
                                MaxSizeInKB = null,
                                Status = DynamicAttributeStatus.Active,
                                ArabicPlaceHolder = "المؤسسة التعليمية مرتبطة بالفئة",
                                EnglishPlaceHolder = "The educational institution is related to the category",
                                OrderId = 7
                            });

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
                                OrderId = 8
                            });
                        }

                        if (MainInformationDynamicAttribute.Any())
                            await _DynamicAttributeRepository.AddRangeAsync(MainInformationDynamicAttribute);

                        if (ClassDynamicAttributes is not null)
                        {
                            List<DynamicAttributeListValue> OldDynamicAttributeListValueEntities = await _DynamicAttributeListValueRepository
                                .Where(x => x.DynamicAttributeId == ClassDynamicAttributes.Id)
                                .ToListAsync();

                            IEnumerable<string> CombinedValues = OldDynamicAttributeListValueEntities
                                .Select(x => x.ArabicValue + x.EnglishValue);

                            List<CategoryEducationalClass> OldCategoryEducationalClassEntities = await _CategoryEducationalClassRepository
                                .Where(x => x.CategoryId == Request.CategoryId)
                                .ToListAsync();

                            IEnumerable<DynamicAttributeListValue> NewEducationalClasses = OldCategoryEducationalClassEntities
                                .Where(x => !CombinedValues.Contains(x.EducationalClass!.ArabicName + x.EducationalClass!.EnglishName))
                                .Select(x => new DynamicAttributeListValue()
                                {
                                    DynamicAttributeId = ClassDynamicAttributes.Id,
                                    ArabicValue = x.EducationalClass!.ArabicName,
                                    EnglishValue = x.EducationalClass!.EnglishName
                                }).ToList();

                            IEnumerable<DynamicAttributeListValue> DeletedEducationalClasses = OldDynamicAttributeListValueEntities
                                .Where(x => !OldCategoryEducationalClassEntities
                                    .Select(y => y.EducationalClass!.ArabicName + y.EducationalClass!.EnglishName)
                                    .Contains(x.ArabicValue + x.EnglishValue));

                            await _DynamicAttributeListValueRepository.DeleteListAsync(DeletedEducationalClasses);
                            await _DynamicAttributeListValueRepository.AddRangeAsync(NewEducationalClasses);
                        }

                        if (EducationalInstitutionDynamicAttributes is not null &&
                            CategoryEntity.RelatedToEducationalEntities)
                        {
                            List<DynamicAttributeListValue> OldDynamicAttributeListValueEntities = await _DynamicAttributeListValueRepository
                                .Where(x => x.DynamicAttributeId == EducationalInstitutionDynamicAttributes.Id)
                                .ToListAsync();

                            IEnumerable<string> CombinedValues = OldDynamicAttributeListValueEntities
                                .Select(x => x.ArabicValue + x.EnglishValue);

                            List<EducationalInstitution> OldEducationalInstitutionEntities = await _EducationalInstitutionRepository
                                .Where(x => x.EducationalEntity!.CycleId == CategoryEntity.CycleId)
                                .ToListAsync();

                            List<DynamicAttributeListValue> NewEducationalInstitutionEntities = OldEducationalInstitutionEntities
                                .Where(x => !CombinedValues.Contains(x.ArabicName + x.EnglishName))
                                .Select(x => new DynamicAttributeListValue()
                                {
                                    DynamicAttributeId = EducationalInstitutionDynamicAttributes.Id,
                                    ArabicValue = x.ArabicName,
                                    EnglishValue = x.EnglishName
                                }).ToList();

                            IEnumerable<DynamicAttributeListValue> DeletedEducationalInstitutionEntities = OldDynamicAttributeListValueEntities
                                .Where(x => !OldEducationalInstitutionEntities
                                    .Select(y => y.ArabicName + y.EnglishName)
                                    .Contains(x.ArabicValue + x.EnglishValue));

                            await _DynamicAttributeListValueRepository.DeleteListAsync(DeletedEducationalInstitutionEntities);
                            await _DynamicAttributeListValueRepository.AddRangeAsync(NewEducationalInstitutionEntities);
                        }
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

                if (Request.RoleId is null ||
                    Request.RoleId is 0)
                {
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
                }

                int TotalCount = await _DynamicAttributeSectionRepository.GetCountAsync(x => x.RecordIdOnRelation == Request.CategoryId &&
                    x.AttributeTableName!.Name.ToLower() == TableNames.ProvidedForm.ToString().ToLower());

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<DynamicAttributeSectionListVM>>(ResponseMessage, true, 200, DynamicAttributeSections, PaginationParameter);
            }
            else if (Request.EventId is not null &&
                Request.EventId != 0)
            {
                string Language = !string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() : "ar";

                string ResponseMessage = string.Empty;

                Domain.Entities.EventModel.Event? EventEntity = await _EventRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.EventId);

                if (EventEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Event is not found"
                        : "الفعالية غير موجودة";

                    return new BaseResponse<List<DynamicAttributeSectionListVM>>(ResponseMessage, false, 404);
                }

                List<DynamicAttributeSectionListVM> DynamicAttributeSections = new List<DynamicAttributeSectionListVM>();

                if (Request.page != 0 && Request.perPage != -1)
                    DynamicAttributeSections = await _DynamicAttributeSectionRepository
                        .IncludeThenWhere(x => x.AttributeTableName!,
                            x => x.RecordIdOnRelation == Request.EventId &&
                            x.AttributeTableName!.Name.ToLower() == TableNames.Event.ToString().ToLower() &&
                            x.InviteeType == Request.InviteeType)
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
                            x => x.RecordIdOnRelation == Request.EventId &&
                            x.AttributeTableNameId == 4 &&
                            x.InviteeType == Request.InviteeType)
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
                        AttributeTableNameId = 4,
                        RecordIdOnRelation = Request.EventId,
                        TableTypeSection = false,
                        InviteeType = Request.InviteeType
                    };

                    await _DynamicAttributeSectionRepository.AddAsync(PersonalInformationSection);

                    DynamicAttributeSections.Add(new DynamicAttributeSectionListVM()
                    {
                        Id = PersonalInformationSection.Id,
                        Name = Language == "en"
                            ? PersonalInformationSection.EnglishName
                            : PersonalInformationSection.ArabicName
                    });

                    if (Request.InviteeType == Domain.Constants.InviteeTypes.Personal)
                    {
                        DynamicAttribute MainInformationDynamicAttribute = new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = PersonalInformationSection.Id,
                            EnglishLabel = "Email",
                            EnglishTitle = "Email",
                            ArabicLabel = "البريد الالكتروني",
                            ArabicTitle = "البريد الالكتروني",
                            AttributeDataTypeId = 1,
                            IsRequired = true,
                            IsUnique = false,
                            LinkedToAnotherAttribute = false,
                            MaxSizeInKB = null,
                            Status = DynamicAttributeStatus.Active,
                            ArabicPlaceHolder = "البريد الالكتروني",
                            EnglishPlaceHolder = "Email",
                            OrderId = 1
                        };

                        await _DynamicAttributeRepository.AddAsync(MainInformationDynamicAttribute);
                    }
                    else if (Request.InviteeType == Domain.Constants.InviteeTypes.Group)
                    {
                        DynamicAttribute MainInformationDynamicAttribute = new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = PersonalInformationSection.Id,
                            EnglishLabel = "Email (Student Supervisor)",
                            EnglishTitle = "Email (Student Supervisor)",
                            ArabicLabel = "البريد الالكتروني (المشرف على الطلبة)",
                            ArabicTitle = "البريد الالكتروني (المشرف على الطلبة)",
                            AttributeDataTypeId = 1,
                            IsRequired = true,
                            IsUnique = false,
                            LinkedToAnotherAttribute = false,
                            MaxSizeInKB = null,
                            Status = DynamicAttributeStatus.Active,
                            ArabicPlaceHolder = "البريد الالكتروني (المشرف على الطلبة)",
                            EnglishPlaceHolder = "Email (Student Supervisor)",
                            OrderId = 1
                        };

                        await _DynamicAttributeRepository.AddAsync(MainInformationDynamicAttribute);
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

                int TotalCount = await _DynamicAttributeSectionRepository.GetCountAsync(x => x.RecordIdOnRelation == Request.EventId &&
                    x.AttributeTableName!.Name.ToLower() == TableNames.Event.ToString().ToLower());

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.perPage, TotalCount);

                return new BaseResponse<List<DynamicAttributeSectionListVM>>(ResponseMessage, true, 200, DynamicAttributeSections, PaginationParameter);
            }
            else if (Request.RoleId is not null &&
                Request.RoleId != 0)
            {
                string Language = !string.IsNullOrEmpty(Request.lang)
                    ? Request.lang.ToLower() : "ar";

                string ResponseMessage = string.Empty;

                Role? RoleEntity = await _RoleRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.RoleId);

                if (RoleEntity is null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Role is not found"
                        : "الدور غير موجود";

                    return new BaseResponse<List<DynamicAttributeSectionListVM>>(ResponseMessage, false, 404);
                }

                List<DynamicAttributeSectionListVM> DynamicAttributeSections = new List<DynamicAttributeSectionListVM>();

                if (Request.page != 0 && Request.perPage != -1)
                    DynamicAttributeSections = await _DynamicAttributeSectionRepository
                        .IncludeThenWhere(x => x.AttributeTableName!,
                            x => x.RecordIdOnRelation == Request.RoleId &&
                            x.AttributeTableName!.Name.ToLower() == TableNames.Roles.ToString().ToLower())
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
                            x => x.RecordIdOnRelation == Request.RoleId &&
                            x.AttributeTableNameId == 5)
                        .OrderBy(x => x.OrderId)
                        .Select(x => new DynamicAttributeSectionListVM()
                        {
                            Id = x.Id,
                            Name = Language == "ar"
                                ? x.ArabicName
                                : x.EnglishName,
                            TableTypeSection = x.TableTypeSection
                        }).ToListAsync();

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

                int TotalCount = await _DynamicAttributeSectionRepository.GetCountAsync(x => x.RecordIdOnRelation == Request.RoleId &&
                    x.AttributeTableName!.Name.ToLower() == TableNames.Roles.ToString().ToLower());

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
