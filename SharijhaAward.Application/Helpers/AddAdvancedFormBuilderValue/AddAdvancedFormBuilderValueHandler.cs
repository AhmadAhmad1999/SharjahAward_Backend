using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using System.Transactions;

namespace SharijhaAward.Application.Helpers.AddAdvancedFormBuilderValue
{
    public class AddAdvancedFormBuilderValueHandler : IRequestHandler<AddAdvancedFormBuilderValueCommand,
        BaseResponse<AddAdvancedFormBuilderValueResponse>>
    {
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependency> _AdvancedFormBuilderDependencyRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderDependencyValidation> _AdvancedFormBuilderDependencyValidationRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderValue> _AdvancedFormBuilderValueRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderGeneralValidation> _AdvancedFormBuilderGeneralValidationRepository;
        private readonly IAsyncRepository<AdvancedFormBuilderTableValue> _AdvancedFormBuilderTableValueRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public AddAdvancedFormBuilderValueHandler(IAsyncRepository<EducationalClass> EducationalClassRepository,
            IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository,
            IAsyncRepository<AdvancedFormBuilderDependency> AdvancedFormBuilderDependencyRepository,
            IAsyncRepository<AdvancedFormBuilderDependencyValidation> AdvancedFormBuilderDependencyValidationRepository,
            IAsyncRepository<AdvancedFormBuilderValue> AdvancedFormBuilderValueRepository,
            IAsyncRepository<AdvancedFormBuilderGeneralValidation> AdvancedFormBuilderGeneralValidationRepository,
            IAsyncRepository<AdvancedFormBuilderTableValue> AdvancedFormBuilderTableValueRepository,
            IHttpContextAccessor HttpContextAccessor)
        {
            _EducationalClassRepository = EducationalClassRepository;
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
            _AdvancedFormBuilderDependencyRepository = AdvancedFormBuilderDependencyRepository;
            _AdvancedFormBuilderDependencyValidationRepository = AdvancedFormBuilderDependencyValidationRepository;
            _AdvancedFormBuilderValueRepository = AdvancedFormBuilderValueRepository;
            _AdvancedFormBuilderGeneralValidationRepository = AdvancedFormBuilderGeneralValidationRepository;
            _AdvancedFormBuilderTableValueRepository = AdvancedFormBuilderTableValueRepository;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<BaseResponse<AddAdvancedFormBuilderValueResponse>> Handle(AddAdvancedFormBuilderValueCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<AdvancedFormBuilder> AdvancedFormBuilderEntities = await _AdvancedFormBuilderRepository
                .Where(x => Request.AdvancedFormBuildersWithValues.Select(y => y.AdvancedFormBuilderId).Contains(x.Id) ||
                    Request.AdvancedFormBuildersWithTableValues.Select(y => y.AdvancedFormBuilderId).Contains(x.Id))
                .ToListAsync();

            foreach (AddAdvancedFormBuilderValueMainCommand InputAdvancedFormBuilderWithValues in Request.AdvancedFormBuildersWithValues)
            {
                AdvancedFormBuilder? AdvancedFormBuilderEntity = AdvancedFormBuilderEntities
                    .FirstOrDefault(x => x.Id == InputAdvancedFormBuilderWithValues.AdvancedFormBuilderId);

                if (AdvancedFormBuilderEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Field is not found"
                        : "الحقل غير موجود";

                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 404);
                }

                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderWithValues.ValueAsString))
                {
                    // Unique Constraint..
                    AdvancedFormBuilderValue? CheckUnique = await _AdvancedFormBuilderValueRepository
                        .IncludeThenFirstOrDefaultAsync(x => x.AdvancedFormBuilder!, x => x.AdvancedFormBuilderId == AdvancedFormBuilderEntity.Id &&
                            x.VirtualTableId != Request.VirtualTableId && x.AdvancedFormBuilder!.IsUnique &&
                            x.Value.ToLower() == InputAdvancedFormBuilderWithValues.ValueAsString.ToLower());

                    if (CheckUnique != null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value is already used, please insert a different value"
                            : $"قيمة هذا الحقل: {AdvancedFormBuilderEntity.ArabicLabel} مستخدمة مسبقاً, الرجاء إدخال قيمة مختلفة";

                        return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger >= GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger > GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger <= GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger > GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                            }
                        }
                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                        {
                            if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                            }
                        }
                    }
                }

                // Check AdvancedFormBuilderDependency Validation..
                if (AdvancedFormBuilderEntity.LinkedToAnotherAttribute)
                {
                    List<IGrouping<int, AdvancedFormBuilderDependency>> DependenciesEntitiesGroupByGroupId = _AdvancedFormBuilderDependencyRepository
                        .WhereThenInclude(x => x.MainAdvancedFormBuilderId == InputAdvancedFormBuilderWithValues.AdvancedFormBuilderId,
                            x => x.AttributeOperation!, x => x.AdvancedFormBuilder!, x => x.AdvancedFormBuilder!.AttributeDataType!)
                        .GroupBy(x => x.AdvancedFormBuilderDependencyGroupId).ToList();

                    foreach (IGrouping<int, AdvancedFormBuilderDependency> DependencyEntityGroupByGroupId in DependenciesEntitiesGroupByGroupId)
                    {
                        int CheckAllDependenciesInGroup = 0;
                        foreach (AdvancedFormBuilderDependency DependencyEntityInGroup in DependencyEntityGroupByGroupId.ToList())
                        {
                            string DataTypeAsName = DependencyEntityInGroup.AdvancedFormBuilder!.AttributeDataType!.Name;

                            AddAdvancedFormBuilderValueMainCommand? CheckIfDependencyValueIsInserted = Request.AdvancedFormBuildersWithValues
                                .FirstOrDefault(x => x.AdvancedFormBuilderId == DependencyEntityInGroup.AdvancedFormBuilderId);

                            if (CheckIfDependencyValueIsInserted == null)
                                break;

                            string? InputAdvancedFormBuilderValueAsString = CheckIfDependencyValueIsInserted.ValueAsString;

                            string DependencyOperation = DependencyEntityInGroup.AttributeOperation!.OperationAsString;
                            string DependencyValue = DependencyEntityInGroup.Value;

                            if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                                DataTypeAsName.ToLower() == "Email".ToLower() ||
                                DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                                DataTypeAsName.ToLower() == "List".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    if (DependencyOperation == "!=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString.ToLower() == DependencyValue.ToLower())
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString.ToLower() != DependencyValue.ToLower())
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                                else
                                {
                                    if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
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
                                    if (DependencyOperation == "!=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString == DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString != DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger >= GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);
                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger > GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);
                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger <= GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = int.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out int InputAdvancedFormBuilderValueAsInteger);
                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger > GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                                else
                                {
                                    if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
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
                                    if (DependencyOperation == "!=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString == DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString != DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">=")
                                    {
                                        bool CheckInputAdvancedFormBuilderValue = DateOnly.TryParse(InputAdvancedFormBuilderValueAsString,
                                            out DateOnly InputAdvancedFormBuilderValueAsDateOnly);

                                        if (!CheckInputAdvancedFormBuilderValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                                else
                                {
                                    if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
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
                                IFormFile? InputAdvancedFormBuilderValueAsBinaryFile = CheckIfDependencyValueIsInserted.ValueAsBinaryFile;

                                if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (InputAdvancedFormBuilderValueAsBinaryFile is not null)
                                        break;

                                    else
                                        CheckAllDependenciesInGroup++;
                                }
                                else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                                        break;

                                    else
                                        CheckAllDependenciesInGroup++;
                                }
                            }
                        }

                        if (CheckAllDependenciesInGroup == DependencyEntityGroupByGroupId.ToList().Count())
                        {
                            string DataTypeAsName = AdvancedFormBuilderEntity.AttributeDataType!.Name;
                            string? InputAdvancedFormBuilderValueAsString = InputAdvancedFormBuilderWithValues.ValueAsString;

                            AdvancedFormBuilderDependencyValidation? DependencyValidationEntityForThisGroup = await _AdvancedFormBuilderDependencyValidationRepository
                                .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!,
                                    x => x.AdvancedFormBuilderDependencyGroupId == DependencyEntityGroupByGroupId.Key);

                            if (DependencyValidationEntityForThisGroup == null)
                                continue;

                            string ValidationOperation = DependencyValidationEntityForThisGroup!.AttributeOperation!.OperationAsString;
                            string ValidationValue = DependencyValidationEntityForThisGroup!.Value;

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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString.ToLower() != ValidationValue.ToLower())
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger >= GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger > GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger <= GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger > GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                        return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            foreach (AddAdvancedFormBuilderTableValueMainCommand InputAdvancedFormBuilderWithValues in Request.AdvancedFormBuildersWithTableValues)
            {
                AdvancedFormBuilder? AdvancedFormBuilderEntity = AdvancedFormBuilderEntities
                    .FirstOrDefault(x => x.Id == InputAdvancedFormBuilderWithValues.AdvancedFormBuilderId);

                if (AdvancedFormBuilderEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Field is not found"
                        : "الحقل غير موجود";

                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 404);
                }

                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderWithValues.ValueAsString))
                {
                    // Unique Constraint..
                    AdvancedFormBuilderTableValue? CheckUnique = await _AdvancedFormBuilderTableValueRepository
                        .IncludeThenFirstOrDefaultAsync(x => x.AdvancedFormBuilder!, x => x.AdvancedFormBuilderId == AdvancedFormBuilderEntity.Id &&
                            x.RowId == InputAdvancedFormBuilderWithValues.RowId &&
                            x.VirtualTableId != Request.VirtualTableId && x.AdvancedFormBuilder!.IsUnique &&
                            x.Value.ToLower() == InputAdvancedFormBuilderWithValues.ValueAsString.ToLower());

                    if (CheckUnique != null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value is already used, please insert a different value"
                            : $"قيمة هذا الحقل: {AdvancedFormBuilderEntity.ArabicLabel} مستخدمة مسبقاً, الرجاء إدخال قيمة مختلفة";

                        return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger >= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger <= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly >= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly <= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                            }
                        }
                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                        {
                            if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                    : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                            }
                        }
                    }
                }

                // Check AdvancedFormBuilderDependency Validation..
                if (AdvancedFormBuilderEntity.LinkedToAnotherAttribute)
                {
                    List<IGrouping<int, AdvancedFormBuilderDependency>> DependenciesEntitiesGroupByGroupId = _AdvancedFormBuilderDependencyRepository
                        .WhereThenInclude(x => x.MainAdvancedFormBuilderId == InputAdvancedFormBuilderWithValues.AdvancedFormBuilderId,
                            x => x.AttributeOperation!, x => x.AdvancedFormBuilder!, x => x.AdvancedFormBuilder!.AttributeDataType!)
                        .GroupBy(x => x.AdvancedFormBuilderDependencyGroupId).ToList();

                    foreach (IGrouping<int, AdvancedFormBuilderDependency> AdvancedFormBuilderDependencyEntityGroupByGroupId in DependenciesEntitiesGroupByGroupId)
                    {
                        int CheckAllDependenciesInGroup = 0;
                        foreach (AdvancedFormBuilderDependency AdvancedFormBuilderDependencyEntityInGroup in AdvancedFormBuilderDependencyEntityGroupByGroupId.ToList())
                        {
                            string DataTypeAsName = AdvancedFormBuilderDependencyEntityInGroup.AdvancedFormBuilder!.AttributeDataType!.Name;

                            AddAdvancedFormBuilderValueMainCommand? CheckIfAdvancedFormBuilderDependencyValueIsInserted = Request.AdvancedFormBuildersWithValues
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString.ToLower() != ValidationValue.ToLower())
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger >= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger <= AdvancedFormBuilderGeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int AdvancedFormBuilderGeneralValidationValueAsInteger);

                                        if (InputAdvancedFormBuilderValueAsInteger > AdvancedFormBuilderGeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputAdvancedFormBuilderValueAsString != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly >= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be smaller than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly <= AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر من: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly AdvancedFormBuilderGeneralValidationValueAsDateOnly);

                                        if (InputAdvancedFormBuilderValueAsDateOnly > AdvancedFormBuilderGeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value must be bigger than or equal to: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {AdvancedFormBuilderGeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputAdvancedFormBuilderValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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

                                        return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (InputAdvancedFormBuilderValueAsBinaryFile is null)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{AdvancedFormBuilderEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {AdvancedFormBuilderEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, false, 400);
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
                        .Where(x => x.VirtualTableId == Request.VirtualTableId).ToListAsync();

                    if (DynamicValuesToDelete.Count() > 0)
                        await _AdvancedFormBuilderValueRepository.DeleteListAsync(DynamicValuesToDelete);

                    List<AddAdvancedFormBuilderValueMainCommand> AdvancedFormBuildersAsFile = Request.AdvancedFormBuildersWithValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddAdvancedFormBuilderValueMainCommand AdvancedFormBuilderAsFile in AdvancedFormBuildersAsFile)
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

                    List<AddAdvancedFormBuilderTableValueMainCommand> AdvancedFormBuildersTableValueAsFile = Request.AdvancedFormBuildersWithTableValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddAdvancedFormBuilderTableValueMainCommand AdvancedFormBuilderAsFile in AdvancedFormBuildersTableValueAsFile)
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

            return new BaseResponse<AddAdvancedFormBuilderValueResponse>(ResponseMessage, true, 200);
        }
    }
}
