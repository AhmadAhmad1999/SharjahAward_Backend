using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.Categories.Command.UpdateCategory
{
    public class UpdateCategoryCommandHandler
        : IRequestHandler<UpdateCategoryCommand , BaseResponse<object>>
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<CategoryEducationalEntity> _CategoryEducationalEntityRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;

        public UpdateCategoryCommandHandler(IAsyncRepository<Category> categoryRepository, IMapper mapper, IFileService fileService,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IAsyncRepository<CategoryEducationalEntity> CategoryEducationalEntityRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository)
        {
            _categoryRepository = categoryRepository;
            _fileService = fileService;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _mapper = mapper;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _CategoryEducationalEntityRepository = CategoryEducationalEntityRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryToUpdate = await _categoryRepository.GetByIdAsync(request.Id);
            string msg;

            if (request.RelatedToClasses == null && (request.EducationalClasses != null ? request.EducationalClasses.Any() : false))
            {
                msg = request.lang == "en"
                    ? "If you select the \"is related to classes\" flag's value as \"null\" then " +
                        "you can't select classes for this category"
                    : "إذا قمت بتحديد قيمة المعلومة \"مرتبط بالصفوف\" على أنها \"بدون قيمة\" فلن تتمكن من تحديد الصفوف لهذه الفئة";

                return new BaseResponse<object>(msg, false, 400);
            }
            else if ((request.RelatedToClasses != null ? request.RelatedToClasses.Value : false) &&
                (request.EducationalClasses == null ? true : !request.EducationalClasses.Any()))
            {
                msg = request.lang == "en"
                    ? "If you select the \"is related to classes\" flag's value as \"true\" then " +
                        "you have to select classes for this category"
                    : "إذا قمت بتحديد قيمة المعلومة \"مرتبط بالصفوف\" على أنها \"صحيح\"، فيجب عليك تحديد الصفوف لهذه الفئة";

                return new BaseResponse<object>(msg, false, 400);
            }
            else if ((request.RelatedToClasses != null ? !request.RelatedToClasses.Value : false) &&
                    (request.EducationalClasses != null ? request.EducationalClasses.Any() : false))
            {
                msg = request.lang == "en"
                    ? "If you select the \"is related to classes\" flag's value as \"false\" then " +
                        "you can't select classes for this category"
                    : "إذا قمت بتحديد قيمة المعلومة \"مرتبط بالصفوف\" على أنها \"خطأ\"، فلن تتمكن من تحديد الصفوف لهذه الفئة";

                return new BaseResponse<object>(msg, false, 400);
            }

            if (categoryToUpdate == null)
            {
                msg = request.lang == "en"
                    ? "Category not found"
                    : "الفئة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }
            var categoryIcon = categoryToUpdate.Icon;

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    DynamicAttribute? ClassDynamicAttribute = await _DynamicAttributeRepository
                        .FirstOrDefaultAsync(x => x.DynamicAttributeSection!.RecordIdOnRelation == request.Id &&
                            x.EnglishTitle == "Class" && x.ArabicTitle == "الصف" &&
                            x.DynamicAttributeSection!.AttributeTableNameId == 1);

                    int? ClassDynamicAttributeId = null;

                    if (request.RelatedToClasses != null
                            ? (categoryToUpdate.RelatedToClasses != null
                                ? (request.RelatedToClasses.Value && !categoryToUpdate.RelatedToClasses.Value)
                                : (request.RelatedToClasses.Value))
                            : false)
                    {
                        var LastOrderId = await _DynamicAttributeRepository
                            .Where(x => x.DynamicAttributeSection!.RecordIdOnRelation == request.Id &&
                                x.DynamicAttributeSection.EnglishName == "Main Information")
                            .OrderBy(x => x.OrderId)
                            .LastOrDefaultAsync();

                        DynamicAttribute DynamicAttribute = new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = LastOrderId!.DynamicAttributeSectionId,
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
                            OrderId = LastOrderId!.OrderId
                        };

                        await _DynamicAttributeRepository.AddAsync(DynamicAttribute);

                        ClassDynamicAttributeId = DynamicAttribute.Id;
                    }
                    else if ((request.RelatedToClasses != null && categoryToUpdate.RelatedToClasses != null)
                        ? (!request.RelatedToClasses.Value && categoryToUpdate.RelatedToClasses.Value)
                        : false)
                    {
                        if (ClassDynamicAttribute is not null)
                        {
                            await _DynamicAttributeRepository.DeleteAsync(ClassDynamicAttribute);
                        }
                    }

                    DynamicAttribute? EducationalEntityDynamicAttribute = await _DynamicAttributeRepository
                        .FirstOrDefaultAsync(x => x.DynamicAttributeSection!.RecordIdOnRelation == request.Id &&
                            x.EnglishTitle == "Educational Entity" && x.ArabicTitle == "الجهة التعليمية" &&
                            x.DynamicAttributeSection!.AttributeTableNameId == 1);

                    int? EducationalEntityDynamicAttributeId = null;

                    if (request.RelatedToEducationalEntities != null
                        ? (request.RelatedToEducationalEntities.Value && !categoryToUpdate.RelatedToEducationalEntities)
                        : false)
                    {
                        var LastOrderId = await _DynamicAttributeRepository
                            .Where(x => x.DynamicAttributeSection!.RecordIdOnRelation == request.Id &&
                                x.DynamicAttributeSection.EnglishName == "Main Information")
                            .OrderBy(x => x.OrderId)
                            .LastOrDefaultAsync();

                        DynamicAttribute DynamicAttribute = new DynamicAttribute()
                        {
                            isDeleted = false,
                            DeletedAt = null,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            DynamicAttributeSectionId = LastOrderId!.DynamicAttributeSectionId,
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
                            OrderId = LastOrderId!.OrderId
                        };

                        await _DynamicAttributeRepository.AddAsync(DynamicAttribute);

                        EducationalEntityDynamicAttributeId = DynamicAttribute.Id;
                    }
                    else if ((request.RelatedToEducationalEntities != null)
                        ? (!request.RelatedToEducationalEntities.Value && categoryToUpdate.RelatedToEducationalEntities)
                        : false)
                    {
                        if (EducationalEntityDynamicAttribute is not null)
                        {
                            await _DynamicAttributeRepository.DeleteAsync(EducationalEntityDynamicAttribute);
                        }
                    }

                    _mapper.Map(request, categoryToUpdate, typeof(UpdateCategoryCommand), typeof(Category));

                    if (request.UpdateOnIcon)
                        categoryToUpdate.Icon = await _fileService.SaveFileAsync(request.Icon!, SystemFileType.Icons);
                    else
                        categoryToUpdate.Icon = categoryIcon;

                    await _categoryRepository.UpdateAsync(categoryToUpdate);

                    if (request.EducationalClasses is not null)
                    {
                        List<int> AlreadyExistEducationalClassIds = await _CategoryEducationalClassRepository
                            .Where(x => x.CategoryId == request.Id)
                            .Select(x => x.EducationalClassId)
                            .ToListAsync();

                        List<int> IntersectEducationalClassIds = AlreadyExistEducationalClassIds
                            .Intersect(request.EducationalClasses!.Select(y => y.EducationalClassId)).ToList();
                        
                        List<int> DeleteEducationalClassIds = AlreadyExistEducationalClassIds
                            .Where(x => !IntersectEducationalClassIds.Contains(x))
                            .ToList();

                        List<CategoryEducationalClass> DeleteCategoryEducationalClassEntites = await _CategoryEducationalClassRepository
                            .Where(x => x.CategoryId == request.Id &&
                                DeleteEducationalClassIds.Contains(x.EducationalClassId))
                            .ToListAsync();

                        if (DeleteCategoryEducationalClassEntites.Count() > 0)
                        {
                            await _CategoryEducationalClassRepository.DeleteListAsync(DeleteCategoryEducationalClassEntites);

                            List<DynamicAttributeListValue> DeleteClassesValues = await _DynamicAttributeListValueRepository
                                .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == request.Id &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Class".ToLower() &&
                                    x.DynamicAttribute!.ArabicTitle == "الصف" &&
                                    (DeleteCategoryEducationalClassEntites.Select(y => y.EducationalClass!.EnglishName).Contains(x.EnglishValue) ||
                                    DeleteCategoryEducationalClassEntites.Select(y => y.EducationalClass!.ArabicName).Contains(x.ArabicValue)))
                                .ToListAsync();

                            if (DeleteClassesValues.Any())
                                await _DynamicAttributeListValueRepository.DeleteListAsync(DeleteClassesValues);
                        }

                        List<CategoryEducationalClass> NewCategoryEducationalClassEntities = request.EducationalClasses
                            .Where(x => !IntersectEducationalClassIds.Contains(x.EducationalClassId))
                            .Select(x => new CategoryEducationalClass()
                            {
                                CategoryId = request.Id,
                                EducationalClassId = x.EducationalClassId,
                                NumberOfExpectedWinners = x.NumberOfExpectedWinners
                            }).ToList();

                        if (NewCategoryEducationalClassEntities.Count() > 0)
                        {
                            await _CategoryEducationalClassRepository.AddRangeAsync(NewCategoryEducationalClassEntities);

                            List<CategoryEducationalClass> NewCategoryEducationalClassEntitiesWithInclude = await _CategoryEducationalClassRepository
                                .Where(x => NewCategoryEducationalClassEntities.Select(y => y.EducationalClassId).Contains(x.EducationalClassId) &&
                                    NewCategoryEducationalClassEntities.Select(y => y.CategoryId).Contains(x.CategoryId))
                                .ToListAsync();

                            if (ClassDynamicAttributeId is not null)
                            {
                                List<DynamicAttributeListValue> ArabicClasses = NewCategoryEducationalClassEntitiesWithInclude
                                    .Select(x => new DynamicAttributeListValue()
                                    {
                                        DynamicAttributeId = ClassDynamicAttributeId!.Value,
                                        ArabicValue = x.EducationalClass!.ArabicName,
                                        EnglishValue = x.EducationalClass!.EnglishName
                                    }).ToList();

                                await _DynamicAttributeListValueRepository.AddRangeAsync(ArabicClasses);
                            }
                        }
                    }
                    else
                    {
                        List<CategoryEducationalClass> DeleteCategoryEducationalClassEntites = await _CategoryEducationalClassRepository
                            .Where(x => x.CategoryId == request.Id)
                            .ToListAsync();

                        if (DeleteCategoryEducationalClassEntites.Count() > 0)
                        {
                            await _CategoryEducationalClassRepository.DeleteListAsync(DeleteCategoryEducationalClassEntites);

                            List<DynamicAttributeListValue> DeleteClassesValues = await _DynamicAttributeListValueRepository
                                .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == request.Id &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Class".ToLower() &&
                                    x.DynamicAttribute!.ArabicTitle == "الصف" &&
                                    (DeleteCategoryEducationalClassEntites.Select(y => y.EducationalClass!.EnglishName).Contains(x.EnglishValue) ||
                                    DeleteCategoryEducationalClassEntites.Select(y => y.EducationalClass!.ArabicName).Contains(x.ArabicValue)))
                                .ToListAsync();

                            if (DeleteClassesValues.Any())
                                await _DynamicAttributeListValueRepository.DeleteListAsync(DeleteClassesValues);
                        }
                    }

                    if (request.RelatedToEducationalEntities is not null &&
                        request.RelatedToEducationalEntities.Value)
                    {
                        List<int> EducationalEntityEntitiesIds = await _EducationalEntityRepository
                            .Where(x => true)
                            .Select(x => x.Id)
                            .ToListAsync();

                        List<int> AlreadyExistEducationalEntityIds = await _CategoryEducationalEntityRepository
                            .Where(x => x.CategoryId == request.Id)
                            .Select(x => x.EducationalEntityId)
                            .ToListAsync();

                        List<int> IntersectEducationalEntityIds = AlreadyExistEducationalEntityIds
                            .Intersect(EducationalEntityEntitiesIds).ToList();

                        List<int> DeleteEducationalEntityIds = AlreadyExistEducationalEntityIds
                            .Where(x => !IntersectEducationalEntityIds.Contains(x))
                            .ToList();

                        List<CategoryEducationalEntity> DeleteCategoryEducationalEntityEntites = await _CategoryEducationalEntityRepository
                            .Where(x => x.CategoryId == request.Id &&
                                DeleteEducationalEntityIds.Contains(x.EducationalEntityId))
                            .ToListAsync();

                        if (DeleteCategoryEducationalEntityEntites.Count() > 0)
                        {
                            await _CategoryEducationalEntityRepository.DeleteListAsync(DeleteCategoryEducationalEntityEntites);

                            List<DynamicAttributeListValue> DeleteEntityesValues = await _DynamicAttributeListValueRepository
                                .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == request.Id &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Educational Entity".ToLower() &&
                                    x.DynamicAttribute!.ArabicTitle == "الجهة التعليمية" &&
                                    (DeleteCategoryEducationalEntityEntites.Select(y => y.EducationalEntity!.EnglishName).Contains(x.EnglishValue) ||
                                    DeleteCategoryEducationalEntityEntites.Select(y => y.EducationalEntity!.ArabicName).Contains(x.ArabicValue)))
                                .ToListAsync();

                            if (DeleteEntityesValues.Any())
                                await _DynamicAttributeListValueRepository.DeleteListAsync(DeleteEntityesValues);
                        }

                        List<CategoryEducationalEntity> NewCategoryEducationalEntityEntities = EducationalEntityEntitiesIds
                            .Where(x => !IntersectEducationalEntityIds.Contains(x))
                            .Select(x => new CategoryEducationalEntity()
                            {
                                CategoryId = request.Id,
                                EducationalEntityId = x
                            }).ToList();

                        if (NewCategoryEducationalEntityEntities.Count() > 0)
                        {
                            await _CategoryEducationalEntityRepository.AddRangeAsync(NewCategoryEducationalEntityEntities);

                            List<CategoryEducationalEntity> NewCategoryEducationalEntityEntitiesWithInclude = await _CategoryEducationalEntityRepository
                                .Where(x => NewCategoryEducationalEntityEntities.Select(y => y.EducationalEntityId).Contains(x.EducationalEntityId) &&
                                    NewCategoryEducationalEntityEntities.Select(y => y.CategoryId).Contains(x.CategoryId))
                                .ToListAsync();

                            if (EducationalEntityDynamicAttributeId is not null)
                            {
                                List<DynamicAttributeListValue> ArabicEntityes = NewCategoryEducationalEntityEntitiesWithInclude
                                    .Select(x => new DynamicAttributeListValue()
                                    {
                                        DynamicAttributeId = EducationalEntityDynamicAttributeId!.Value,
                                        ArabicValue = x.EducationalEntity!.ArabicName,
                                        EnglishValue = x.EducationalEntity!.EnglishName
                                    }).ToList();

                                await _DynamicAttributeListValueRepository.AddRangeAsync(ArabicEntityes);
                            }
                        }
                    }
                    else
                    {
                        List<CategoryEducationalEntity> DeleteCategoryEducationalEntityEntites = await _CategoryEducationalEntityRepository
                            .Where(x => x.CategoryId == request.Id)
                            .ToListAsync();

                        if (DeleteCategoryEducationalEntityEntites.Count() > 0)
                        {
                            await _CategoryEducationalEntityRepository.DeleteListAsync(DeleteCategoryEducationalEntityEntites);

                            List<DynamicAttributeListValue> DeleteEntityesValues = await _DynamicAttributeListValueRepository
                                .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == request.Id &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Educational Entity".ToLower() &&
                                    x.DynamicAttribute!.ArabicTitle == "الجهة التعليمية" &&
                                    (DeleteCategoryEducationalEntityEntites.Select(y => y.EducationalEntity!.EnglishName).Contains(x.EnglishValue) ||
                                    DeleteCategoryEducationalEntityEntites.Select(y => y.EducationalEntity!.ArabicName).Contains(x.ArabicValue)))
                                .ToListAsync();

                            if (DeleteEntityesValues.Any())
                                await _DynamicAttributeListValueRepository.DeleteListAsync(DeleteEntityesValues);
                        }
                    }

                    msg = request.lang == "en"
                        ? "The Category has been Updated"
                        : "تم تعديل الفئة بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(msg, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
