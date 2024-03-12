using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValueForSave
{
    public class AddDynamicAttributeValueForSaveHandler : IRequestHandler<AddDynamicAttributeValueForSaveCommand,
        BaseResponse<AddDynamicAttributeValueForSaveResponse>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public AddDynamicAttributeValueForSaveHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IHttpContextAccessor HttpContextAccessor)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<BaseResponse<AddDynamicAttributeValueForSaveResponse>> Handle(AddDynamicAttributeValueForSaveCommand Request,
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;
            foreach (AddDynamicAttributeValueForSaveMainCommand InputDynamicAttributeWithValues in Request.DynamicAttributesWithValues)
            {
                DynamicAttribute? DynamicAttributeEntity = await _DynamicAttributeRepository
                    .IncludeThenFirstOrDefaultAsync(x => x.AttributeDataType!, x => x.Id == InputDynamicAttributeWithValues.DynamicAttributeId);

                if (DynamicAttributeEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Field is not found"
                        : "الحقل غير موجود";

                    return new BaseResponse<AddDynamicAttributeValueForSaveResponse>(ResponseMessage, false, 404);
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
                            Value = x.ValueAsString!
                        }).ToList();

                    await _DynamicAttributeValueRepository.AddRangeAsync(DynamicAttributeValuesEntities);

                    Transaction.Complete();

                    if (CheckForUpdateValues.Count() > 0)
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
