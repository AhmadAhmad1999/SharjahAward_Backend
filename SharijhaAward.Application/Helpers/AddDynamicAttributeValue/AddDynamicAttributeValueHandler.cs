using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryEducationalClassModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalClassModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EventModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System.Globalization;
using System.Net.Mail;
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
        private readonly IAsyncRepository<EducationalEntity> _EducationalEntityRepository;
        private readonly IAsyncRepository<ViewWhenRelation> _ViewWhenRelationRepository;
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        private readonly IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository;
        private readonly IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository;
        private IEmailSender _EmailSender;
        private IEmailCodesGenerator _QRCodeGenerator;
        private readonly IAsyncRepository<Event> _EventRepository;
        private readonly IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository;

        public AddDynamicAttributeValueHandler(IAsyncRepository<EducationalClass> _EducationalClassRepository,
            IAsyncRepository<ProvidedForm> _ProvidedFormRepository,
            IAsyncRepository<CategoryEducationalClass> _CategoryEducationalClassRepository,
            IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository,
            IAsyncRepository<Dependency> _DependencyRepository,
            IAsyncRepository<DependencyValidation> _DependencyValidationRepository,
            IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository,
            IAsyncRepository<GeneralValidation> _GeneralValidationRepository,
            IAsyncRepository<DynamicAttributeTableValue> _DynamicAttributeTableValueRepository,
            IHttpContextAccessor _HttpContextAccessor,
            IAsyncRepository<EducationalEntity> _EducationalEntityRepository,
            IAsyncRepository<ViewWhenRelation> _ViewWhenRelationRepository,
            IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository,
            IAsyncRepository<PersonalInviteeVirtualTable> _PersonalInviteeVirtualTableRepository,
            IAsyncRepository<GroupInviteeVirtualTable> _GroupInviteeVirtualTableRepository,
            IEmailSender _EmailSender,
            IEmailCodesGenerator _QRCodeGenerator,
            IAsyncRepository<Event> _EventRepository,
            IAsyncRepository<EducationalInstitution> _EducationalInstitutionRepository)
        {
            this._EducationalClassRepository = _EducationalClassRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._CategoryEducationalClassRepository = _CategoryEducationalClassRepository;
            this._DynamicAttributeRepository = _DynamicAttributeRepository;
            this._DependencyRepository = _DependencyRepository;
            this._DependencyValidationRepository = _DependencyValidationRepository;
            this._DynamicAttributeValueRepository = _DynamicAttributeValueRepository;
            this._GeneralValidationRepository = _GeneralValidationRepository;
            this._DynamicAttributeTableValueRepository = _DynamicAttributeTableValueRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
            this._EducationalEntityRepository = _EducationalEntityRepository;
            this._ViewWhenRelationRepository = _ViewWhenRelationRepository;
            this._DynamicAttributeListValueRepository = _DynamicAttributeListValueRepository;
            this._PersonalInviteeVirtualTableRepository = _PersonalInviteeVirtualTableRepository;
            this._GroupInviteeVirtualTableRepository = _GroupInviteeVirtualTableRepository;
            this._EmailSender = _EmailSender;
            this._QRCodeGenerator = _QRCodeGenerator;
            this._EventRepository = _EventRepository;
            this._EducationalInstitutionRepository = _EducationalInstitutionRepository;
        }
        public async Task<BaseResponse<AddDynamicAttributeValueResponse>> 
            Handle(AddDynamicAttributeValueCommand Request, CancellationToken cancellationToken)
        {
            int AttributeTableNameId = 0;
            int NumberOfExpectedAttendance = 0;
            if (Request.DynamicAttributesWithValues.Any())
            {
                DynamicAttribute? DynamicAttributeForAttributeTableNameId = await _DynamicAttributeRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.DynamicAttributesWithValues[0].DynamicAttributeId);

                if (DynamicAttributeForAttributeTableNameId is not null)
                    AttributeTableNameId = DynamicAttributeForAttributeTableNameId.DynamicAttributeSection!.AttributeTableNameId;

                AddDynamicAttributeValueMainCommand? NumberOfExpectedAttendanceRequest = Request.DynamicAttributesWithValues
                    .FirstOrDefault(x => x.DynamicAttributeId == -1);

                if (NumberOfExpectedAttendanceRequest is not null)
                    NumberOfExpectedAttendance = int.Parse(NumberOfExpectedAttendanceRequest.ValueAsString!);
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
                return new BaseResponse<AddDynamicAttributeValueResponse>("", false, 500);
            }

            int? CopyOfUniqueIntegerId = 0;
            GroupInviteeVirtualTable CheckGroupInviteeVirtualTable = null;

            if (Request.RecordId == 0 &&
                Request.InviteeType is not null)
            {
                if (Request.InviteeType == Domain.Constants.InviteeTypes.Personal)
                {
                    PersonalInviteeVirtualTable NewPersonalInviteeVirtualTableEntity = new PersonalInviteeVirtualTable();

                    IEnumerable<int> ListOfUniqueIntegerId = _PersonalInviteeVirtualTableRepository.ListAllAsync()
                        .Result.Select(x => x.UniqueIntegerId);

                    Random Random = new Random();
                    int UniqueIntegerId;
                    do
                    {
                        UniqueIntegerId = Random.Next(100000000, 999999999);
                    } while (ListOfUniqueIntegerId.Contains(UniqueIntegerId));

                    NewPersonalInviteeVirtualTableEntity.UniqueIntegerId = UniqueIntegerId;

                    await _PersonalInviteeVirtualTableRepository.AddAsync(NewPersonalInviteeVirtualTableEntity);

                    Request.RecordId = NewPersonalInviteeVirtualTableEntity.Id;

                    CopyOfUniqueIntegerId = UniqueIntegerId;
                }
                else
                {
                    GroupInviteeVirtualTable NewGroupInviteeVirtualTableEntity = new GroupInviteeVirtualTable();

                    IEnumerable<int> ListOfUniqueIntegerId = _GroupInviteeVirtualTableRepository.ListAllAsync()
                        .Result.Select(x => x.UniqueIntegerId);

                    Random Random = new Random();
                    int UniqueIntegerId;
                    do
                    {
                        UniqueIntegerId = Random.Next(100000000, 999999999);
                    } while (ListOfUniqueIntegerId.Contains(UniqueIntegerId));

                    NewGroupInviteeVirtualTableEntity.UniqueIntegerId = UniqueIntegerId;

                    await _GroupInviteeVirtualTableRepository.AddAsync(NewGroupInviteeVirtualTableEntity);

                    Request.RecordId = NewGroupInviteeVirtualTableEntity.Id;

                    CopyOfUniqueIntegerId = UniqueIntegerId;
                    CheckGroupInviteeVirtualTable = NewGroupInviteeVirtualTableEntity;
                }
            }

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

            if ((Request.DynamicAttributesWithTableValuesMobile != null && Request.ValueAsBinaryFilesForTable != null)
                ? (Request.DynamicAttributesWithTableValuesMobile.Any() && Request.ValueAsBinaryFilesForTable.Any()) : false)
            {
                for (int i = 0; i < Request.DynamicAttributesWithTableValuesMobile.Count(); i++)
                {
                    Request.DynamicAttributesWithTableValues.Add(new AddDynamicAttributeTableValueMainCommand()
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

            List<ViewWhenRelation> ViewWhenRelationEntities = await _ViewWhenRelationRepository
                .Where(x => DynamicAttributeEntities.Select(y => y.Id).Any(y => y == x.DynamicAttributeId))
                .ToListAsync();

            foreach (AddDynamicAttributeValueMainCommand InputDynamicAttributeWithValues in Request.DynamicAttributesWithValues)
            {
                if (InputDynamicAttributeWithValues.DynamicAttributeId != -1)
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
                        if (InputDynamicAttributeWithValues.ValueAsString != "0097105")
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
                        if (InputDynamicAttributeWithValues.ValueAsString != "0097105")
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
                    List<DynamicAttributeValue> DynamicValuesToDelete = await _DynamicAttributeValueRepository
                        .Where(x => x.RecordId == Request.RecordId &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == AttributeTableNameId &&
                            (Request.InviteeType != null
                                ? x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == Request.InviteeType
                                : true))
                        .ToListAsync();
                    
                    List<AddDynamicAttributeValueMainCommand> DynamicAttributesAsFile = Request.DynamicAttributesWithValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddDynamicAttributeValueMainCommand DynamicAttributeAsFile in DynamicAttributesAsFile)
                    {
                        string? FileName = $"{Request.RecordId}-{DynamicAttributeAsFile.ValueAsBinaryFile!.FileName}";

                        string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"{FileName}";

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = Path.Combine(FolderPathToCreate, FileName);

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
                        .Where(x => !string.IsNullOrEmpty(x.ValueAsString) &&
                            x.DynamicAttributeId != -1)
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
                        await _DynamicAttributeValueRepository.DeleteListAsync(DynamicValuesToDelete);
                    
                    List<DynamicAttributeTableValue> DynamicAttributeTableValueEnititiesToDelete = await _DynamicAttributeTableValueRepository
                        .Where(x => x.RecordId == Request.RecordId &&
                            x.DynamicAttribute!.DynamicAttributeSection!.AttributeTableNameId == AttributeTableNameId &&
                            (Request.InviteeType != null
                                ? x.DynamicAttribute!.DynamicAttributeSection!.InviteeType == Request.InviteeType
                                : true))
                        .ToListAsync();

                    if (DynamicAttributeTableValueEnititiesToDelete.Any())
                        await _DynamicAttributeTableValueRepository.DeleteListAsync(DynamicAttributeTableValueEnititiesToDelete);

                    List<AddDynamicAttributeTableValueMainCommand> DynamicAttributesTableValueAsFile = Request.DynamicAttributesWithTableValues
                        .Where(x => x.ValueAsBinaryFile != null).ToList();

                    foreach (AddDynamicAttributeTableValueMainCommand DynamicAttributeAsFile in DynamicAttributesTableValueAsFile)
                    {
                        string? FileName = $"{Request.RecordId}-{DynamicAttributeAsFile.ValueAsBinaryFile!.FileName}";

                        string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"{FileName}";

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = FolderPathToCreate + $"{FileName}";

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

                    if (Request.RecordId != 0 &&
                        Request.InviteeType is not null)
                    {
                        if (Request.InviteeType == Domain.Constants.InviteeTypes.Personal)
                        {
                            if (!string.IsNullOrEmpty(Request.lang)
                                ? Request.lang.ToLower() == "ar"
                                : false)
                            {
                                Event EventEntity = await _EventRepository.GetByIdAsync(Request.EventId);

                                // Generate BarCode..
                                string DataToSendIntoBarCode = $"{CopyOfUniqueIntegerId}";
                                string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.WWWRootFilePath!);

                                // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                                string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath!.Replace("/DynamicFiles", "") + "/QREmail_ar.html");

                                CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                                string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";

                                string DownloadedHTMLFilePath = Request.WWWRootFilePath + "/HTMLCodes/" + DownloadedHTMLFileName;

                                string DownloadBarCodeImageAPI = isHttps
                                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}"
                                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}";

                                DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                                    EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                                string ManipulatedBody = HTMLContent
                                    .Replace("$NewInvitee.Name$", "") // Invited Name..
                                    .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                                    .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                                    .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                                    .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy", ArabicCulture)) // Event Date..
                                    .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("hh:mm tt", ArabicCulture)) // Event Time..
                                    .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                                // Create An AlternateView to Specify The HTML Body And Embed The Image..
                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                                // Attach The Images As A Linked Resources..
                                LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                                AlternateView.LinkedResources.Add(BarCodeImage);

                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                                AlternateView.LinkedResources.Add(HeaderImage);

                                AddDynamicAttributeValueMainCommand? EmailRequestValue = Request.DynamicAttributesWithValues
                                    .FirstOrDefault(x => _DynamicAttributeRepository
                                        .FirstOrDefault(y => y.Id == x.DynamicAttributeId &&
                                            y.EnglishLabel == "Email" &&
                                            y.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                                            y.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId) != null);

                                if (EmailRequestValue is null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? "There is no email"
                                        : "لا يوجد إيميل";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                EmailRequest EmailRequest = new EmailRequest()
                                {
                                    ToEmail = EmailRequestValue.ValueAsString!,
                                    Subject = $"دعوة فردية لحضور {EventEntity.ArabicName}",
                                    Body = ManipulatedBody,
                                };

                                string BarCodeImageURL = isHttps
                                   ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}"
                                   : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}";

                                byte[] BarCodeImageImageBytes = await File.ReadAllBytesAsync(BarCodeImagePath);
                                string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                                byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath.Replace("/DynamicFiles", "") + "/assets/qr/header.png");
                                string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                                string ManipulatedBodyForPdf = ManipulatedBody
                                    .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                                    .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                                var ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                                ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

                                await _EmailSender.SendEmail(EmailRequest, AlternateView);
                                await File.WriteAllTextAsync(DownloadedHTMLFilePath, ManipulatedBodyForPdf, System.Text.Encoding.UTF8);
                            }
                            else
                            {
                                Event EventEntity = await _EventRepository.GetByIdAsync(Request.EventId);

                                CultureInfo EnglishCulture = new CultureInfo("en-US");

                                // Generate BarCode..
                                string DataToSendIntoBarCode = $"{CopyOfUniqueIntegerId}";
                                string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.WWWRootFilePath!);

                                // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                                string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath!.Replace("/DynamicFiles", "") + "/QREmail_en.html");

                                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                                string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";

                                string DownloadedHTMLFilePath = Request.WWWRootFilePath + "/HTMLCodes/" + DownloadedHTMLFileName;

                                string DownloadBarCodeImageAPI = isHttps
                                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}"
                                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}";

                                DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                                    EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                                string ManipulatedBody = HTMLContent
                                    .Replace("$NewInvitee.Name$", "") // Invited Name..
                                    .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                                    .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                                    .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                                    .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy", EnglishCulture)) // Event Date..
                                    .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("hh:mm tt", EnglishCulture))
                                    .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                                // Create An AlternateView to Specify The HTML Body And Embed The Image..
                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                                // Attach The Images As A Linked Resources..
                                LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                                AlternateView.LinkedResources.Add(BarCodeImage);

                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                                AlternateView.LinkedResources.Add(HeaderImage);

                                AddDynamicAttributeValueMainCommand? EmailRequestValue = Request.DynamicAttributesWithValues
                                    .FirstOrDefault(x => _DynamicAttributeRepository
                                        .FirstOrDefault(y => y.Id == x.DynamicAttributeId &&
                                            y.EnglishLabel == "Email" &&
                                            y.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                                            y.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId) != null);

                                if (EmailRequestValue is null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? "There is no email"
                                        : "لا يوجد إيميل";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                EmailRequest EmailRequest = new EmailRequest()
                                {
                                    ToEmail = EmailRequestValue.ValueAsString!,
                                    Subject = $"Personal Invitation to attend {EventEntity.EnglishName}",
                                    Body = ManipulatedBody,
                                };

                                string BarCodeImageURL = isHttps
                                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}"
                                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}";

                                byte[] BarCodeImageImageBytes = await File.ReadAllBytesAsync(BarCodeImagePath);
                                string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                                byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath.Replace("/DynamicFiles", "") + "/assets/qr/header.png");
                                string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                                string ManipulatedBodyForPdf = ManipulatedBody
                                    .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                                    .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                                var ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                                ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

                                await _EmailSender.SendEmail(EmailRequest, AlternateView);
                                await File.WriteAllTextAsync(DownloadedHTMLFilePath, ManipulatedBodyForPdf, System.Text.Encoding.UTF8);

                                Transaction.Complete();
                            }
                        }
                        else
                        {
                            if (!string.IsNullOrEmpty(Request.lang)
                                ? Request.lang.ToLower() == "ar"
                                : false)
                            {
                                Event EventEntity = await _EventRepository.GetByIdAsync(Request.EventId);

                                // Generate BarCode..
                                string DataToSendIntoBarCode = $"{CopyOfUniqueIntegerId}";
                                string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.WWWRootFilePath!);

                                // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                                string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath.Replace("/DynamicFiles", "") + "/QREmail_ar.html");

                                CultureInfo ArabicCulture = new CultureInfo("ar-SY");

                                bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;
                                string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";

                                string DownloadedHTMLFilePath = Request.WWWRootFilePath + "/HTMLCodes/" + DownloadedHTMLFileName;

                                string DownloadBarCodeImageAPI = isHttps
                                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}"
                                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}";

                                string ManipulatedBody = HTMLContent
                                    .Replace("$NewInvitee.Name$", "") // Invited Name..
                                    .Replace("$EventEntity.ArabicName$", EventEntity.ArabicName, StringComparison.Ordinal) // Event Name in Arabic..
                                    .Replace("$EventEntity.ArabicLocation$", EventEntity.ArabicSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                                    .Replace("$EventEntity.StartDate.DayOfWeek$", EventEntity.EventDate.ToString("dddd", ArabicCulture), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                                    .Replace("$EventEntity.StartDate.Date$", EventEntity.EventDate.ToString("d/M/yyyy", ArabicCulture), StringComparison.Ordinal) // Event Date..
                                    .Replace("$EventEntity.StartDate.TimeOfDay$", EventEntity.EventDate.ToString("HH:mm tt", ArabicCulture), StringComparison.Ordinal) // Event Time..
                                    .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                                // Create An AlternateView to Specify The HTML Body And Embed The Image..
                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                                // Attach The Images As A Linked Resources..
                                LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                                AlternateView.LinkedResources.Add(BarCodeImage);

                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                                AlternateView.LinkedResources.Add(HeaderImage);

                                AddDynamicAttributeValueMainCommand? EmailRequestValue = Request.DynamicAttributesWithValues
                                    .FirstOrDefault(x => _DynamicAttributeRepository
                                        .FirstOrDefault(y => y.Id == x.DynamicAttributeId &&
                                            y.EnglishLabel == "Email (Student Supervisor)" &&
                                            y.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                                            y.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId) != null);

                                if (EmailRequestValue is null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? "There is no email"
                                        : "لا يوجد إيميل";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                EmailRequest EmailRequest = new EmailRequest()
                                {
                                    ToEmail = EmailRequestValue.ValueAsString!,
                                    Subject = $"دعوة جماعية لحضور {EventEntity.ArabicName}",
                                    Body = ManipulatedBody,
                                };

                                string BarCodeImageURL = isHttps
                                   ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}"
                                   : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}";

                                byte[] BarCodeImageImageBytes = await File.ReadAllBytesAsync(BarCodeImagePath);
                                string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                                byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath.Replace("/DynamicFiles", "") + "/assets/qr/header.png");
                                string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                                string ManipulatedBodyForPdf = ManipulatedBody
                                    .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                                    .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                                List<string>? ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                                ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

                                await _EmailSender.SendEmail(EmailRequest, AlternateView);
                                await File.WriteAllTextAsync(DownloadedHTMLFilePath, ManipulatedBodyForPdf, System.Text.Encoding.UTF8);
                            }
                            else
                            {
                                Event EventEntity = await _EventRepository.GetByIdAsync(Request.EventId);

                                CultureInfo EnglishCulture = new CultureInfo("en-US");

                                // Generate BarCode..
                                string DataToSendIntoBarCode = $"{CopyOfUniqueIntegerId}";
                                string BarCodeImagePath = _QRCodeGenerator.GenerateBarCode(DataToSendIntoBarCode, Request.WWWRootFilePath!);

                                // After Generating The QR Code Image, We Have To Send It With The HTML File in (QREmail) Folder..
                                string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath.Replace("/DynamicFiles", "") + "/QREmail_en.html");

                                bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                                string DownloadedHTMLFileName = Guid.NewGuid().ToString() + ".html";

                                string DownloadedHTMLFilePath = Request.WWWRootFilePath + "/HTMLCodes/" + DownloadedHTMLFileName;

                                string DownloadBarCodeImageAPI = isHttps
                                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}"
                                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/api/Event/DownloadTempletAsPdf?htmlFile={DownloadedHTMLFileName}";

                                DateTime GregorianDate = new DateTime(EventEntity.EventDate.Year, EventEntity.EventDate.Month,
                                    EventEntity.EventDate.Day, EventEntity.EventDate.Hour, EventEntity.EventDate.Minute, EventEntity.EventDate.Second);

                                string ManipulatedBody = HTMLContent
                                    .Replace("$NewInvitee.Name$", "") // Invited Name..
                                    .Replace("$EventEntity.EnglishName$", EventEntity.EnglishName, StringComparison.Ordinal) // Event Name in English..
                                    .Replace("$EventEntity.EnglishLocation$", EventEntity.EnglishSiteName, StringComparison.Ordinal) // Event Day (ex: Sunday)..
                                    .Replace("$EventEntity.StartDate.DayOfWeek$", GregorianDate.DayOfWeek.ToString(), StringComparison.Ordinal) // Event Day (ex: Sunday)..
                                    .Replace("$EventEntity.StartDate.Date$", GregorianDate.ToString("d/M/yyyy", EnglishCulture)) // Event Date..
                                    .Replace("$EventEntity.StartDate.TimeOfDay$", GregorianDate.ToString("hh:mm tt", EnglishCulture)) // Event Time..
                                    .Replace("$DownloadBarCodeAPI$", DownloadBarCodeImageAPI); // Download Bar Code Image API..

                                // Create An AlternateView to Specify The HTML Body And Embed The Image..
                                AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(ManipulatedBody, null, "text/html");

                                // Attach The Images As A Linked Resources..
                                LinkedResource BarCodeImage = new LinkedResource(BarCodeImagePath) { ContentId = "BarCodeImage" }; // Bar Code Image..
                                AlternateView.LinkedResources.Add(BarCodeImage);

                                LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                                AlternateView.LinkedResources.Add(HeaderImage);

                                AddDynamicAttributeValueMainCommand? EmailRequestValue = Request.DynamicAttributesWithValues
                                    .FirstOrDefault(x => _DynamicAttributeRepository
                                        .FirstOrDefault(y => y.Id == x.DynamicAttributeId &&
                                            y.EnglishLabel == "Email" &&
                                            y.DynamicAttributeSection!.AttributeTableNameId == 4 &&
                                            y.DynamicAttributeSection!.RecordIdOnRelation == Request.EventId) != null);

                                if (EmailRequestValue is null)
                                {
                                    ResponseMessage = Request.lang == "en"
                                        ? "There is no email"
                                        : "لا يوجد إيميل";

                                    return new BaseResponse<AddDynamicAttributeValueResponse>(ResponseMessage, false, 400);
                                }

                                EmailRequest EmailRequest = new EmailRequest()
                                {
                                    ToEmail = EmailRequestValue.ValueAsString!,
                                    Subject = $"Group Invitation to attend {EventEntity.EnglishName}",
                                    Body = ManipulatedBody,
                                };

                                string BarCodeImageURL = isHttps
                                  ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}"
                                  : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/GeneratedBarcode/{BarCodeImagePath.Split('\\').LastOrDefault()}";

                                byte[] BarCodeImageImageBytes = await File.ReadAllBytesAsync(BarCodeImagePath);
                                string BarCodeImagebase64String = Convert.ToBase64String(BarCodeImageImageBytes);

                                byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath.Replace("/DynamicFiles", "") + "/assets/qr/header.png");
                                string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                                string ManipulatedBodyForPdf = ManipulatedBody
                                    .Replace("\"cid:BarCodeImage\"", $"'data:image/png;base64,{BarCodeImagebase64String}'")
                                    .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                                var ManipulatedBodyForPdfSpliter = ManipulatedBodyForPdf.Split("<!--here-->").ToList();
                                ManipulatedBodyForPdf = ManipulatedBodyForPdfSpliter[0] + ManipulatedBodyForPdfSpliter[2];

                                await _EmailSender.SendEmail(EmailRequest, AlternateView);
                                await File.WriteAllTextAsync(DownloadedHTMLFilePath, ManipulatedBodyForPdf, System.Text.Encoding.UTF8);
                            }

                            if (CheckGroupInviteeVirtualTable is null)
                            {
                                GroupInviteeVirtualTable? GroupInviteeVirtualTableEntity = await _GroupInviteeVirtualTableRepository
                                    .FirstOrDefaultAsync(x => x.Id == Request.RecordId);

                                if (GroupInviteeVirtualTableEntity is not null)
                                {
                                    GroupInviteeVirtualTableEntity.NumberOfExpectedAttendance = NumberOfExpectedAttendance;

                                    await _GroupInviteeVirtualTableRepository.UpdateAsync(GroupInviteeVirtualTableEntity);
                                }
                            }
                            else
                            {
                                CheckGroupInviteeVirtualTable.NumberOfExpectedAttendance = NumberOfExpectedAttendance;

                                await _GroupInviteeVirtualTableRepository.UpdateAsync(CheckGroupInviteeVirtualTable);
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
