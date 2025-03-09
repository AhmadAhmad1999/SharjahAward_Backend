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
        BaseResponse<int>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderTableValue> _AdvancedFormBuilderTableValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<VirtualTable> _VirtualTableRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderViewWhenRelation> _AdvancedFormBuilderViewWhenRelationRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderGeneralValidation> _AdvancedFormBuilderGeneralValidationRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependency> _AdvancedFormBuilderDependencyRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependencyValidation> _AdvancedFormBuilderDependencyValidationRepository;

        public AddAdvancedFormBuilderValueForSaveHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderValue> AdvancedFormBuilderValueRepository,
            IAsyncRepository<AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueRepository,
            IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository,
            IHttpContextAccessor HttpContextAccessor,
            IAsyncRepository<VirtualTable> VirtualTableRepository,
            IAsyncRepository<AdvancedFormBuilderViewWhenRelation> AdvancedFormBuilderViewWhenRelationRepository,
            IAsyncRepository<AdvancedFormBuilderGeneralValidation> AdvancedFormBuilderGeneralValidationRepository,
            IAsyncRepository<AdvancedFormBuilderDependency> AdvancedFormBuilderDependencyRepository,
            IAsyncRepository<AdvancedFormBuilderDependencyValidation> AdvancedFormBuilderDependencyValidationRepository)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderValueRepository = AdvancedFormBuilderValueRepository;
            _AdvancedFormBuilderTableValueRepository = AdvancedFormBuilderTableValueRepository;
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
            _HttpContextAccessor = HttpContextAccessor;
            _VirtualTableRepository = VirtualTableRepository;
            _AdvancedFormBuilderViewWhenRelationRepository = AdvancedFormBuilderViewWhenRelationRepository;
            _AdvancedFormBuilderGeneralValidationRepository = AdvancedFormBuilderGeneralValidationRepository;
            _AdvancedFormBuilderDependencyRepository = AdvancedFormBuilderDependencyRepository;
            _AdvancedFormBuilderDependencyValidationRepository = AdvancedFormBuilderDependencyValidationRepository;
        }

        public async Task<BaseResponse<int>> Handle(AddAdvancedFormBuilderValueForSaveCommand Request,
            CancellationToken cancellationToken)
        {
            int VirtualTableId = 0;

            if (Request.VirtualTableId is null ||
                (Request.VirtualTableId is not null 
                    ? int.Parse(Request.VirtualTableId) <= 0
                    : false))
            {
                VirtualTable NewVirtualTableEntity = new VirtualTable();

                await _VirtualTableRepository.AddAsync(NewVirtualTableEntity);

                VirtualTableId = NewVirtualTableEntity!.Id;
            }
            else
            {
                VirtualTableId = int.Parse(Request.VirtualTableId!);
            }

            string ResponseMessage = string.Empty;

            List<AdvancedFormBuilder> AdvancedFormBuilderEntities = await _AdvancedFormBuilderRepository
                .Where(x => Request.AdvancedFormBuildersWithValues.Select(y => y.AdvancedFormBuilderId).Contains(x.Id) ||
                    Request.AdvancedFormBuildersWithTableValues.Select(y => y.AdvancedFormBuilderId).Contains(x.Id))
                .ToListAsync();

            List<AdvancedFormBuilderViewWhenRelation> AdvancedFormBuilderViewWhenRelationEntities = await _AdvancedFormBuilderViewWhenRelationRepository
                .Where(x => AdvancedFormBuilderEntities.Select(y => y.Id).Any(y => y == x.AdvancedFormBuilderId))
                .ToListAsync();

            foreach (AddAdvancedFormBuilderValueForSaveMainCommand InputAdvancedFormBuilderWithValues in Request.AdvancedFormBuildersWithValues)
            {
                AdvancedFormBuilder? AdvancedFormBuilderEntity = AdvancedFormBuilderEntities
                    .FirstOrDefault(x => x.Id == InputAdvancedFormBuilderWithValues.AdvancedFormBuilderId);

                if (AdvancedFormBuilderEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Field is not found"
                        : "الحقل غير موجود";

                    return new BaseResponse<int>(ResponseMessage, false, 404);
                }

                if (AdvancedFormBuilderEntity.AttributeDataType!.Name == "Phone Number")
                {
                    if (InputAdvancedFormBuilderWithValues.ValueAsString != "0097105")
                    {
                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderWithValues.ValueAsString)
                            ? (!InputAdvancedFormBuilderWithValues.ValueAsString.StartsWith("0097105") ||
                                InputAdvancedFormBuilderWithValues.ValueAsString.Replace("0097105", string.Empty).Count() != 8)
                        : false)
                        {
                            ResponseMessage = Request.lang == "en"
                                ? $"The field {AdvancedFormBuilderEntity.EnglishTitle} can't has this value"
                                : $"الحقل {AdvancedFormBuilderEntity.ArabicTitle} لا يمكن أن يحتوي على هذه القيمة";

                            return new BaseResponse<int>(ResponseMessage, false, 400);
                        }
                    }
                }

                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderWithValues.ValueAsString))
                {
                    // Unique Constraint..
                    AdvancedFormBuilderValue? CheckUnique = await _AdvancedFormBuilderValueRepository
                        .IncludeThenFirstOrDefaultAsync(x => x.AdvancedFormBuilder!, x => x.AdvancedFormBuilderId == AdvancedFormBuilderEntity.Id &&
                            x.VirtualTableId != VirtualTableId && x.AdvancedFormBuilder!.IsUnique &&
                            x.Value.ToLower() == InputAdvancedFormBuilderWithValues.ValueAsString.ToLower());

                    if (CheckUnique != null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value is already used, please insert a different value"
                            : $"قيمة هذا الحقل: {AdvancedFormBuilderEntity.ArabicLabel} مستخدمة مسبقاً, الرجاء إدخال قيمة مختلفة";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }
                }

                // Check General Validation..
                AdvancedFormBuilderGeneralValidation? AdvancedFormBuilderGeneralValidationEntity = await _AdvancedFormBuilderGeneralValidationRepository
                    .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!, x => x.AdvancedFormBuilderId == InputAdvancedFormBuilderWithValues.AdvancedFormBuilderId);

                if (AdvancedFormBuilderGeneralValidationEntity != null)
                {
                    string DataTypeAsName = AdvancedFormBuilderEntity.AttributeDataType!.Name;
                    string? InputAdvancedFormBuilderValueAsString = InputAdvancedFormBuilderWithValues.ValueAsString;
                    string ValidationOperation = AdvancedFormBuilderGeneralValidationEntity.AttributeOperation!.OperationAsString;
                    string? ValidationValue = AdvancedFormBuilderGeneralValidationEntity.Value;

                    if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                        DataTypeAsName.ToLower() == "Email".ToLower() ||
                        DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                        DataTypeAsName.ToLower() == "List".ToLower() ||
                        DataTypeAsName.ToLower() == "Location".ToLower())
                    {
                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                        {
                            if (ValidationOperation == "!=")
                            {
                                if (!string.IsNullOrEmpty(ValidationValue)
                                    ? InputAdvancedFormBuilderValueAsString.ToLower() == ValidationValue!.ToLower()
                                    : false)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (!string.IsNullOrEmpty(ValidationValue)
                                    ? InputAdvancedFormBuilderValueAsString.ToLower() != ValidationValue!.ToLower()
                                    : false)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                        }
                        else
                        {
                            if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                        }
                    }
                    else if (DataTypeAsName.ToLower() == "Number".ToLower())
                    {
                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                        {
                            if (ValidationOperation == "!=")
                            {
                                if (InputAdvancedFormBuilderValueAsString == ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "<")
                            {
                                bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                    out int InputAdvancedFormBuilderValueAsInteger);
                                if (!CheckInputAdvancedFormBuilderValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger >= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "<=")
                            {
                                bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                    out int InputAdvancedFormBuilderValueAsInteger);
                                if (!CheckInputAdvancedFormBuilderValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == ">")
                            {
                                bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                    out int InputAdvancedFormBuilderValueAsInteger);
                                if (!CheckInputAdvancedFormBuilderValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger <= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == ">=")
                            {
                                bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                    out int InputAdvancedFormBuilderValueAsInteger);
                                if (!CheckInputAdvancedFormBuilderValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                        }
                        else
                        {
                            if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                        }
                    }
                    else if (DataTypeAsName.ToLower() == "Date".ToLower())
                    {
                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                        {
                            if (ValidationOperation == "!=")
                            {
                                if (InputAdvancedFormBuilderValueAsString == ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "<")
                            {
                                bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                    out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                if (!CheckInputAdvancedFormBuilderValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly >= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "<=")
                            {
                                bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                    out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                if (!CheckInputAdvancedFormBuilderValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == ">")
                            {
                                bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                    out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                if (!CheckInputAdvancedFormBuilderValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly <= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == ">=")
                            {
                                bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                    out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                if (!CheckInputAdvancedFormBuilderValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                        }
                        else
                        {
                            if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                        }
                    }
                    else if (DataTypeAsName.ToLower() == "Image".ToLower() ||
                        DataTypeAsName.ToLower() == "File".ToLower())
                    {
                        IFormFile? InputAdvancedFormBuilderValueAsBinaryFile = InputAdvancedFormBuilderWithValues.ValueAsBinaryFile;

                        if (ValidationOperation.ToLower() == "is Empty".ToLower())
                        {
                            if (InputAdvancedFormBuilderValueAsBinaryFile is not null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                return new BaseResponse<int>(ResponseMessage, false, 400);
                            }
                        }
                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                        {
                            if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                return new BaseResponse<int>(ResponseMessage, false, 400);
                            }
                        }
                    }
                }

                // Check AdvancedFormBuilderDependency Validation..
                if (AdvancedFormBuilderEntity.LinkedToAnotherAttribute)
                {
                    List<IGrouping<int, AdvancedFormBuilderDependency>> DependenciesEntitiesGroupByGroupId = _AdvancedFormBuilderDependencyRepository
                        .WhereThenInclude(x => x.MainAdvancedFormBuilderId == InputAdvancedFormBuilderWithValues.AdvancedFormBuilderId &&
                            x.AdvancedFormBuilderId != null,
                            x => x.AttributeOperation!, x => x.AdvancedFormBuilder!, x => x.AdvancedFormBuilder!.AttributeDataType!)
                        .GroupBy(x => x.AdvancedFormBuilderDependencyGroupId).ToList();

                    foreach (IGrouping<int, AdvancedFormBuilderDependency> AdvancedFormBuilderDependencyEntityGroupByGroupId in DependenciesEntitiesGroupByGroupId)
                    {
                        int CheckAllDependenciesInGroup = 0;
                        foreach (AdvancedFormBuilderDependency AdvancedFormBuilderDependencyEntityInGroup in AdvancedFormBuilderDependencyEntityGroupByGroupId.ToList())
                        {
                            string DataTypeAsName = AdvancedFormBuilderDependencyEntityInGroup.AdvancedFormBuilder!.AttributeDataType!.Name;

                            AddAdvancedFormBuilderValueForSaveMainCommand? CheckIfAdvancedFormBuilderDependencyValueIsInserted = Request.AdvancedFormBuildersWithValues
                                .FirstOrDefault(x => x.AdvancedFormBuilderId == AdvancedFormBuilderDependencyEntityInGroup.AdvancedFormBuilderId);

                            if (CheckIfAdvancedFormBuilderDependencyValueIsInserted == null)
                                break;

                            string? InputAdvancedFormBuilderValueAsString = CheckIfAdvancedFormBuilderDependencyValueIsInserted.ValueAsString;

                            string AdvancedFormBuilderDependencyOperation = AdvancedFormBuilderDependencyEntityInGroup.AttributeOperation!.OperationAsString;
                            string AdvancedFormBuilderDependencyValue = AdvancedFormBuilderDependencyEntityInGroup.Value;

                            if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                                DataTypeAsName.ToLower() == "Email".ToLower() ||
                                DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                                DataTypeAsName.ToLower() == "List".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    if (AdvancedFormBuilderDependencyOperation == "!=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString.ToLower() == AdvancedFormBuilderDependencyValue.ToLower())
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString.ToLower() != AdvancedFormBuilderDependencyValue.ToLower())
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                                else
                                {
                                    if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Number".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    if (AdvancedFormBuilderDependencyOperation == "!=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString == AdvancedFormBuilderDependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString != AdvancedFormBuilderDependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == "<")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(AdvancedFormBuilderDependencyValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger >= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == "<=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);
                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(AdvancedFormBuilderDependencyValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == ">")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);
                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(AdvancedFormBuilderDependencyValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger <= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == ">=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);
                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(AdvancedFormBuilderDependencyValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                                else
                                {
                                    if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Date".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    if (AdvancedFormBuilderDependencyOperation == "!=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString == AdvancedFormBuilderDependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString != AdvancedFormBuilderDependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == "<")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(AdvancedFormBuilderDependencyValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly >= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == "<=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(AdvancedFormBuilderDependencyValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == ">")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(AdvancedFormBuilderDependencyValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly <= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation == ">=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(AdvancedFormBuilderDependencyValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                                else
                                {
                                    if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Image".ToLower() ||
                                DataTypeAsName.ToLower() == "File".ToLower())
                            {
                                IFormFile? InputAdvancedFormBuilderValueAsBinaryFile = CheckIfAdvancedFormBuilderDependencyValueIsInserted.ValueAsBinaryFile;

                                if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (InputAdvancedFormBuilderValueAsBinaryFile is not null)
                                        break;

                                    else
                                        CheckAllDependenciesInGroup++;
                                }
                                else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                                        break;

                                    else
                                        CheckAllDependenciesInGroup++;
                                }
                            }
                        }

                        if (CheckAllDependenciesInGroup == AdvancedFormBuilderDependencyEntityGroupByGroupId.ToList().Count())
                        {
                            string DataTypeAsName = AdvancedFormBuilderEntity.AttributeDataType!.Name;
                            string? InputAdvancedFormBuilderValueAsString = InputAdvancedFormBuilderWithValues.ValueAsString;

                            AdvancedFormBuilderDependencyValidation? AdvancedFormBuilderDependencyValidationEntityForThisGroup = await _AdvancedFormBuilderDependencyValidationRepository
                                .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!,
                                    x => x.AdvancedFormBuilderDependencyGroupId == AdvancedFormBuilderDependencyEntityGroupByGroupId.Key);

                            if (AdvancedFormBuilderDependencyValidationEntityForThisGroup == null)
                                continue;

                            string ValidationOperation = AdvancedFormBuilderDependencyValidationEntityForThisGroup!.AttributeOperation!.OperationAsString;
                            string ValidationValue = AdvancedFormBuilderDependencyValidationEntityForThisGroup!.Value;

                            if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                                DataTypeAsName.ToLower() == "Email".ToLower() ||
                                DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                                DataTypeAsName.ToLower() == "List".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    if (ValidationOperation == "!=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString.ToLower() == ValidationValue.ToLower())
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString.ToLower() != ValidationValue.ToLower())
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Number".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    if (ValidationOperation == "!=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString == ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "<")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);
                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger >= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "<=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);
                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == ">")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);
                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger <= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == ">=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);
                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Date".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    if (ValidationOperation == "!=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString == ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "<")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly >= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "<=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == ">")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly <= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == ">=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Image".ToLower() ||
                                DataTypeAsName.ToLower() == "File".ToLower())
                            {
                                IFormFile? InputAdvancedFormBuilderValueAsBinaryFile = InputAdvancedFormBuilderWithValues.ValueAsBinaryFile;

                                if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (InputAdvancedFormBuilderValueAsBinaryFile is not null)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            List<AdvancedFormBuilderSection> AllAdvancedFormBuilderSections = AdvancedFormBuilderEntities
                .Select(x => x.AdvancedFormBuilderSection!)
                .ToList();

            foreach (AdvancedFormBuilderSection AdvancedFormBuilderSection in AllAdvancedFormBuilderSections)
            {
                List<AdvancedFormBuilder> AdvancedFormBuildersInThisAdvancedFormBuilderSection = AdvancedFormBuilderEntities
                    .Where(x => x.AdvancedFormBuilderSectionId == AdvancedFormBuilderSection.Id)
                    .ToList();

                int NumberOfInputedRows = Request.AdvancedFormBuildersWithTableValues
                    .Where(x => AdvancedFormBuildersInThisAdvancedFormBuilderSection.Select(y => y.Id).Contains(x.AdvancedFormBuilderId))
                    .DistinctBy(x => x.RowId)
                    .Count();

                if (AdvancedFormBuilderSection.MinNumberOfRows > NumberOfInputedRows)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"You must enter more than {AdvancedFormBuilderSection.MinNumberOfRows} rows in the " +
                            $"{AdvancedFormBuilderSection.EnglishName} section"
                        : $"يجب عليك إدخال عدد سطور أكثر من {AdvancedFormBuilderSection.MinNumberOfRows} في قسم ال{AdvancedFormBuilderSection.ArabicName}";

                    return new BaseResponse<int>(ResponseMessage, false, 400);
                }
                if (AdvancedFormBuilderSection.MaxNumberOfRows != null
                    ? (AdvancedFormBuilderSection.MaxNumberOfRows != 0 &&
                       AdvancedFormBuilderSection.MaxNumberOfRows < NumberOfInputedRows)
                    : false)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"You can't enter more than {AdvancedFormBuilderSection.MaxNumberOfRows} rows in the " +
                            $"{AdvancedFormBuilderSection.EnglishName} section"
                        : $"لا يمكنك إدخال عدد سطور أكثر من {AdvancedFormBuilderSection.MaxNumberOfRows} في قسم ال{AdvancedFormBuilderSection.ArabicName}";

                    return new BaseResponse<int>(ResponseMessage, false, 400);
                }
            }

            foreach (AddAdvancedFormBuilderTableValueForSaveMainCommand InputAdvancedFormBuilderWithValues in Request.AdvancedFormBuildersWithTableValues)
            {
                if (InputAdvancedFormBuilderWithValues.RowId != 0)
                {
                    AdvancedFormBuilder? AdvancedFormBuilderEntity = AdvancedFormBuilderEntities
                        .FirstOrDefault(x => x.Id == InputAdvancedFormBuilderWithValues.AdvancedFormBuilderId);

                    if (AdvancedFormBuilderEntity == null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Field is not found"
                            : "الحقل غير موجود";

                        return new BaseResponse<int>(ResponseMessage, false, 404);
                    }

                    if (AdvancedFormBuilderEntity.AttributeDataType!.Name == "Phone Number")
                    {
                        if (InputAdvancedFormBuilderWithValues.ValueAsString != "0097105")
                        {
                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderWithValues.ValueAsString)
                                ? (!InputAdvancedFormBuilderWithValues.ValueAsString.StartsWith("0097105") ||
                                    InputAdvancedFormBuilderWithValues.ValueAsString.Replace("0097105", string.Empty).Count() != 8)
                                : false)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"The field {AdvancedFormBuilderEntity.EnglishTitle} can't has this value"
                                    : $"الحقل {AdvancedFormBuilderEntity.ArabicTitle} لا يمكن أن يحتوي على هذه القيمة";

                                return new BaseResponse<int>(ResponseMessage, false, 400);
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderWithValues.ValueAsString))
                    {
                        // Unique Constraint..
                        AdvancedFormBuilderTableValue? CheckUnique = await _AdvancedFormBuilderTableValueRepository
                            .IncludeThenFirstOrDefaultAsync(x => x.AdvancedFormBuilder!, x => x.AdvancedFormBuilderId == AdvancedFormBuilderEntity.Id &&
                                x.RowId == InputAdvancedFormBuilderWithValues.RowId &&
                                x.VirtualTableId != VirtualTableId && x.AdvancedFormBuilder!.IsUnique &&
                                x.Value.ToLower() == InputAdvancedFormBuilderWithValues.ValueAsString.ToLower());

                        if (CheckUnique != null)
                        {
                            ResponseMessage = Request.lang == "en"
                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value is already used, please insert a different value"
                                : $"قيمة هذا الحقل: {AdvancedFormBuilderEntity.ArabicLabel} مستخدمة مسبقاً, الرجاء إدخال قيمة مختلفة";

                            return new BaseResponse<int>(ResponseMessage, false, 400);
                        }
                    }

                    // Check General Validation..
                    AdvancedFormBuilderGeneralValidation? AdvancedFormBuilderGeneralValidationEntity = await _AdvancedFormBuilderGeneralValidationRepository
                        .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!, x => x.AdvancedFormBuilderId == InputAdvancedFormBuilderWithValues.AdvancedFormBuilderId);

                    if (AdvancedFormBuilderGeneralValidationEntity != null)
                    {
                        string DataTypeAsName = AdvancedFormBuilderEntity.AttributeDataType!.Name;
                        string? InputAdvancedFormBuilderValueAsString = InputAdvancedFormBuilderWithValues.ValueAsString;
                        string ValidationOperation = AdvancedFormBuilderGeneralValidationEntity.AttributeOperation!.OperationAsString;
                        string? ValidationValue = AdvancedFormBuilderGeneralValidationEntity.Value;

                        if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                            DataTypeAsName.ToLower() == "Email".ToLower() ||
                            DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                            DataTypeAsName.ToLower() == "List".ToLower() ||
                            DataTypeAsName.ToLower() == "Location".ToLower())
                        {
                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                            {
                                if (ValidationOperation == "!=")
                                {
                                    if (!string.IsNullOrEmpty(ValidationValue)
                                        ? InputAdvancedFormBuilderValueAsString.ToLower() == ValidationValue!.ToLower()
                                        : false)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == "=")
                                {
                                    if (!string.IsNullOrEmpty(ValidationValue)
                                        ? InputAdvancedFormBuilderValueAsString.ToLower() != ValidationValue!.ToLower()
                                        : false)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                            }
                            else
                            {
                                if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                            }
                        }
                        else if (DataTypeAsName.ToLower() == "Number".ToLower())
                        {
                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                            {
                                if (ValidationOperation == "!=")
                                {
                                    if (InputAdvancedFormBuilderValueAsString == ValidationValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == "=")
                                {
                                    if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == "<")
                                {
                                    bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                        out int InputAdvancedFormBuilderValueAsInteger);
                                    if (!CheckInputAdvancedFormBuilderValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }

                                    int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                    if (InputAdvancedFormBuilderValueAsInteger >= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == "<=")
                                {
                                    bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                        out int InputAdvancedFormBuilderValueAsInteger);
                                    if (!CheckInputAdvancedFormBuilderValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }

                                    int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                    if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == ">")
                                {
                                    bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                        out int InputAdvancedFormBuilderValueAsInteger);
                                    if (!CheckInputAdvancedFormBuilderValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }

                                    int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                    if (InputAdvancedFormBuilderValueAsInteger <= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == ">=")
                                {
                                    bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                        out int InputAdvancedFormBuilderValueAsInteger);
                                    if (!CheckInputAdvancedFormBuilderValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }

                                    int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                    if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                            }
                            else
                            {
                                if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                            }
                        }
                        else if (DataTypeAsName.ToLower() == "Date".ToLower())
                        {
                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                            {
                                if (ValidationOperation == "!=")
                                {
                                    if (InputAdvancedFormBuilderValueAsString == ValidationValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == "=")
                                {
                                    if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == "<")
                                {
                                    bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                        out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                    if (!CheckInputAdvancedFormBuilderValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }

                                    DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                    if (InputAdvancedFormBuilderValueAsDateOnly >= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == "<=")
                                {
                                    bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                        out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                    if (!CheckInputAdvancedFormBuilderValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }

                                    DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                    if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == ">")
                                {
                                    bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                        out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                    if (!CheckInputAdvancedFormBuilderValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }

                                    DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                    if (InputAdvancedFormBuilderValueAsDateOnly <= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation == ">=")
                                {
                                    bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                        out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                    if (!CheckInputAdvancedFormBuilderValue)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }

                                    DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                    if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                            }
                            else
                            {
                                if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<int>(ResponseMessage, false, 400);
                                    }
                                }
                            }
                        }
                        else if (DataTypeAsName.ToLower() == "Image".ToLower() ||
                            DataTypeAsName.ToLower() == "File".ToLower())
                        {
                            IFormFile? InputAdvancedFormBuilderValueAsBinaryFile = InputAdvancedFormBuilderWithValues.ValueAsBinaryFile;

                            if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (InputAdvancedFormBuilderValueAsBinaryFile is not null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<int>(ResponseMessage, false, 400);
                                }
                            }
                        }
                    }

                    // Check AdvancedFormBuilderDependency Validation..
                    if (AdvancedFormBuilderEntity.LinkedToAnotherAttribute)
                    {
                        List<IGrouping<int, AdvancedFormBuilderDependency>> DependenciesEntitiesGroupByGroupId = _AdvancedFormBuilderDependencyRepository
                            .WhereThenInclude(x => x.MainAdvancedFormBuilderId == InputAdvancedFormBuilderWithValues.AdvancedFormBuilderId &&
                                x.AdvancedFormBuilderId != null,
                                x => x.AttributeOperation!, x => x.AdvancedFormBuilder!, x => x.AdvancedFormBuilder!.AttributeDataType!)
                            .GroupBy(x => x.AdvancedFormBuilderDependencyGroupId).ToList();

                        foreach (IGrouping<int, AdvancedFormBuilderDependency> AdvancedFormBuilderDependencyEntityGroupByGroupId in DependenciesEntitiesGroupByGroupId)
                        {
                            int CheckAllDependenciesInGroup = 0;
                            foreach (AdvancedFormBuilderDependency AdvancedFormBuilderDependencyEntityInGroup in AdvancedFormBuilderDependencyEntityGroupByGroupId.ToList())
                            {
                                string DataTypeAsName = AdvancedFormBuilderDependencyEntityInGroup.AdvancedFormBuilder!.AttributeDataType!.Name;

                                AddAdvancedFormBuilderValueForSaveMainCommand? CheckIfAdvancedFormBuilderDependencyValueIsInserted = Request.AdvancedFormBuildersWithValues
                                    .FirstOrDefault(x => x.AdvancedFormBuilderId == AdvancedFormBuilderDependencyEntityInGroup.AdvancedFormBuilderId);

                                if (CheckIfAdvancedFormBuilderDependencyValueIsInserted == null)
                                    break;

                                string? InputAdvancedFormBuilderValueAsString = CheckIfAdvancedFormBuilderDependencyValueIsInserted.ValueAsString;

                                string AdvancedFormBuilderDependencyOperation = AdvancedFormBuilderDependencyEntityInGroup.AttributeOperation!.OperationAsString;
                                string AdvancedFormBuilderDependencyValue = AdvancedFormBuilderDependencyEntityInGroup.Value;

                                if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                                    DataTypeAsName.ToLower() == "Email".ToLower() ||
                                    DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                                    DataTypeAsName.ToLower() == "List".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        if (AdvancedFormBuilderDependencyOperation == "!=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString.ToLower() == AdvancedFormBuilderDependencyValue.ToLower())
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == "=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString.ToLower() != AdvancedFormBuilderDependencyValue.ToLower())
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                    }
                                    else
                                    {
                                        if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                    }
                                }
                                else if (DataTypeAsName.ToLower() == "Number".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        if (AdvancedFormBuilderDependencyOperation == "!=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString == AdvancedFormBuilderDependencyValue)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == "=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString != AdvancedFormBuilderDependencyValue)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == "<")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out int InputAdvancedFormBuilderValueAsInteger);

                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            int.TryParse(AdvancedFormBuilderDependencyValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                            if (InputAdvancedFormBuilderValueAsInteger >= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == "<=")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out int InputAdvancedFormBuilderValueAsInteger);
                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            int.TryParse(AdvancedFormBuilderDependencyValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                            if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == ">")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out int InputAdvancedFormBuilderValueAsInteger);
                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            int.TryParse(AdvancedFormBuilderDependencyValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                            if (InputAdvancedFormBuilderValueAsInteger <= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == ">=")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out int InputAdvancedFormBuilderValueAsInteger);
                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            int.TryParse(AdvancedFormBuilderDependencyValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                            if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                    }
                                    else
                                    {
                                        if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                    }
                                }
                                else if (DataTypeAsName.ToLower() == "Date".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        if (AdvancedFormBuilderDependencyOperation == "!=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString == AdvancedFormBuilderDependencyValue)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == "=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString != AdvancedFormBuilderDependencyValue)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == "<")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            DateOnly.TryParse(AdvancedFormBuilderDependencyValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                            if (InputAdvancedFormBuilderValueAsDateOnly >= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == "<=")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            DateOnly.TryParse(AdvancedFormBuilderDependencyValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                            if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == ">")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            DateOnly.TryParse(AdvancedFormBuilderDependencyValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                            if (InputAdvancedFormBuilderValueAsDateOnly <= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation == ">=")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            DateOnly.TryParse(AdvancedFormBuilderDependencyValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                            if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                    }
                                    else
                                    {
                                        if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                        else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                                break;

                                            else
                                                CheckAllDependenciesInGroup++;
                                        }
                                    }
                                }
                                else if (DataTypeAsName.ToLower() == "Image".ToLower() ||
                                    DataTypeAsName.ToLower() == "File".ToLower())
                                {
                                    IFormFile? InputAdvancedFormBuilderValueAsBinaryFile = CheckIfAdvancedFormBuilderDependencyValueIsInserted.ValueAsBinaryFile;

                                    if (AdvancedFormBuilderDependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (InputAdvancedFormBuilderValueAsBinaryFile is not null)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (AdvancedFormBuilderDependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                            }

                            if (CheckAllDependenciesInGroup == AdvancedFormBuilderDependencyEntityGroupByGroupId.ToList().Count())
                            {
                                string DataTypeAsName = AdvancedFormBuilderEntity.AttributeDataType!.Name;
                                string? InputAdvancedFormBuilderValueAsString = InputAdvancedFormBuilderWithValues.ValueAsString;

                                AdvancedFormBuilderDependencyValidation? AdvancedFormBuilderDependencyValidationEntityForThisGroup = await _AdvancedFormBuilderDependencyValidationRepository
                                    .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!,
                                        x => x.AdvancedFormBuilderDependencyGroupId == AdvancedFormBuilderDependencyEntityGroupByGroupId.Key);

                                if (AdvancedFormBuilderDependencyValidationEntityForThisGroup == null)
                                    continue;

                                string ValidationOperation = AdvancedFormBuilderDependencyValidationEntityForThisGroup!.AttributeOperation!.OperationAsString;
                                string ValidationValue = AdvancedFormBuilderDependencyValidationEntityForThisGroup!.Value;

                                if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                                    DataTypeAsName.ToLower() == "Email".ToLower() ||
                                    DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                                    DataTypeAsName.ToLower() == "List".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        if (ValidationOperation == "!=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString.ToLower() == ValidationValue.ToLower())
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == "=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString.ToLower() != ValidationValue.ToLower())
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                    }
                                }
                                else if (DataTypeAsName.ToLower() == "Number".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        if (ValidationOperation == "!=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString == ValidationValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == "=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == "<")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out int InputAdvancedFormBuilderValueAsInteger);
                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                            if (InputAdvancedFormBuilderValueAsInteger >= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == "<=")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out int InputAdvancedFormBuilderValueAsInteger);
                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                            if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == ">")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out int InputAdvancedFormBuilderValueAsInteger);
                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                            if (InputAdvancedFormBuilderValueAsInteger <= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == ">=")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out int InputAdvancedFormBuilderValueAsInteger);
                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                            if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                    }
                                }
                                else if (DataTypeAsName.ToLower() == "Date".ToLower())
                                {
                                    if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                    {
                                        if (ValidationOperation == "!=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString == ValidationValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be equal to: {InputAdvancedFormBuilderValueAsString}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputAdvancedFormBuilderValueAsString}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == "=")
                                        {
                                            if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == "<")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                            if (InputAdvancedFormBuilderValueAsDateOnly >= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == "<=")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                            if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == ">")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                            if (InputAdvancedFormBuilderValueAsDateOnly <= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation == ">=")
                                        {
                                            bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                                out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                            if (!CheckInputAdvancedFormBuilderValue)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }

                                            DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                            if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                        {
                                            if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                return new BaseResponse<int>(ResponseMessage, false, 400);
                                            }
                                        }
                                    }
                                }
                                else if (DataTypeAsName.ToLower() == "Image".ToLower() ||
                                    DataTypeAsName.ToLower() == "File".ToLower())
                                {
                                    IFormFile? InputAdvancedFormBuilderValueAsBinaryFile = InputAdvancedFormBuilderWithValues.ValueAsBinaryFile;

                                    if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (InputAdvancedFormBuilderValueAsBinaryFile is not null)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<int>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                            }
                        }
                    }
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
                    // Hard Delete On Dynamic Values..
                    List<AdvancedFormBuilderValue> DynamicValuesToDelete = await _AdvancedFormBuilderValueRepository
                        .Where(x => x.VirtualTableId == VirtualTableId).ToListAsync();

                    List<AddAdvancedFormBuilderValueForSaveMainCommand> AdvancedFormBuildersAsFile = Request.AdvancedFormBuildersWithValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddAdvancedFormBuilderValueForSaveMainCommand AdvancedFormBuilderAsFile in AdvancedFormBuildersAsFile)
                    {
                        string? FileName = $"{VirtualTableId}-{AdvancedFormBuilderAsFile.ValueAsBinaryFile!.FileName}";

                        string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"{FileName}";

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = FolderPathToCreate + $"{FileName}";

                        if (!Directory.Exists(FolderPathToCreate))
                            Directory.CreateDirectory(FolderPathToCreate);

                        using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                            await AdvancedFormBuilderAsFile.ValueAsBinaryFile.CopyToAsync(FileStream);

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
                            VirtualTableId = VirtualTableId,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            Value = x.ValueAsString!
                        }).ToList();

                    await _AdvancedFormBuilderValueRepository.AddRangeAsync(AdvancedFormBuilderValuesEntities);

                    if (DynamicValuesToDelete.Count() > 0)
                        await _AdvancedFormBuilderValueRepository.DeleteListAsync(DynamicValuesToDelete);

                    List<AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueEnititiesToDelete = await _AdvancedFormBuilderTableValueRepository
                        .Where(x => x.VirtualTableId == VirtualTableId)
                        .ToListAsync();

                    if (AdvancedFormBuilderTableValueEnititiesToDelete.Any())
                        await _AdvancedFormBuilderTableValueRepository.DeleteListAsync(AdvancedFormBuilderTableValueEnititiesToDelete);

                    List<AddAdvancedFormBuilderTableValueForSaveMainCommand> AdvancedFormBuildersTableValueAsFile = Request.AdvancedFormBuildersWithTableValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddAdvancedFormBuilderTableValueForSaveMainCommand AdvancedFormBuilderAsFile in AdvancedFormBuildersTableValueAsFile)
                    {
                        string? FileName = $"{VirtualTableId}-{AdvancedFormBuilderAsFile.ValueAsBinaryFile!.FileName}";

                        string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"{FileName}";

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = FolderPathToCreate + $"{FileName}";

                        if (!Directory.Exists(FolderPathToCreate))
                            Directory.CreateDirectory(FolderPathToCreate);

                        using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                            await AdvancedFormBuilderAsFile.ValueAsBinaryFile.CopyToAsync(FileStream);

                        AdvancedFormBuilderAsFile.ValueAsBinaryFile = null;
                        AdvancedFormBuilderAsFile.ValueAsString = FilePathToSaveIntoDataBase;
                    }

                    List<AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueEntitiesToAdd = Request.AdvancedFormBuildersWithTableValues
                        .Where(x => !string.IsNullOrEmpty(x.ValueAsString) && x.RowId != 0)
                        .Select(x => new AdvancedFormBuilderTableValue()
                        {
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            AdvancedFormBuilderId = x.AdvancedFormBuilderId,
                            isDeleted = false,
                            VirtualTableId = VirtualTableId,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            Value = x.ValueAsString!,
                            RowId = x.RowId
                        }).ToList();

                    await _AdvancedFormBuilderTableValueRepository.AddRangeAsync(AdvancedFormBuilderTableValueEntitiesToAdd);

                    Transaction.Complete();
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إدخال المعلومات بنجاح";

            return new BaseResponse<int>(ResponseMessage, true, 200, VirtualTableId);
        }
    }
}
