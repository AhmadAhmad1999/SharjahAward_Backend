using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System.Transactions;

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValue
{
    public class AddDynamicAttributeValueHandler : IRequestHandler<AddDynamicAttributeValueCommand,
        BaseResponse<AddDynamicAttributeValueResponse>>
    {
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        private readonly IAsyncRepository<ProvidedForm> _ProvidedFormClassRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassClassRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<Dependency> _DependencyRepository;
        private readonly IAsyncRepository<DependencyValidation> _DependencyValidationRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<GeneralValidation> _GeneralValidationRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public AddDynamicAttributeValueHandler(IAsyncRepository<EducationalClass> EducationalClassRepository,
            IAsyncRepository<ProvidedForm> ProvidedFormClassRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassClassRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<Dependency> DependencyRepository,
            IAsyncRepository<DependencyValidation> DependencyValidationRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<GeneralValidation> GeneralValidationRepository,
            IHttpContextAccessor HttpContextAccessor)
        {
            _EducationalClassRepository = EducationalClassRepository;
            _ProvidedFormClassRepository = ProvidedFormClassRepository;
            _CategoryEducationalClassClassRepository = CategoryEducationalClassClassRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DependencyRepository = DependencyRepository;
            _DependencyValidationRepository = DependencyValidationRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _GeneralValidationRepository = GeneralValidationRepository;
            _HttpContextAccessor = HttpContextAccessor;
        }
        public async Task<BaseResponse<AddDynamicAttributeValueResponse>> Handle(AddDynamicAttributeValueCommand Request, 
            CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            foreach (AddDynamicAttributeValueMainCommand InputDynamicAttributeWithValues in Request.DynamicAttributesWithValues)
            {
                DynamicAttribute? DynamicAttributeEntity = await _DynamicAttributeRepository
                    .IncludeThenFirstOrDefaultAsync(x => x.AttributeDataType!, x => x.Id == InputDynamicAttributeWithValues.DynamicAttributeId);

                if (DynamicAttributeEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Field is not found"
                        : "الحقل غير موجود";

                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 404);
                }

                if (!string.IsNullOrEmpty(InputDynamicAttributeWithValues.ValueAsString))
                {
                    // Unique Constraint..
                    DynamicAttributeValue? CheckUnique = await _DynamicAttributeValueRepository
                        .IncludeThenFirstOrDefaultAsync(x => x.DynamicAttribute!, x => x.DynamicAttributeId == DynamicAttributeEntity.Id &&
                            x.RecordId != Request.RecordId && x.DynamicAttribute!.IsUnique &&
                            x.Value.ToLower() == InputDynamicAttributeWithValues.ValueAsString.ToLower());

                    if (CheckUnique != null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? $"{DynamicAttributeEntity.EnglishLabel}'s value is already used, please insert a different value"
                            : $"قيمة هذا الحقل: {DynamicAttributeEntity.ArabicLabel} مستخدمة مسبقاً, الرجاء إدخال قيمة مختلفة";

                        return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                    }
                }

                // Check General Validation..
                GeneralValidation? GeneralValidationEntity = await _GeneralValidationRepository
                    .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!, x => x.DynamicAttributeId == InputDynamicAttributeWithValues.DynamicAttributeId);

                if (GeneralValidationEntity != null)
                {
                    string DataTypeAsName = DynamicAttributeEntity.AttributeDataType!.Name;
                    string? InputDynamicAttributeValueAsString = InputDynamicAttributeWithValues.ValueAsString;
                    string ValidationOperation = GeneralValidationEntity.AttributeOperation!.OperationAsString;
                    string? ValidationValue = GeneralValidationEntity.Value;

                    if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                        DataTypeAsName.ToLower() == "Email".ToLower() ||
                        DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                        DataTypeAsName.ToLower() == "List".ToLower() ||
                        DataTypeAsName.ToLower() == "Location".ToLower())
                    {
                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                        {
                            if (ValidationOperation == "!=")
                            {
                                if (!string.IsNullOrEmpty(ValidationValue) 
                                    ? InputDynamicAttributeValueAsString.ToLower() == ValidationValue!.ToLower()
                                    : false)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValueAsString}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValueAsString}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (!string.IsNullOrEmpty(ValidationValue) 
                                    ? InputDynamicAttributeValueAsString.ToLower() != ValidationValue!.ToLower()
                                    : false)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                        }
                        else
                        {
                            if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                        }
                    }
                    else if (DataTypeAsName.ToLower() == "Number".ToLower())
                    {
                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                        {
                            if (ValidationOperation == "!=")
                            {
                                if (InputDynamicAttributeValueAsString == ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValueAsString}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValueAsString}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (InputDynamicAttributeValueAsString != ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "<")
                            {
                                bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                    out int InputDynamicAttributeValueAsInteger);
                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputDynamicAttributeValueAsInteger >= GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "<=")
                            {
                                bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                    out int InputDynamicAttributeValueAsInteger);
                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == ">")
                            {
                                bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                    out int InputDynamicAttributeValueAsInteger);
                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputDynamicAttributeValueAsInteger <= GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == ">=")
                            {
                                bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                    out int InputDynamicAttributeValueAsInteger);
                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                        }
                        else
                        {
                            if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                        }
                    }
                    else if (DataTypeAsName.ToLower() == "Date".ToLower())
                    {
                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                        {
                            if (ValidationOperation == "!=")
                            {
                                if (InputDynamicAttributeValueAsString == ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValueAsString}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValueAsString}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (InputDynamicAttributeValueAsString != ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "<")
                            {
                                bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                    out DateOnly InputDynamicAttributeValueAsDateOnly);

                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputDynamicAttributeValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == "<=")
                            {
                                bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                    out DateOnly InputDynamicAttributeValueAsDateOnly);

                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == ">")
                            {
                                bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                    out DateOnly InputDynamicAttributeValueAsDateOnly);

                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputDynamicAttributeValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation == ">=")
                            {
                                bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                    out DateOnly InputDynamicAttributeValueAsDateOnly);

                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                        }
                        else
                        {
                            if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }
                            }
                        }
                    }
                    else if (DataTypeAsName.ToLower() == "Image".ToLower() ||
                        DataTypeAsName.ToLower() == "File".ToLower())
                    {
                        IFormFile? InputDynamicAttributeValueAsBinaryFile = InputDynamicAttributeWithValues.ValueAsBinaryFile;

                        if (ValidationOperation.ToLower() == "is Empty".ToLower())
                        {
                            if (InputDynamicAttributeValueAsBinaryFile is not null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                    : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                            }
                        }
                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                        {
                            if (InputDynamicAttributeValueAsBinaryFile is null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                    : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                            }
                        }
                    }
                }

                // Check Dependency Validation..
                if (DynamicAttributeEntity.LinkedToAnotherAttribute)
                {
                    List<IGrouping<int, Dependency>> DependenciesEntitiesGroupByGroupId = _DependencyRepository
                        .WhereThenInclude(x => x.MainDynamicAttributeId == InputDynamicAttributeWithValues.DynamicAttributeId,
                            x => x.AttributeOperation!, x => x.DynamicAttribute!, x => x.DynamicAttribute!.AttributeDataType!)
                        .GroupBy(x => x.DependencyGroupId).ToList();

                    foreach (IGrouping<int, Dependency> DependencyEntityGroupByGroupId in DependenciesEntitiesGroupByGroupId)
                    {
                        int CheckAllDependenciesInGroup = 0;
                        foreach (Dependency DependencyEntityInGroup in DependencyEntityGroupByGroupId.ToList())
                        {
                            string DataTypeAsName = DependencyEntityInGroup.DynamicAttribute!.AttributeDataType!.Name;

                            AddDynamicAttributeValueMainCommand? CheckIfDependencyValueIsInserted = Request.DynamicAttributesWithValues
                                .FirstOrDefault(x => x.DynamicAttributeId == DependencyEntityInGroup.DynamicAttributeId);

                            if (CheckIfDependencyValueIsInserted == null)
                                break;

                            string? InputDynamicAttributeValueAsString = CheckIfDependencyValueIsInserted.ValueAsString;

                            string DependencyOperation = DependencyEntityInGroup.AttributeOperation!.OperationAsString;
                            string DependencyValue = DependencyEntityInGroup.Value;

                            if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                                DataTypeAsName.ToLower() == "Email".ToLower() ||
                                DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                                DataTypeAsName.ToLower() == "List".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    if (DependencyOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValueAsString.ToLower() == DependencyValue.ToLower())
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "=")
                                    {
                                        if (InputDynamicAttributeValueAsString.ToLower() != DependencyValue.ToLower())
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                                else
                                {
                                    if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Number".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    if (DependencyOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValueAsString == DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "=")
                                    {
                                        if (InputDynamicAttributeValueAsString != DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                            out int InputDynamicAttributeValueAsInteger);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger >= GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<=")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger <= GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">=")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                                else
                                {
                                    if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Date".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    if (DependencyOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValueAsString == DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "=")
                                    {
                                        if (InputDynamicAttributeValueAsString != DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<=")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">=")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                                else
                                {
                                    if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Image".ToLower() ||
                                DataTypeAsName.ToLower() == "File".ToLower())
                            {
                                IFormFile? InputDynamicAttributeValueAsBinaryFile = CheckIfDependencyValueIsInserted.ValueAsBinaryFile;

                                if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (InputDynamicAttributeValueAsBinaryFile is not null)
                                        break;

                                    else
                                        CheckAllDependenciesInGroup++;
                                }
                                else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (InputDynamicAttributeValueAsBinaryFile is null)
                                        break;

                                    else
                                        CheckAllDependenciesInGroup++;
                                }
                            }
                        }

                        if (CheckAllDependenciesInGroup == DependencyEntityGroupByGroupId.ToList().Count())
                        {
                            string DataTypeAsName = DynamicAttributeEntity.AttributeDataType!.Name;
                            string? InputDynamicAttributeValueAsString = InputDynamicAttributeWithValues.ValueAsString;

                            DependencyValidation? DependencyValidationEntityForThisGroup = await _DependencyValidationRepository
                                .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!,
                                    x => x.DependencyGroupId == DependencyEntityGroupByGroupId.Key);

                            if (DependencyValidationEntityForThisGroup == null)
                                continue;

                            string ValidationOperation = DependencyValidationEntityForThisGroup!.AttributeOperation!.OperationAsString;
                            string ValidationValue = DependencyValidationEntityForThisGroup!.Value;

                            if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                                DataTypeAsName.ToLower() == "Email".ToLower() ||
                                DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                                DataTypeAsName.ToLower() == "List".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    if (ValidationOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValueAsString.ToLower() == ValidationValue.ToLower())
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValueAsString}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValueAsString}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputDynamicAttributeValueAsString.ToLower() != ValidationValue.ToLower())
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Number".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    if (ValidationOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValueAsString == ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValueAsString}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValueAsString}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputDynamicAttributeValueAsString != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "<")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger >= GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "<=")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == ">")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger <= GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == ">=")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValueAsString,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Date".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                {
                                    if (ValidationOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValueAsString == ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValueAsString}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValueAsString}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputDynamicAttributeValueAsString != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "<")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "<=")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == ">")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == ">=")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValueAsString,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                        }
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Image".ToLower() ||
                                DataTypeAsName.ToLower() == "File".ToLower())
                            {
                                IFormFile? InputDynamicAttributeValueAsBinaryFile = InputDynamicAttributeWithValues.ValueAsBinaryFile;

                                if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                {
                                    if (InputDynamicAttributeValueAsBinaryFile is not null)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                            : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                        return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (InputDynamicAttributeValueAsBinaryFile is null)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                    }
                                }
                            }
                        }
                    }
                }
            }

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    // Hard Delete On Dynamic Values..
                    List<DynamicAttributeValue> DynamicValuesToDelete = await _DynamicAttributeValueRepository
                        .Where(x => x.RecordId == Request.RecordId).ToListAsync();
                    
                    if (DynamicValuesToDelete.Count() > 0)
                        await _DynamicAttributeValueRepository.RemoveListAsync(DynamicValuesToDelete);

                    List<AddDynamicAttributeValueMainCommand> DynamicAttributesAsFile = Request.DynamicAttributesWithValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddDynamicAttributeValueMainCommand DynamicAttributeAsFile in DynamicAttributesAsFile)
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


                    DynamicAttribute? CheckIfThereisClassAttribute = _DynamicAttributeRepository
                        .Include(x => x.DynamicAttributeSection!)
                        .Include(x => x.DynamicAttributeSection!.AttributeTableName!)
                        .FirstOrDefault(x => x.Id == Request.DynamicAttributesWithValues[0].DynamicAttributeId);

                    if (CheckIfThereisClassAttribute is not null)
                    {
                        if (CheckIfThereisClassAttribute.DynamicAttributeSection!.AttributeTableName!.Name.ToLower() == "ProvidedForm".ToLower())
                        {
                            DynamicAttribute? ClassDynamicAttribute = await _DynamicAttributeRepository
                                .FirstOrDefaultAsync(x => Request.DynamicAttributesWithValues.Select(y => y.DynamicAttributeId)
                                    .Contains(x.Id) && x.EnglishLabel.ToLower() == "Class".ToLower());

                            if (ClassDynamicAttribute is not null)
                            {
                                string? StringValueForClass = Request.DynamicAttributesWithValues.FirstOrDefault(x => x.DynamicAttributeId == ClassDynamicAttribute.Id)!
                                    .ValueAsString;

                                EducationalClass? Classes = await _EducationalClassRepository
                                    .FirstOrDefaultAsync(x => x.EnglishName.ToLower() == StringValueForClass!.ToLower());

                                if (Classes is not null)
                                {
                                    ProvidedForm? ProvidedFormEntity = await _ProvidedFormClassRepository
                                        .FirstOrDefaultAsync(x => x.Id == Request.RecordId);

                                    CategoryEducationalClass NewCategoryEducationalClassEntity = new CategoryEducationalClass()
                                    {
                                        CategoryId = ProvidedFormEntity!.categoryId,
                                        EducationalClassId = Classes.Id
                                    };

                                    await _CategoryEducationalClassClassRepository.AddAsync(NewCategoryEducationalClassEntity);

                                    ProvidedFormEntity.CategoryEducationalClassId = NewCategoryEducationalClassEntity.Id;

                                    await _ProvidedFormClassRepository.UpdateAsync(ProvidedFormEntity);
                                }
                            }
                        }
                    }

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

            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, true, 200);
        }
    }
}
