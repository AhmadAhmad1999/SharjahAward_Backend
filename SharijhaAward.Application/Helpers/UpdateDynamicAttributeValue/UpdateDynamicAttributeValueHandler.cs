using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System.Transactions;

namespace SharijhaAward.Application.Helpers.UpdateDynamicAttributeValue
{
    public class UpdateDynamicAttributeValueHandler : IRequestHandler<UpdateDynamicAttributeValueCommand,
        BaseResponse<UpdateDynamicAttributeValueResponse>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<Dependency> _DependencyRepository;
        private readonly IAsyncRepository<DependencyValidation> _DependencyValidationRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<GeneralValidation> _GeneralValidationRepository;
        public UpdateDynamicAttributeValueHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<Dependency> DependencyRepository,
            IAsyncRepository<DependencyValidation> DependencyValidationRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<GeneralValidation> GeneralValidationRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DependencyRepository = DependencyRepository;
            _DependencyValidationRepository = DependencyValidationRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _GeneralValidationRepository = GeneralValidationRepository;
        }
        public async Task<BaseResponse<UpdateDynamicAttributeValueResponse>> Handle(UpdateDynamicAttributeValueCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            foreach (UpdateDynamicAttributeValueMainCommand InputDynamicAttributeWithValues in Request.DynamicAttributesWithValues)
            {
                DynamicAttribute? DynamicAttributeEntity = await _DynamicAttributeRepository
                    .IncludeThenFirstOrDefaultAsync(x => x.AttributeDataType!, x => x.Id == InputDynamicAttributeWithValues.DynamicAttributeId);

                if (DynamicAttributeEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Field is not found"
                        : "الحقل غير موجود";

                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 404);
                }

                if (!string.IsNullOrEmpty(InputDynamicAttributeWithValues.Value))
                {
                    // Unique Constraint..
                    DynamicAttributeValue? CheckUnique = await _DynamicAttributeValueRepository
                        .FirstOrDefaultAsync(x => x.DynamicAttributeId == DynamicAttributeEntity.Id &&
                            x.RecordId != Request.RecordId &&
                            x.Value.ToLower() == InputDynamicAttributeWithValues.Value.ToLower());

                    if (CheckUnique != null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? $"{DynamicAttributeEntity.EnglishLabel}'s value is already used, please insert a different value"
                            : $"قيمة هذا الحقل: {DynamicAttributeEntity.ArabicLabel} مستخدمة مسبقاً, الرجاء إدخال قيمة مختلفة";

                        return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 404);
                    }
                }

                // Check General Validation..
                GeneralValidation? GeneralValidationEntity = await _GeneralValidationRepository
                    .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!, x => x.DynamicAttributeId == InputDynamicAttributeWithValues.DynamicAttributeId);

                if (GeneralValidationEntity != null)
                {
                    string DataTypeAsName = DynamicAttributeEntity.AttributeDataType!.Name;
                    string? InputDynamicAttributeValue = InputDynamicAttributeWithValues.Value;
                    string ValidationOperation = GeneralValidationEntity.AttributeOperation!.OperationAsString;
                    string? ValidationValue = GeneralValidationEntity.Value;

                    if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                        DataTypeAsName.ToLower() == "Email".ToLower() ||
                        DataTypeAsName.ToLower() == "Image".ToLower() ||
                        DataTypeAsName.ToLower() == "File".ToLower() ||
                        DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                        DataTypeAsName.ToLower() == "List".ToLower())
                    {
                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                        {
                            if (ValidationOperation == "!=")
                            {
                                if (!string.IsNullOrEmpty(ValidationValue)
                                    ? InputDynamicAttributeValue.ToLower() == ValidationValue!.ToLower()
                                    : false)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValue}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValue}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (!string.IsNullOrEmpty(ValidationValue)
                                    ? InputDynamicAttributeValue.ToLower() != ValidationValue!.ToLower()
                                    : false)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                        }
                        else
                        {
                            if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                        }
                    }
                    else if (DataTypeAsName.ToLower() == "Number".ToLower())
                    {
                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                        {
                            if (ValidationOperation == "!=")
                            {
                                if (InputDynamicAttributeValue == ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValue}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValue}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (InputDynamicAttributeValue != ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == "<")
                            {
                                bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                    out int InputDynamicAttributeValueAsInteger);
                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputDynamicAttributeValueAsInteger >= GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == "<=")
                            {
                                bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                    out int InputDynamicAttributeValueAsInteger);
                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == ">")
                            {
                                bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                    out int InputDynamicAttributeValueAsInteger);
                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputDynamicAttributeValueAsInteger <= GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == ">=")
                            {
                                bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                    out int InputDynamicAttributeValueAsInteger);
                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }

                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsInteger}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                        }
                        else
                        {
                            if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                        }
                    }
                    else if (DataTypeAsName.ToLower() == "Date".ToLower())
                    {
                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                        {
                            if (ValidationOperation == "!=")
                            {
                                if (InputDynamicAttributeValue == ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValue}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValue}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == "=")
                            {
                                if (InputDynamicAttributeValue != ValidationValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == "<")
                            {
                                bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                    out DateOnly InputDynamicAttributeValueAsDateOnly);

                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputDynamicAttributeValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == "<=")
                            {
                                bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                    out DateOnly InputDynamicAttributeValueAsDateOnly);

                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == ">")
                            {
                                bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                    out DateOnly InputDynamicAttributeValueAsDateOnly);

                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputDynamicAttributeValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation == ">=")
                            {
                                bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                    out DateOnly InputDynamicAttributeValueAsDateOnly);

                                if (!CheckInputDynamicAttributeValue)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }

                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsDateOnly}"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                        }
                        else
                        {
                            if (ValidationOperation.ToLower() == "is Empty".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
                            }
                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                            {
                                if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                    return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                }
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

                            UpdateDynamicAttributeValueMainCommand? CheckIfDependencyValueIsInserted = Request.DynamicAttributesWithValues
                                .FirstOrDefault(x => x.DynamicAttributeId == DependencyEntityInGroup.DynamicAttributeId);

                            if (CheckIfDependencyValueIsInserted == null)
                                break;

                            string? InputDynamicAttributeValue = CheckIfDependencyValueIsInserted.Value;

                            string DependencyOperation = DependencyEntityInGroup.AttributeOperation!.OperationAsString;
                            string DependencyValue = DependencyEntityInGroup.Value;

                            if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                                DataTypeAsName.ToLower() == "Email".ToLower() ||
                                DataTypeAsName.ToLower() == "Image".ToLower() ||
                                DataTypeAsName.ToLower() == "File".ToLower() ||
                                DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                                DataTypeAsName.ToLower() == "List".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    if (DependencyOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValue.ToLower() == DependencyValue.ToLower())
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "=")
                                    {
                                        if (InputDynamicAttributeValue.ToLower() != DependencyValue.ToLower())
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                                else
                                {
                                    if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Number".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    if (DependencyOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValue == DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "=")
                                    {
                                        if (InputDynamicAttributeValue != DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                            out int InputDynamicAttributeValueAsInteger);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger >= GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<=")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        int.TryParse(DependencyValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger <= GeneralValidationValueAsInteger)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">=")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
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
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Date".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    if (DependencyOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValue == DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "=")
                                    {
                                        if (InputDynamicAttributeValue != DependencyValue)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == "<=")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        DateOnly.TryParse(DependencyValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation == ">=")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
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
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                    else if (DependencyOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                            break;

                                        else
                                            CheckAllDependenciesInGroup++;
                                    }
                                }
                            }
                        }

                        if (CheckAllDependenciesInGroup == DependencyEntityGroupByGroupId.ToList().Count())
                        {
                            string DataTypeAsName = DynamicAttributeEntity.AttributeDataType!.Name;
                            string? InputDynamicAttributeValue = InputDynamicAttributeWithValues.Value;

                            DependencyValidation? DependencyValidationEntityForThisGroup = await _DependencyValidationRepository
                                .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!,
                                    x => x.DependencyGroupId == DependencyEntityGroupByGroupId.Key);

                            if (DependencyValidationEntityForThisGroup == null)
                                continue;

                            string ValidationOperation = DependencyValidationEntityForThisGroup!.AttributeOperation!.OperationAsString;
                            string ValidationValue = DependencyValidationEntityForThisGroup!.Value;

                            if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                                DataTypeAsName.ToLower() == "Email".ToLower() ||
                                DataTypeAsName.ToLower() == "Image".ToLower() ||
                                DataTypeAsName.ToLower() == "File".ToLower() ||
                                DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                                DataTypeAsName.ToLower() == "List".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    if (ValidationOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValue.ToLower() == ValidationValue.ToLower())
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValue}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputDynamicAttributeValue.ToLower() != ValidationValue.ToLower())
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Number".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    if (ValidationOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValue == ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValue}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputDynamicAttributeValue != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == "<")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger >= GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == "<=")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == ">")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger <= GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == ">=")
                                    {
                                        bool CheckInputDynamicAttributeValue = int.TryParse(InputDynamicAttributeValue,
                                            out int InputDynamicAttributeValueAsInteger);
                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a number"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون رقم";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                }
                            }
                            else if (DataTypeAsName.ToLower() == "Date".ToLower())
                            {
                                if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                {
                                    if (ValidationOperation == "!=")
                                    {
                                        if (InputDynamicAttributeValue == ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be equal to: {InputDynamicAttributeValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون مساوية لهذه القيمة: {InputDynamicAttributeValue}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputDynamicAttributeValue != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == "<")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == "<=")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == ">")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation == ">=")
                                    {
                                        bool CheckInputDynamicAttributeValue = DateOnly.TryParse(InputDynamicAttributeValue,
                                            out DateOnly InputDynamicAttributeValueAsDateOnly);

                                        if (!CheckInputDynamicAttributeValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be a date"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون تاريخ";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                }
                                else
                                {
                                    if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValue))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, false, 422);
                                        }
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

                    await _DynamicAttributeValueRepository.RemoveListAsync(DynamicValuesToDelete);

                    // Add The New Values..

                    List<DynamicAttributeValue> DynamicAttributeValuesEntities = Request.DynamicAttributesWithValues
                        .Where(x => !string.IsNullOrEmpty(x.Value))
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
                            Value = x.Value!
                        }).ToList();

                    await _DynamicAttributeValueRepository.AddRangeAsync(DynamicAttributeValuesEntities);

                    Transaction.Complete();
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }

            ResponseMessage = Request.lang == "en"
                ? "Update successfully"
                : "تم تعديل قيم الحقول بنجاح";

            return new BaseResponse<UpdateDynamicAttributeValueResponse>(ResponseMessage, true, 200);
        }
    }
}
