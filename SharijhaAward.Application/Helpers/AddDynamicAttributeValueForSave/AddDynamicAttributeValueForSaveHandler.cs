using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System.Transactions;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValueForSave
{
    public class AddDynamicAttributeValueForSaveHandler : IRequestHandler<AddDynamicAttributeValueForSaveCommand,
        BaseResponse<AddDynamicAttributeValueForSaveResponse>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<CategoryEducationalEntity> _CategoryEducationalEntityRepository;

        public AddDynamicAttributeValueForSaveHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IHttpContextAccessor HttpContextAccessor,
            IAsyncRepository<ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<EducationalClass> EducationalClassRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<CategoryEducationalEntity> CategoryEducationalEntityRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            _HttpContextAccessor = HttpContextAccessor;
            _ProvidedFormRepository = ProvidedFormRepository;
            _EducationalClassRepository = EducationalClassRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
            _CategoryEducationalEntityRepository = CategoryEducationalEntityRepository;
        }

        public async Task<BaseResponse<AddDynamicAttributeValueForSaveResponse>> Handle(AddDynamicAttributeValueForSaveCommand Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<DynamicAttribute> DynamicAttributeEntities = await _DynamicAttributeRepository
                .Where(x => Request.DynamicAttributesWithValues.Select(y => y.DynamicAttributeId).Contains(x.Id) ||
                    Request.DynamicAttributesWithTableValues.Select(y => y.DynamicAttributeId).Contains(x.Id))
                .Include(x => x.DynamicAttributeSection!)
                .ToListAsync();

            //int DynamicAttributeEntitiesCount = DynamicAttributeEntities.Count();

            //if (DynamicAttributeEntitiesCount != Request.DynamicAttributesWithValues.Count() + 
            //        Request.DynamicAttributesWithTableValues.Count())
            //{
            //    ResponseMessage = Request.lang == "en"
            //        ? "Field is not found"
            //        : "الحقل غير موجود";

            //    return new BaseResponse<AddDynamicAttributeValueForSaveResponse>(ResponseMessage, false, 404);
            //}

            List<DynamicAttributeSection> AllDynamicAttributeSections = DynamicAttributeEntities
                .Select(x => x.DynamicAttributeSection!)
                .ToList();

            foreach (DynamicAttributeSection DynamicAttributeSection in AllDynamicAttributeSections)
            {
                List<DynamicAttribute> DynamicAttributesInThisDynamicAttributeSection = DynamicAttributeEntities
                    .Where(x => x.DynamicAttributeSectionId == DynamicAttributeSection.Id)
                    .ToList();

                int NumberOfInputedRows = Request.DynamicAttributesWithTableValues
                    .Where(x => DynamicAttributesInThisDynamicAttributeSection.Select(y => y.Id).Contains(x.DynamicAttributeId))
                    .DistinctBy(x => x.RowId)
                    .Count();

                if (DynamicAttributeSection.MaxNumberOfRows != null
                    ? (DynamicAttributeSection.MaxNumberOfRows != 0 &&
                       DynamicAttributeSection.MaxNumberOfRows < NumberOfInputedRows)
                    : false)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"You can't enter more than {DynamicAttributeSection.MaxNumberOfRows} rows in the " +
                            $"{DynamicAttributeSection.EnglishName} section"
                        : $"لا يمكنك إدخال عدد سطور أكثر من {DynamicAttributeSection.MaxNumberOfRows} في قسم ال{DynamicAttributeSection.ArabicName}";

                    return new BaseResponse<AddDynamicAttributeValueForSaveResponse>(ResponseMessage, false, 400);
                }
            }

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    List<DynamicAttributeValue> CheckForUpdateValues = await _DynamicAttributeValueRepository
                        .Where(x => x.RecordId == Request.RecordId).ToListAsync();

                    if (CheckForUpdateValues.Count() > 0)
                        await _DynamicAttributeValueRepository.RemoveListAsync(CheckForUpdateValues);

                    List<AddDynamicAttributeValueForSaveMainCommand> DynamicAttributesAsFile = Request.DynamicAttributesWithValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddDynamicAttributeValueForSaveMainCommand DynamicAttributeAsFile in DynamicAttributesAsFile)
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string FolderPath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DynamicFiles"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DynamicFiles";

                        string? FileName = $"{Request.RecordId}-{DynamicAttributeAsFile.ValueAsBinaryFile!.FileName}";

                        string? FilePathToSaveIntoDataBase = Path.Combine(FolderPath, FileName);

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = Path.Combine(FolderPathToCreate, FileName);

                        while (File.Exists(FilePathToSaveIntoDataBase))
                        {
                            FilePathToSaveIntoDataBase = FilePathToSaveIntoDataBase + "x";
                            FilePathToSaveToCreate = FilePathToSaveToCreate + "x";
                        }

                        using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                        {
                            DynamicAttributeAsFile.ValueAsBinaryFile.CopyTo(FileStream);
                        }

                        DynamicAttributeAsFile.ValueAsBinaryFile = null;
                        DynamicAttributeAsFile.ValueAsString = FilePathToSaveIntoDataBase;
                    }

                    List<DynamicAttributeValue> DynamicAttributeValuesEntities = Request.DynamicAttributesWithValues
                        .Where(x => !string.IsNullOrEmpty(x.ValueAsString))
                        .Select(x => new DynamicAttributeValue()
                        {
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            DynamicAttributeId = x.DynamicAttributeId,
                            isDeleted = false,
                            RecordId = Request.RecordId,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            Value = x.ValueAsString!,
                            isAccepted = CheckForUpdateValues.FirstOrDefault(y => y.DynamicAttributeId == x.DynamicAttributeId)
                                ? .isAccepted ?? null,
                            ReasonForRejecting = CheckForUpdateValues.FirstOrDefault(y => y.DynamicAttributeId == x.DynamicAttributeId)
                                ?.ReasonForRejecting ?? null
                        }).ToList();

                    await _DynamicAttributeValueRepository.AddRangeAsync(DynamicAttributeValuesEntities);

                    List<DynamicAttributeTableValue> DynamicAttributeTableValueEnititiesToDelete = await _DynamicAttributeTableValueRepository
                        .Where(x => x.RecordId == Request.RecordId)
                        .ToListAsync();

                    if (DynamicAttributeTableValueEnititiesToDelete.Any())
                        await _DynamicAttributeTableValueRepository.RemoveListAsync(DynamicAttributeTableValueEnititiesToDelete);

                    List<AddDynamicAttributeTableValueForSaveMainCommand> DynamicAttributesTableValueAsFile = Request.DynamicAttributesWithTableValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddDynamicAttributeTableValueForSaveMainCommand DynamicAttributeAsFile in DynamicAttributesTableValueAsFile)
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string FolderPath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DynamicFiles"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DynamicFiles";

                        string? FileName = $"{Request.RecordId}-{DynamicAttributeAsFile.ValueAsBinaryFile!.FileName}";

                        string? FilePathToSaveIntoDataBase = Path.Combine(FolderPath, FileName);

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = Path.Combine(FolderPathToCreate, FileName);

                        while (File.Exists(FilePathToSaveIntoDataBase))
                        {
                            FilePathToSaveIntoDataBase = FilePathToSaveIntoDataBase + "x";
                            FilePathToSaveToCreate = FilePathToSaveToCreate + "x";
                        }

                        using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                        {
                            DynamicAttributeAsFile.ValueAsBinaryFile.CopyTo(FileStream);
                        }

                        DynamicAttributeAsFile.ValueAsBinaryFile = null;
                        DynamicAttributeAsFile.ValueAsString = FilePathToSaveIntoDataBase;
                    }

                    List<DynamicAttributeTableValue> DynamicAttributeTableValueEntitiesToAdd = Request.DynamicAttributesWithTableValues
                        .Where(x => !string.IsNullOrEmpty(x.ValueAsString))
                        .Select(x => new DynamicAttributeTableValue()
                        {
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            DynamicAttributeId = x.DynamicAttributeId,
                            isDeleted = false,
                            RecordId = Request.RecordId,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            Value = x.ValueAsString!,
                            RowId = x.RowId,
                            isAccepted = DynamicAttributeTableValueEnititiesToDelete
                                .FirstOrDefault(y => y.DynamicAttributeId == x.DynamicAttributeId) ? .isAccepted ?? null,
                            ReasonForRejecting = DynamicAttributeTableValueEnititiesToDelete
                                .FirstOrDefault(y => y.DynamicAttributeId == x.DynamicAttributeId)?.ReasonForRejecting ?? null
                        }).ToList();

                    await _DynamicAttributeTableValueRepository.AddRangeAsync(DynamicAttributeTableValueEntitiesToAdd);

                    if (Request.DynamicAttributesWithValues.Any())
                    {
                        DynamicAttribute? CheckIfThereisClassAttribute = await _DynamicAttributeRepository
                            .Include(x => x.DynamicAttributeSection!)
                            .Include(x => x.DynamicAttributeSection!.AttributeTableName!)
                            .FirstOrDefaultAsync(x => x.Id == Request.DynamicAttributesWithValues[0].DynamicAttributeId);

                        if (CheckIfThereisClassAttribute is not null)
                        {
                            if (CheckIfThereisClassAttribute.DynamicAttributeSection!.AttributeTableName!.Name.ToLower() == "ProvidedForm".ToLower())
                            {
                                ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                                    .FirstOrDefaultAsync(x => x.Id == Request.RecordId);

                                if (ProvidedFormEntity is null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? "Form is not found"
                                        : "الاستمارة غير موجودة";

                                    return new BaseResponse<AddDynamicAttributeValueForSaveResponse>(ResponseMessage, false, 404);
                                }

                                DynamicAttribute? ClassDynamicAttribute = await _DynamicAttributeRepository
                                    .FirstOrDefaultAsync(x => Request.DynamicAttributesWithValues.Select(y => y.DynamicAttributeId)
                                        .Contains(x.Id) && x.EnglishTitle.ToLower() == "Class".ToLower());

                                if (ClassDynamicAttribute is not null)
                                {
                                    string? StringValueForClass = Request.DynamicAttributesWithValues.FirstOrDefault(x => x.DynamicAttributeId == ClassDynamicAttribute.Id)!
                                        .ValueAsString;

                                    EducationalClass? Classes = await _EducationalClassRepository
                                        .FirstOrDefaultAsync(x => Request.lang == "en"
                                            ? x.EnglishName.ToLower() == StringValueForClass!.ToLower()
                                            : x.ArabicName.ToLower() == StringValueForClass!.ToLower());

                                    if (Classes is not null)
                                    {
                                        CategoryEducationalClass NewCategoryEducationalClassEntity = new CategoryEducationalClass()
                                        {
                                            CategoryId = ProvidedFormEntity!.categoryId,
                                            EducationalClassId = Classes.Id
                                        };

                                        await _CategoryEducationalClassRepository.AddAsync(NewCategoryEducationalClassEntity);

                                        ProvidedFormEntity.CategoryEducationalClassId = NewCategoryEducationalClassEntity.Id;
                                    }
                                }

                                DynamicAttribute? EducationalEntityDynamicAttribute = await _DynamicAttributeRepository
                                    .FirstOrDefaultAsync(x => Request.DynamicAttributesWithValues.Select(y => y.DynamicAttributeId)
                                        .Contains(x.Id) && x.EnglishTitle.ToLower() == "Educational Entity".ToLower());

                                if (EducationalEntityDynamicAttribute is not null)
                                {
                                    string? StringValueForEducatiolaEntity = Request.DynamicAttributesWithValues.FirstOrDefault(x => x.DynamicAttributeId == EducationalEntityDynamicAttribute.Id)!
                                        .ValueAsString;

                                    EducationalEntity? EducationalEntity = await _EducationalEntityRepository
                                        .FirstOrDefaultAsync(x => Request.lang == "en"
                                            ? x.EnglishName.ToLower() == StringValueForEducatiolaEntity!.ToLower()
                                            : x.ArabicName.ToLower() == StringValueForEducatiolaEntity!.ToLower());

                                    if (EducationalEntity is not null)
                                    {
                                        CategoryEducationalEntity NewCategoryEducationalEntityEntity = new CategoryEducationalEntity()
                                        {
                                            CategoryId = ProvidedFormEntity!.categoryId,
                                            EducationalEntityId = EducationalEntity.Id
                                        };

                                        await _CategoryEducationalEntityRepository.AddAsync(NewCategoryEducationalEntityEntity);

                                        ProvidedFormEntity.CategoryEducationalEntityId = NewCategoryEducationalEntityEntity.Id;
                                    }
                                }

                                await _ProvidedFormRepository.UpdateAsync(ProvidedFormEntity);
                            }
                        }
                    }

                    Transaction.Complete();

                    if (CheckForUpdateValues.Any() ||
                        DynamicAttributeTableValueEnititiesToDelete.Any())
                            ResponseMessage = Request.lang == "en"
                                ? "Updated successfully"
                                : "تم تعديل المعلومات بنجاح";

                    else
                        ResponseMessage = Request.lang == "en"
                            ? "Created successfully"
                            : "تم إدخال المعلومات بنجاح";

                    return new BaseResponse<AddDynamicAttributeValueForSaveResponse>(ResponseMessage, true, 200);
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
