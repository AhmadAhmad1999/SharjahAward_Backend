using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
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

        public UpdateCategoryCommandHandler(IAsyncRepository<Category> categoryRepository, IMapper mapper, IFileService fileService,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository)
        {
            _categoryRepository = categoryRepository;
            _fileService = fileService;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _mapper = mapper;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryToUpdate = await _categoryRepository.GetByIdAsync(request.Id);
            string msg;
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
                    if ((request.RelatedToClasses != null && categoryToUpdate.RelatedToClasses != null)
                        ? request.RelatedToClasses!.Value && request.RelatedToClasses!.Value != categoryToUpdate.RelatedToClasses.Value
                        : false)
                    {
                        var LastOrderId = await _DynamicAttributeRepository
                            .Include(x => x.DynamicAttributeSection!)
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
                    }

                    _mapper.Map(request, categoryToUpdate, typeof(UpdateCategoryCommand), typeof(Category));

                    if (request.UpdateOnIcon)
                        categoryToUpdate.Icon = await _fileService.SaveFileAsync(request.Icon!);
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
                            .Include(x => x.EducationalClass!)
                            .ToListAsync();

                        if (DeleteCategoryEducationalClassEntites.Count() > 0)
                        {
                            await _CategoryEducationalClassRepository.DeleteListAsync(DeleteCategoryEducationalClassEntites);

                            List<DynamicAttributeListValue> DeleteClassesValues = await _DynamicAttributeListValueRepository
                                .Include(x => x.DynamicAttribute!)
                                .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
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
                                .Include(x => x.EducationalClass!)
                                .ToListAsync();

                            DynamicAttributeListValue? AlreadyInsertedClassesListValues = await _DynamicAttributeListValueRepository
                                .Include(x => x.DynamicAttribute!)
                                .Include(x => x.DynamicAttribute!.DynamicAttributeSection!)
                                .Where(x => x.DynamicAttribute!.DynamicAttributeSection!.RecordIdOnRelation == request.Id &&
                                    x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == 1 &&
                                    x.DynamicAttribute!.EnglishTitle.ToLower() == "Class".ToLower() &&
                                    x.DynamicAttribute!.ArabicTitle == "الصف")
                                .FirstOrDefaultAsync();

                            if (AlreadyInsertedClassesListValues is not null)
                            {
                                List<DynamicAttributeListValue> ArabicClasses = NewCategoryEducationalClassEntitiesWithInclude
                                    .Select(x => new DynamicAttributeListValue()
                                    {
                                        DynamicAttributeId = AlreadyInsertedClassesListValues.DynamicAttributeId,
                                        ArabicValue = x.EducationalClass!.ArabicName,
                                        EnglishValue = x.EducationalClass!.EnglishName
                                    }).ToList();

                                await _DynamicAttributeListValueRepository.AddRangeAsync(ArabicClasses);
                            }
                        }
                    }
                    else
                    {
                        DynamicAttribute? ClassDynamicAttribute = await _DynamicAttributeRepository
                            .Include(x => x.DynamicAttributeSection!)
                            .FirstOrDefaultAsync(x => x.DynamicAttributeSection!.RecordIdOnRelation == request.Id && 
                                x.EnglishTitle == "Class" && x.ArabicTitle == "الصف" &&
                                x.DynamicAttributeSection!.AttributeTableNameId == 1);

                        if (ClassDynamicAttribute is not null)
                        {
                            await _DynamicAttributeRepository.DeleteAsync(ClassDynamicAttribute);
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
