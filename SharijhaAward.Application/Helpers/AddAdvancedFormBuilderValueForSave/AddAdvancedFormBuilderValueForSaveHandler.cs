using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using System.Transactions;

namespace SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValueForSave
{
    public class AddAdvancedFormBuilderValueForSaveHandler : IRequestHandler<AddAdvancedFormBuilderValueForSaveCommand,
        BaseResponse<AddAdvancedFormBuilderValueForSaveResponse>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderTableValue> _AdvancedFormBuilderTableValueRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public AddAdvancedFormBuilderValueForSaveHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderValue> AdvancedFormBuilderValueRepository,
            IAsyncRepository<AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueRepository,
            IHttpContextAccessor HttpContextAccessor)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderValueRepository = AdvancedFormBuilderValueRepository;
            _AdvancedFormBuilderTableValueRepository = AdvancedFormBuilderTableValueRepository;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<BaseResponse<AddAdvancedFormBuilderValueForSaveResponse>> 
            Handle(AddAdvancedFormBuilderValueForSaveCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int AdvancedFormBuilderEntitiesCount = await _AdvancedFormBuilderRepository
                .Where(x => Request.AdvancedFormBuildersWithValues.Select(y => y.AdvancedFormBuilderId).Contains(x.Id))
                .CountAsync();

            if (AdvancedFormBuilderEntitiesCount != Request.AdvancedFormBuildersWithValues.Count())
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field is not found"
                    : "الحقل غير موجود";

                return new BaseResponse<AddAdvancedFormBuilderValueForSaveResponse>(ResponseMessage, false, 404);
            }

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    List<AdvancedFormBuilderValue> CheckForUpdateValues = await _AdvancedFormBuilderValueRepository
                        .Where(x => x.VirtualTableId == Request.VirtualTableId).ToListAsync();

                    if (CheckForUpdateValues.Count() > 0)
                        await _AdvancedFormBuilderValueRepository.DeleteListAsync(CheckForUpdateValues);

                    List<AddAdvancedFormBuilderValueForSaveMainCommand> AdvancedFormBuildersAsFile = Request.AdvancedFormBuildersWithValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddAdvancedFormBuilderValueForSaveMainCommand AdvancedFormBuilderAsFile in AdvancedFormBuildersAsFile)
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string FolderPath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DynamicFiles"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DynamicFiles";

                        string? FileName = $"{Request.VirtualTableId}-{AdvancedFormBuilderAsFile.ValueAsBinaryFile!.FileName}";

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
                            AdvancedFormBuilderAsFile.ValueAsBinaryFile.CopyTo(FileStream);
                        }

                        AdvancedFormBuilderAsFile.ValueAsBinaryFile = null;
                        AdvancedFormBuilderAsFile.ValueAsString = FilePathToSaveIntoDataBase;
                    }

                    List<AdvancedFormBuilderValue> AdvancedFormBuilderValuesEntities = Request.AdvancedFormBuildersWithValues
                        .Where(x => !string.IsNullOrEmpty(x.ValueAsString))
                        .Select(x => new AdvancedFormBuilderValue()
                        {
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            AdvancedFormBuilderId = x.AdvancedFormBuilderId,
                            isDeleted = false,
                            VirtualTableId = Request.VirtualTableId,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            Value = x.ValueAsString!
                        }).ToList();

                    await _AdvancedFormBuilderValueRepository.AddRangeAsync(AdvancedFormBuilderValuesEntities);

                    List<AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueEnititiesToDelete = await _AdvancedFormBuilderTableValueRepository
                        .Where(x => x.VirtualTableId == Request.VirtualTableId)
                        .ToListAsync();

                    if (AdvancedFormBuilderTableValueEnititiesToDelete.Any())
                        await _AdvancedFormBuilderTableValueRepository.DeleteListAsync(AdvancedFormBuilderTableValueEnititiesToDelete);

                    List<AddAdvancedFormBuilderTableValueForSaveMainCommand> AdvancedFormBuildersTableValueAsFile = Request.AdvancedFormBuildersWithTableValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddAdvancedFormBuilderTableValueForSaveMainCommand AdvancedFormBuilderAsFile in AdvancedFormBuildersTableValueAsFile)
                    {
                        bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                        string FolderPath = isHttps
                            ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DynamicFiles"
                            : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DynamicFiles";

                        string? FileName = $"{Request.VirtualTableId}-{AdvancedFormBuilderAsFile.ValueAsBinaryFile!.FileName}";

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
                            AdvancedFormBuilderAsFile.ValueAsBinaryFile.CopyTo(FileStream);
                        }

                        AdvancedFormBuilderAsFile.ValueAsBinaryFile = null;
                        AdvancedFormBuilderAsFile.ValueAsString = FilePathToSaveIntoDataBase;
                    }

                    List<AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueEntitiesToAdd = Request.AdvancedFormBuildersWithTableValues
                        .Where(x => !string.IsNullOrEmpty(x.ValueAsString))
                        .Select(x => new AdvancedFormBuilderTableValue()
                        {
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            AdvancedFormBuilderId = x.AdvancedFormBuilderId,
                            isDeleted = false,
                            VirtualTableId = Request.VirtualTableId,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            Value = x.ValueAsString!,
                            RowId = x.RowId
                        }).ToList();

                    await _AdvancedFormBuilderTableValueRepository.AddRangeAsync(AdvancedFormBuilderTableValueEntitiesToAdd);

                    Transaction.Complete();

                    if (CheckForUpdateValues.Count() > 0)
                        ResponseMessage = Request.lang == "en"
                            ? "Updated successfully"
                            : "تم تعديل المعلومات بنجاح";

                    else
                        ResponseMessage = Request.lang == "en"
                            ? "Created successfully"
                            : "تم إدخال المعلومات بنجاح";

                    return new BaseResponse<AddAdvancedFormBuilderValueForSaveResponse>(ResponseMessage, true, 200);
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
