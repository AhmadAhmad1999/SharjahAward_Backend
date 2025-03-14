﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
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
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;

        public AddDynamicAttributeValueForSaveHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository,
            IHttpContextAccessor HttpContextAccessor,
            IAsyncRepository<ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<EducationalClass> EducationalClassRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
            _HttpContextAccessor = HttpContextAccessor;
            _ProvidedFormRepository = ProvidedFormRepository;
            _EducationalClassRepository = EducationalClassRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
            this._EducationalInstitutionRepository = _EducationalInstitutionRepository;
        }

        public async Task<BaseResponse<AddDynamicAttributeValueForSaveResponse>> Handle(AddDynamicAttributeValueForSaveCommand Request,
            CancellationToken cancellationToken)
        {
            int AttributeTableNameId = 0;

            if (Request.DynamicAttributesWithValues.Any())
            {
                DynamicAttribute? DynamicAttributeForAttributeTableNameId = await _DynamicAttributeRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.DynamicAttributesWithValues[0].DynamicAttributeId);

                if (DynamicAttributeForAttributeTableNameId is not null)
                    AttributeTableNameId = DynamicAttributeForAttributeTableNameId.DynamicAttributeSection!.AttributeTableNameId;
            }
            else if (Request.DynamicAttributesWithTableValues.Any())
            {
                DynamicAttribute? DynamicAttributeForAttributeTableNameId = await _DynamicAttributeRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.DynamicAttributesWithTableValues[0].DynamicAttributeId);

                if (DynamicAttributeForAttributeTableNameId is not null)
                    AttributeTableNameId = DynamicAttributeForAttributeTableNameId.DynamicAttributeSection!.AttributeTableNameId;
            }
            else if (Request.DynamicAttributesWithValuesMobile != null
                ? Request.DynamicAttributesWithValuesMobile.Any()
                : false)
            {
                DynamicAttribute? DynamicAttributeForAttributeTableNameId = await _DynamicAttributeRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.DynamicAttributesWithValuesMobile[0].DynamicAttributeId);

                if (DynamicAttributeForAttributeTableNameId is not null)
                    AttributeTableNameId = DynamicAttributeForAttributeTableNameId.DynamicAttributeSection!.AttributeTableNameId;
            }
            else if (Request.DynamicAttributesWithTableValuesMobile != null
                ? Request.DynamicAttributesWithTableValuesMobile.Any()
                : false)
            {
                DynamicAttribute? DynamicAttributeForAttributeTableNameId = await _DynamicAttributeRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.DynamicAttributesWithTableValuesMobile[0].DynamicAttributeId);

                if (DynamicAttributeForAttributeTableNameId is not null)
                    AttributeTableNameId = DynamicAttributeForAttributeTableNameId.DynamicAttributeSection!.AttributeTableNameId;
            }
            else
            {
                return new BaseResponse<AddDynamicAttributeValueForSaveResponse>("", false, 500);
            }

            if ((Request.DynamicAttributesWithValuesMobile != null && Request.ValueAsBinaryFiles != null)
                ? (Request.DynamicAttributesWithValuesMobile.Any() && Request.ValueAsBinaryFiles.Any()) : false)
            {
                for (int i = 0; i < Request.DynamicAttributesWithValuesMobile.Count(); i++)
                {
                    Request.DynamicAttributesWithValues.Add(new AddDynamicAttributeValueForSaveMainCommand()
                    {
                        DynamicAttributeId = Request.DynamicAttributesWithValuesMobile[i].DynamicAttributeId,
                        ValueAsBinaryFile = Request.ValueAsBinaryFiles[i]
                    });
                }
            }

            if ((Request.DynamicAttributesWithTableValuesMobile != null && Request.ValueAsBinaryFilesForTable != null)
                ? (Request.DynamicAttributesWithTableValuesMobile.Any() && Request.ValueAsBinaryFilesForTable.Any()) : false)
            {
                for (int i = 0; i < Request.DynamicAttributesWithTableValuesMobile.Count(); i++)
                {
                    Request.DynamicAttributesWithTableValues.Add(new AddDynamicAttributeTableValueForSaveMainCommand()
                    {
                        DynamicAttributeId = Request.DynamicAttributesWithTableValuesMobile[i].DynamicAttributeId,
                        ValueAsBinaryFile = Request.ValueAsBinaryFilesForTable[i],
                        RowId = Request.DynamicAttributesWithTableValuesMobile[i].RowId
                    });
                }
            }

            string ResponseMessage = string.Empty;

            List<DynamicAttribute> DynamicAttributeEntities = await _DynamicAttributeRepository
                .Where(x => Request.DynamicAttributesWithValues.Select(y => y.DynamicAttributeId).Contains(x.Id) ||
                    Request.DynamicAttributesWithTableValues.Select(y => y.DynamicAttributeId).Contains(x.Id))
                .ToListAsync();

            bool ForProvidedForm = false;
            if (DynamicAttributeEntities.Any(x => x.DynamicAttributeSection!.AttributeTableNameId == 1))
                ForProvidedForm = true;

            //int DynamicAttributeEntitiesCount = DynamicAttributeEntities.Count();

                //if (DynamicAttributeEntitiesCount != Request.DynamicAttributesWithValues.Count() + 
                //        Request.DynamicAttributesWithTableValues.Count())
                //{
                //    ResponseMessage = Request.lang == "en"
                //        ? "Field is not found"
                //        : "الحقل غير موجود";

                //    return new BaseResponse<AddDynamicAttributeValueForSaveResponse>(ResponseMessage, false, 404);
                //}

            List<DynamicAttribute> PhoneNumberDynamicAttributeEntities = DynamicAttributeEntities
                .Where(x => x.AttributeDataType!.Name == "Phone Number" &&
                    (Request.DynamicAttributesWithValues.Select(y => y.DynamicAttributeId).Contains(x.Id) ||
                    Request.DynamicAttributesWithTableValues.Select(y => y.DynamicAttributeId).Contains(x.Id)))
                .ToList();

            foreach (DynamicAttribute PhoneNumberDynamicAttributeEntity in PhoneNumberDynamicAttributeEntities)
            {
                AddDynamicAttributeValueForSaveMainCommand? InputDynamicAttributeWithValues = Request.DynamicAttributesWithValues
                    .FirstOrDefault(x => x.DynamicAttributeId == PhoneNumberDynamicAttributeEntity.Id);

                if (InputDynamicAttributeWithValues is not null)
                {
                    if (InputDynamicAttributeWithValues.ValueAsString != "0097105")
                    {
                        if (!string.IsNullOrEmpty(InputDynamicAttributeWithValues!.ValueAsString)
                            ? (!InputDynamicAttributeWithValues.ValueAsString.StartsWith("0097105") ||
                                InputDynamicAttributeWithValues.ValueAsString.Replace("0097105", string.Empty).Count() != 8)
                            : false)
                        {
                            ResponseMessage = Request.lang == "en"
                                ? $"The field {PhoneNumberDynamicAttributeEntity.EnglishTitle} can't has this value"
                                : $"الحقل {PhoneNumberDynamicAttributeEntity.ArabicTitle} لا يمكن أن يحتوي على هذه القيمة";

                            return new BaseResponse<AddDynamicAttributeValueForSaveResponse>(ResponseMessage, false, 400);
                        }
                    }
                }
                else
                {
                    AddDynamicAttributeTableValueForSaveMainCommand? InputDynamicAttributeWithTableValues = Request.DynamicAttributesWithTableValues
                        .FirstOrDefault(x => x.DynamicAttributeId == PhoneNumberDynamicAttributeEntity.Id);

                    if (InputDynamicAttributeWithTableValues is not null)
                    {
                        if (InputDynamicAttributeWithTableValues.ValueAsString != "0097105")
                        {
                            if (!string.IsNullOrEmpty(InputDynamicAttributeWithTableValues!.ValueAsString)
                                ? (!InputDynamicAttributeWithTableValues.ValueAsString.StartsWith("0097105") ||
                                    InputDynamicAttributeWithTableValues.ValueAsString.Replace("0097105", string.Empty).Count() != 8)
                                : false)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"The field {PhoneNumberDynamicAttributeEntity.EnglishTitle} can't has this value"
                                    : $"الحقل {PhoneNumberDynamicAttributeEntity.ArabicTitle} لا يمكن أن يحتوي على هذه القيمة";

                                return new BaseResponse<AddDynamicAttributeValueForSaveResponse>(ResponseMessage, false, 400);
                            }
                        }
                    }
                }
            }

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
                    List<DynamicAttributeValue> CheckForUpdateValues = await _DynamicAttributeValueRepository
                        .Where(x => x.RecordId == Request.RecordId &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == AttributeTableNameId)
                        .ToListAsync();

                    if (CheckForUpdateValues.Count() > 0)
                        await _DynamicAttributeValueRepository.DeleteListAsync(CheckForUpdateValues);

                    List<AddDynamicAttributeValueForSaveMainCommand> DynamicAttributesAsFile = Request.DynamicAttributesWithValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddDynamicAttributeValueForSaveMainCommand DynamicAttributeAsFile in DynamicAttributesAsFile)
                    {
                        string? FileName = $"{Request.RecordId}-{DynamicAttributeAsFile.ValueAsBinaryFile!.FileName}";

                        string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"{FileName}";

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = FolderPathToCreate + $"{FileName}";

                        if (!Directory.Exists(FolderPathToCreate))
                            Directory.CreateDirectory(FolderPathToCreate);

                        using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                            await DynamicAttributeAsFile.ValueAsBinaryFile.CopyToAsync(FileStream);

                        DynamicAttributeAsFile.ValueAsBinaryFile = null;
                        DynamicAttributeAsFile.ValueAsString = FilePathToSaveIntoDataBase;
                    }

                    List<DynamicAttributeValue> DynamicAttributeValuesEntities = Request.DynamicAttributesWithValues
                        .Where(x => !string.IsNullOrEmpty(x.ValueAsString) &&
                            x.DynamicAttributeId > 0)
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
                                ?.isAccepted ?? null,
                            ReasonForRejecting = CheckForUpdateValues.FirstOrDefault(y => y.DynamicAttributeId == x.DynamicAttributeId)
                                ?.ReasonForRejecting ?? null
                        }).ToList();

                    await _DynamicAttributeValueRepository.AddRangeAsync(DynamicAttributeValuesEntities);

                    List<DynamicAttributeTableValue> DynamicAttributeTableValueEnititiesToDelete = await _DynamicAttributeTableValueRepository
                        .Where(x => x.RecordId == Request.RecordId &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == AttributeTableNameId)
                        .ToListAsync();

                    if (DynamicAttributeTableValueEnititiesToDelete.Any())
                        await _DynamicAttributeTableValueRepository.DeleteListAsync(DynamicAttributeTableValueEnititiesToDelete);

                    List<AddDynamicAttributeTableValueForSaveMainCommand> DynamicAttributesTableValueAsFile = Request.DynamicAttributesWithTableValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddDynamicAttributeTableValueForSaveMainCommand DynamicAttributeAsFile in DynamicAttributesTableValueAsFile)
                    {
                        string? FileName = $"{Request.RecordId}-{DynamicAttributeAsFile.ValueAsBinaryFile!.FileName}";

                        string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"{FileName}";

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = FolderPathToCreate + $"{FileName}";

                        if (!Directory.Exists(FolderPathToCreate))
                            Directory.CreateDirectory(FolderPathToCreate);

                        using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                            await DynamicAttributeAsFile.ValueAsBinaryFile.CopyToAsync(FileStream);

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
                                .FirstOrDefault(y => y.DynamicAttributeId == x.DynamicAttributeId)?.isAccepted ?? null,
                            ReasonForRejecting = DynamicAttributeTableValueEnititiesToDelete
                                .FirstOrDefault(y => y.DynamicAttributeId == x.DynamicAttributeId)?.ReasonForRejecting ?? null
                        }).ToList();

                    await _DynamicAttributeTableValueRepository.AddRangeAsync(DynamicAttributeTableValueEntitiesToAdd);

                    if (Request.DynamicAttributesWithValues.Any())
                    {
                        DynamicAttribute? CheckIfThereisClassAttribute = await _DynamicAttributeRepository
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

                                    int DynamicAttributeListValueId = 0;

                                    if (!string.IsNullOrEmpty(StringValueForClass)
                                        ? int.TryParse(StringValueForClass, out DynamicAttributeListValueId)
                                        : false)
                                    {
                                        DynamicAttributeListValue? DynamicAttributeListValueEntity = await _DynamicAttributeListValueRepository
                                            .FirstOrDefaultAsync(x => x.Id == DynamicAttributeListValueId);

                                        if (DynamicAttributeListValueEntity is not null)
                                        {
                                            EducationalClass? Classes = await _EducationalClassRepository
                                                .FirstOrDefaultAsync(x => Request.lang == "en"
                                                    ? x.EnglishName.ToLower() == DynamicAttributeListValueEntity!.EnglishValue.ToLower()
                                                    : x.ArabicName.ToLower() == DynamicAttributeListValueEntity!.ArabicValue!.ToLower());

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
                                    }
                                }

                                DynamicAttributeListValue? EducationalInstitutionDynamicAttribute = await _DynamicAttributeListValueRepository
                                    .FirstOrDefaultAsync(x => Request.DynamicAttributesWithValues
                                        .Select(y => y.DynamicAttributeId)
                                        .Contains(x.DynamicAttributeId) &&
                                            x.DynamicAttribute!.EnglishTitle.ToLower() == "Educational Institution".ToLower());

                                if (EducationalInstitutionDynamicAttribute is not null)
                                {
                                    EducationalInstitution? EducationalInstitutionEntity = await _EducationalInstitutionRepository
                                        .FirstOrDefaultAsync(x => Request.lang == "en"
                                            ? x.EnglishName.ToLower() == EducationalInstitutionDynamicAttribute.EnglishValue.ToLower()
                                            : x.ArabicName.ToLower() == EducationalInstitutionDynamicAttribute.ArabicValue.ToLower());

                                    if (EducationalInstitutionEntity is not null)
                                    {
                                        ProvidedFormEntity.EducationalInstitutionId = EducationalInstitutionEntity.Id;
                                        ProvidedFormEntity.EducationalEntityId = EducationalInstitutionEntity.EducationalEntityId;
                                    }
                                }

                                await _ProvidedFormRepository.UpdateAsync(ProvidedFormEntity);
                            }
                        }
                    }

                    if (ForProvidedForm)
                    {
                        var DynamicAttributeListValueId = CheckForUpdateValues.FirstOrDefault(x => x.DynamicAttribute!.EnglishTitle == "Class" &&
                            x.DynamicAttribute!.ArabicTitle == "الصف")?.Value;

                        //if (DynamicAttributeListValueId is not null)
                        //{
                        //    var xx = await _DynamicAttributeListValueRepository
                        //        .FirstOrDefaultAsync(x => x.Id == int.Parse(DynamicAttributeListValueId));

                        //    var yy = await 
                        //}
                        
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
