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

namespace SharijhaAward.Application.Helpers.AddDynamicAttributeValue
{
    public class AddDynamicAttributeValueHandler : IRequestHandler<AddDynamicAttributeValueCommand,
        BaseResponse<AddDynamicAttributeValueResponse>>
    {
        private readonly IAsyncRepository<EducationalClass> _EducationalClassRepository;
        private readonly IAsyncRepository<ProvidedForm> _ProvidedFormRepository;
        private readonly IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<Dependency> _DependencyRepository;
        private readonly IAsyncRepository<DependencyValidation> _DependencyValidationRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<GeneralValidation> _GeneralValidationRepository;
        private readonly IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IAsyncRepository<CategoryEducationalEntity> _CategoryEducationalEntityRepository;
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<ViewWhenRelation> _ViewWhenRelationRepository;

        public AddDynamicAttributeValueHandler(IAsyncRepository<EducationalClass> EducationalClassRepository,
            IAsyncRepository<ProvidedForm> ProvidedFormRepository,
            IAsyncRepository<CategoryEducationalClass> CategoryEducationalClassRepository,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<Dependency> DependencyRepository,
            IAsyncRepository<DependencyValidation> DependencyValidationRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<GeneralValidation> GeneralValidationRepository,
            IAsyncRepository<DynamicAttributeTableValue> DynamicAttributeTableValueRepository,
            IHttpContextAccessor HttpContextAccessor,
            IAsyncRepository<CategoryEducationalEntity> CategoryEducationalEntityRepository,
            IAsyncRepository<EducationalEntity> EducationalEntityRepository,
            IAsyncRepository<ViewWhenRelation> ViewWhenRelationRepository)
        {
            _EducationalClassRepository = EducationalClassRepository;
            _ProvidedFormRepository = ProvidedFormRepository;
            _CategoryEducationalClassRepository = CategoryEducationalClassRepository;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DependencyRepository = DependencyRepository;
            _DependencyValidationRepository = DependencyValidationRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _GeneralValidationRepository = GeneralValidationRepository;
            _DynamicAttributeTableValueRepository = DynamicAttributeTableValueRepository;
            _HttpContextAccessor = HttpContextAccessor;
            _CategoryEducationalEntityRepository = CategoryEducationalEntityRepository;
            _EducationalEntityRepository = EducationalEntityRepository;
            _ViewWhenRelationRepository = ViewWhenRelationRepository;
        }
        public async Task<BaseResponse<AddDynamicAttributeValueResponse>> Handle(AddDynamicAttributeValueCommand Request, 
            CancellationToken cancellationToken)
        {
            if ((Request.DynamicAttributesWithValuesMobile != null && Request.ValueAsBinaryFiles != null)
                ? (Request.DynamicAttributesWithValuesMobile.Any() && Request.ValueAsBinaryFiles.Any()) : false)
            {
                for (int i = 0; i < Request.DynamicAttributesWithValuesMobile.Count(); i++)
                {
                    Request.DynamicAttributesWithValues.Add(new AddDynamicAttributeValueMainCommand()
                    {
                        DynamicAttributeId = Request.DynamicAttributesWithValuesMobile[i].DynamicAttributeId,
                        ValueAsBinaryFile = Request.ValueAsBinaryFiles[i]
                    });
                }
            }

            if ((Request.DynamicAttributesWithTableValuesMobile != null && Request.ValueAsBinaryFiles != null)
                ? (Request.DynamicAttributesWithTableValuesMobile.Any() && Request.ValueAsBinaryFiles.Any()) : false)
            {
                for (int i = 0; i < Request.DynamicAttributesWithTableValuesMobile.Count(); i++)
                {
                    Request.DynamicAttributesWithTableValues.Add(new AddDynamicAttributeTableValueMainCommand()
                    {
                        DynamicAttributeId = Request.DynamicAttributesWithTableValuesMobile[i].DynamicAttributeId,
                        ValueAsBinaryFile = Request.ValueAsBinaryFiles[i],
                        RowId = Request.DynamicAttributesWithTableValuesMobile[i].RowId
                    });
                }
            }

            string ResponseMessage = string.Empty;

            List<DynamicAttribute> DynamicAttributeEntities = await _DynamicAttributeRepository
                .Where(x => Request.DynamicAttributesWithValues.Select(y => y.DynamicAttributeId).Contains(x.Id) ||
                    Request.DynamicAttributesWithTableValues.Select(y => y.DynamicAttributeId).Contains(x.Id))
                .Include(x => x.AttributeDataType!)
                .Include(x => x.DynamicAttributeSection!)
                .ToListAsync();

            List<ViewWhenRelation> ViewWhenRelationEntities = await _ViewWhenRelationRepository
                .Where(x => DynamicAttributeEntities.Select(y => y.Id).Any(y => y == x.DynamicAttributeId))
                .ToListAsync();

            foreach (AddDynamicAttributeValueMainCommand InputDynamicAttributeWithValues in Request.DynamicAttributesWithValues)
            {
                DynamicAttribute? DynamicAttributeEntity = DynamicAttributeEntities
                    .FirstOrDefault(x => x.Id == InputDynamicAttributeWithValues.DynamicAttributeId);

                if (DynamicAttributeEntity == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "Field is not found"
                        : "الحقل غير موجود";

                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 404);
                }

                if (DynamicAttributeEntity.AttributeDataType!.Name == "Phone Number")
                {
                    if (!string.IsNullOrEmpty(InputDynamicAttributeWithValues.ValueAsString)
                        ? (!InputDynamicAttributeWithValues.ValueAsString.StartsWith("0097105") ||
                            InputDynamicAttributeWithValues.ValueAsString.Replace("0097105", string.Empty).Count() != 8)
                        : false)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? $"The field {DynamicAttributeEntity.EnglishTitle} can't has this value"
                            : $"الحقل {DynamicAttributeEntity.ArabicTitle} لا يمكن أن يحتوي على هذه القيمة";

                        return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                    }
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

                if (DynamicAttributeSection.MinNumberOfRows > NumberOfInputedRows)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"You must enter more than {DynamicAttributeSection.MinNumberOfRows} rows in the " +
                            $"{DynamicAttributeSection.EnglishName} section"
                        : $"يجب عليك إدخال عدد سطور أكثر من {DynamicAttributeSection.MinNumberOfRows} في قسم ال{DynamicAttributeSection.ArabicName}";

                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                }
                if (DynamicAttributeSection.MaxNumberOfRows != null
                    ? (DynamicAttributeSection.MaxNumberOfRows != 0 &&
                       DynamicAttributeSection.MaxNumberOfRows < NumberOfInputedRows) 
                    : false)
                {
                    ResponseMessage = Request.lang == "en"
                        ? $"You can't enter more than {DynamicAttributeSection.MaxNumberOfRows} rows in the " +
                            $"{DynamicAttributeSection.EnglishName} section"
                        : $"لا يمكنك إدخال عدد سطور أكثر من {DynamicAttributeSection.MaxNumberOfRows} في قسم ال{DynamicAttributeSection.ArabicName}";

                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                }
            }

            foreach (AddDynamicAttributeTableValueMainCommand InputDynamicAttributeWithValues in Request.DynamicAttributesWithTableValues)
            {
                if (InputDynamicAttributeWithValues.RowId != 0)
                {
                    DynamicAttribute? DynamicAttributeEntity = DynamicAttributeEntities
                        .FirstOrDefault(x => x.Id == InputDynamicAttributeWithValues.DynamicAttributeId);

                    if (DynamicAttributeEntity == null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Field is not found"
                            : "الحقل غير موجود";

                        return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 404);
                    }

                    if (DynamicAttributeEntity.AttributeDataType!.Name == "Phone Number")
                    {
                        if (!string.IsNullOrEmpty(InputDynamicAttributeWithValues.ValueAsString)
                            ? (!InputDynamicAttributeWithValues.ValueAsString.StartsWith("0097105") ||
                                InputDynamicAttributeWithValues.ValueAsString.Replace("0097105", string.Empty).Count() != 8)
                            : false)
                        {
                            ResponseMessage = Request.lang == "en"
                                ? $"The field {DynamicAttributeEntity.EnglishTitle} can't has this value"
                                : $"الحقل {DynamicAttributeEntity.ArabicTitle} لا يمكن أن يحتوي على هذه القيمة";

                            return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                        }
                    }

                    if (!string.IsNullOrEmpty(InputDynamicAttributeWithValues.ValueAsString))
                    {
                        // Unique Constraint..
                        DynamicAttributeTableValue? CheckUnique = await _DynamicAttributeTableValueRepository
                            .IncludeThenFirstOrDefaultAsync(x => x.DynamicAttribute!, x => x.DynamicAttributeId == DynamicAttributeEntity.Id &&
                                x.RowId == InputDynamicAttributeWithValues.RowId &&
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
            }

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    // Hard Delete On Dynamic Values..
                    List<DynamicAttributeValue> DynamicValuesToDelete = await _DynamicAttributeValueRepository
                        .Where(x => x.RecordId == Request.RecordId).ToListAsync();
                    
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

                    var RejectedDynamicValuesToDelete = DynamicValuesToDelete
                        .Where(x => x.isAccepted != null ? !x.isAccepted.Value : false)
                        .Select(x => x.DynamicAttributeId);

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
                            isAccepted = (RejectedDynamicValuesToDelete.FirstOrDefault(y => y == x.DynamicAttributeId) != 0
                                ? null : DynamicValuesToDelete.FirstOrDefault(y => y.DynamicAttributeId == x.DynamicAttributeId)
                                    ?.isAccepted ?? null),
                            ReasonForRejecting = DynamicValuesToDelete.FirstOrDefault(y => y.DynamicAttributeId == x.DynamicAttributeId)
                                ?.ReasonForRejecting ?? null
                        }).ToList();

                    await _DynamicAttributeValueRepository.AddRangeAsync(DynamicAttributeValuesEntities);

                    if (DynamicValuesToDelete.Count() > 0)
                        await _DynamicAttributeValueRepository.RemoveListAsync(DynamicValuesToDelete);
                    
                    List<DynamicAttributeTableValue> DynamicAttributeTableValueEnititiesToDelete = await _DynamicAttributeTableValueRepository
                        .Where(x => x.RecordId == Request.RecordId)
                        .ToListAsync();

                    if (DynamicAttributeTableValueEnititiesToDelete.Any())
                        await _DynamicAttributeTableValueRepository.RemoveListAsync(DynamicAttributeTableValueEnititiesToDelete);

                    List<AddDynamicAttributeTableValueMainCommand> DynamicAttributesTableValueAsFile = Request.DynamicAttributesWithTableValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddDynamicAttributeTableValueMainCommand DynamicAttributeAsFile in DynamicAttributesTableValueAsFile)
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

                    var RejectDynamicAttributeTableValueEnititiesToDelete = DynamicAttributeTableValueEnititiesToDelete
                        .Where(x => x.isAccepted != null ? !x.isAccepted.Value : false)
                        .Select(x => x.DynamicAttributeId);

                    List<DynamicAttributeTableValue> DynamicAttributeTableValueEntitiesToAdd = Request.DynamicAttributesWithTableValues
                        .Where(x => !string.IsNullOrEmpty(x.ValueAsString) && x.RowId != 0)
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
                            isAccepted = RejectDynamicAttributeTableValueEnititiesToDelete.FirstOrDefault(y => y == x.DynamicAttributeId) != 0
                                ? null 
                                : DynamicAttributeTableValueEnititiesToDelete
                                    .FirstOrDefault(y => y.DynamicAttributeId == x.DynamicAttributeId)?.isAccepted ?? null,
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

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 404);
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
