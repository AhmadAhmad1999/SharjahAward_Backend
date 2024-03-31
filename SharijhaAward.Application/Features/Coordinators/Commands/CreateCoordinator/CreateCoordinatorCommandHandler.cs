using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Helpers.AddDynamicAttributeValue;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using SharijhaAward.Domain.Entities.EducationalEntityModel;
using SharijhaAward.Domain.Entities.EducationalInstitutionModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinator
{
    public class CreateCoordinatorCommandHandler
         : IRequestHandler<CreateCoordinatorCommand, BaseResponse<Guid>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IAsyncRepository<EduInstitutionCoordinator> _EduInstitutionCoordinatorRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        private readonly IAsyncRepository<Dependency> _DependencyRepository;
        private readonly IAsyncRepository<DependencyValidation> _DependencyValidationRepository;
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        private readonly IAsyncRepository<GeneralValidation> _GeneralValidationRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public CreateCoordinatorCommandHandler(IRoleRepository roleRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository,
            IAsyncRepository<EduInstitutionCoordinator> EduInstitutionCoordinatorRepository,
            IAsyncRepository<Coordinator> coordinatorRepository, 
            IFileService fileService, 
            IUserRepository userRepository, 
            IMapper Mapper,
            IAsyncRepository<DynamicAttribute> DynamicAttributeRepository,
            IAsyncRepository<Dependency> DependencyRepository,
            IAsyncRepository<DependencyValidation> DependencyValidationRepository,
            IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository,
            IAsyncRepository<GeneralValidation> GeneralValidationRepository,
            IHttpContextAccessor HttpContextAccessor)
        {
            _roleRepository = roleRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
            _EduInstitutionCoordinatorRepository = EduInstitutionCoordinatorRepository;
            _coordinatorRepository = coordinatorRepository;
            _userRepository = userRepository;
            _fileService = fileService;
            _mapper = Mapper;
            _DynamicAttributeRepository = DynamicAttributeRepository;
            _DependencyRepository = DependencyRepository;
            _DependencyValidationRepository = DependencyValidationRepository;
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
            _GeneralValidationRepository = GeneralValidationRepository;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<BaseResponse<Guid>> Handle(CreateCoordinatorCommand Request, CancellationToken cancellationToken)
        {
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
                    string ResponseMessage = string.Empty;

                    Domain.Entities.IdentityModels.User? CheckEmailIfAlreadyUsedInUser = await _userRepository
                        .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower() && x.isValidAccount);

                    if (CheckEmailIfAlreadyUsedInUser is not null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Invalid email or password"
                            : "خطأ في البريد الإلكتروني او كلمة المرور";

                        return new BaseResponse<Guid>(ResponseMessage, false, 400);
                    }

                    Coordinator? CheckEmailIfAlreadyUsedInCoordinator = await _coordinatorRepository
                        .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

                    if (CheckEmailIfAlreadyUsedInCoordinator is not null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Invalid email or password"
                            : "خطأ في البريد الإلكتروني او كلمة المرور";

                        return new BaseResponse<Guid>(ResponseMessage, false, 400);
                    }

                    var User = new Domain.Entities.IdentityModels.User()
                    {
                        ArabicName = Request.ArabicName,
                        EnglishName = Request.EnglishName,
                        Email = Request.Email,
                        PhoneNumber = Request.PhoneNumber,
                        //ConfirmationCode = 0000,
                        Password = "123456",
                        Gender = 0,
                        isValidAccount = true
                    };
                    await _userRepository.AddAsync(User);

                    var role = await _roleRepository.GetByName("Coordinator");
                    if (role != null)
                    {
                        await _userRepository.AsignRole(User.Id, role.RoleId);
                    }

                    var Coordinator = _mapper.Map<Coordinator>(Request);
                    Coordinator.Id = User.Id;
                    Coordinator.PersonalPhoto = await _fileService.SaveFileAsync(Request.PersonalPhoto);

                    var data = await _coordinatorRepository.AddAsync(Coordinator);
                    
                    foreach (AddDynamicAttributeValueMainCommand InputDynamicAttributeWithValues in Request.DynamicAttributesWithValues)
                    {
                        DynamicAttribute? DynamicAttributeEntity = await _DynamicAttributeRepository
                            .IncludeThenFirstOrDefaultAsync(x => x.AttributeDataType!, 
                                x => x.Id == InputDynamicAttributeWithValues.DynamicAttributeId);

                        if (DynamicAttributeEntity == null)
                        {
                            ResponseMessage = Request.lang == "en"
                                ? "Field is not found"
                                : "الحقل غير موجود";

                            return new BaseResponse<Guid>(ResponseMessage, false, 404);
                        }

                        if (!string.IsNullOrEmpty(InputDynamicAttributeWithValues.ValueAsString))
                        {
                            // Unique Constraint..
                            DynamicAttributeValue? CheckUnique = await _DynamicAttributeValueRepository
                                .IncludeThenFirstOrDefaultAsync(x => x.DynamicAttribute!, x => x.DynamicAttributeId == DynamicAttributeEntity.Id &&
                                    x.RecordIdAsGuid != User.Id && x.DynamicAttribute!.IsUnique &&
                                    x.Value.ToLower() == InputDynamicAttributeWithValues.ValueAsString.ToLower());

                            if (CheckUnique != null)
                            {
                                ResponseMessage = Request.lang == "en"
                                    ? $"{DynamicAttributeEntity.EnglishLabel}'s value is already used, please insert a different value"
                                    : $"قيمة هذا الحقل: {DynamicAttributeEntity.ArabicLabel} مستخدمة مسبقاً, الرجاء إدخال قيمة مختلفة";

                                return new BaseResponse<Guid>(ResponseMessage, false, 400);
                            }
                        }

                        // Check General Validation..
                        GeneralValidation? GeneralValidationEntity = await _GeneralValidationRepository
                            .IncludeThenFirstOrDefaultAsync(x => x.AttributeOperation!, 
                                x => x.DynamicAttributeId == InputDynamicAttributeWithValues.DynamicAttributeId);

                        if (GeneralValidationEntity != null)
                        {
                            string DataTypeAsName = DynamicAttributeEntity.AttributeDataType!.Name;
                            string? InputDynamicAttributeValueAsString = InputDynamicAttributeWithValues.ValueAsString;
                            string ValidationOperation = GeneralValidationEntity.AttributeOperation!.OperationAsString;
                            string? ValidationValue = GeneralValidationEntity.Value;

                            if (DataTypeAsName.ToLower() == "Text".ToLower() ||
                                DataTypeAsName.ToLower() == "Email".ToLower() ||
                                DataTypeAsName.ToLower() == "Phone Number".ToLower() ||
                                DataTypeAsName.ToLower() == "List".ToLower())
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputDynamicAttributeValueAsString != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger >= GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger <= GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }

                                        int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                        if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsInteger}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation == "=")
                                    {
                                        if (InputDynamicAttributeValueAsString != ValidationValue)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                    {
                                        if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }

                                        DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                        if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsDateOnly}"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                        }
                                    }
                                    else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                    {
                                        if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                        {
                                            ResponseMessage = Request.lang == "en"
                                                ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                            return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                        return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                    }
                                }
                                else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                {
                                    if (InputDynamicAttributeValueAsBinaryFile is null)
                                    {
                                        ResponseMessage = Request.lang == "en"
                                            ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                            : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                        return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation == "=")
                                            {
                                                if (InputDynamicAttributeValueAsString.ToLower() != ValidationValue.ToLower())
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                            {
                                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                            {
                                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                            {
                                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation == "=")
                                            {
                                                if (InputDynamicAttributeValueAsString != ValidationValue)
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                            {
                                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                            {
                                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }

                                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                                if (InputDynamicAttributeValueAsInteger >= GeneralValidationValueAsInteger)
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsInteger}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsInteger}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }

                                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                                if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsInteger}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }

                                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                                if (InputDynamicAttributeValueAsInteger <= GeneralValidationValueAsInteger)
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsInteger}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsInteger}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }

                                                int.TryParse(ValidationValue, out int GeneralValidationValueAsInteger);

                                                if (InputDynamicAttributeValueAsInteger > GeneralValidationValueAsInteger)
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsInteger}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsInteger}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                            {
                                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation == "=")
                                            {
                                                if (InputDynamicAttributeValueAsString != ValidationValue)
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be equal to: {ValidationValue}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون مساوية لهذه القيمة: {ValidationValue}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation.ToLower() == "is Empty".ToLower())
                                            {
                                                if (!string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be empty"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون فارغة";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                            {
                                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }

                                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                                if (InputDynamicAttributeValueAsDateOnly >= GeneralValidationValueAsDateOnly)
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than: {GeneralValidationValueAsDateOnly}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر من: {GeneralValidationValueAsDateOnly}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }

                                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                                if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be smaller than or equal to: {GeneralValidationValueAsDateOnly}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أصغر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }

                                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                                if (InputDynamicAttributeValueAsDateOnly <= GeneralValidationValueAsDateOnly)
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than: {GeneralValidationValueAsDateOnly}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر من: {GeneralValidationValueAsDateOnly}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }

                                                DateOnly.TryParse(ValidationValue, out DateOnly GeneralValidationValueAsDateOnly);

                                                if (InputDynamicAttributeValueAsDateOnly > GeneralValidationValueAsDateOnly)
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value must be bigger than or equal to: {GeneralValidationValueAsDateOnly}"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن تكون أكبر او تساوي لهذه القيمة: {GeneralValidationValueAsDateOnly}";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                                }
                                            }
                                            else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                            {
                                                if (string.IsNullOrEmpty(InputDynamicAttributeValueAsString))
                                                {
                                                    ResponseMessage = Request.lang == "en"
                                                        ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                        : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                    return new BaseResponse<Guid>(ResponseMessage, false, 400);
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

                                                return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                            }
                                        }
                                        else if (ValidationOperation.ToLower() == "is not Empty".ToLower())
                                        {
                                            if (InputDynamicAttributeValueAsBinaryFile is null)
                                            {
                                                ResponseMessage = Request.lang == "en"
                                                    ? $"{DynamicAttributeEntity.EnglishLabel}'s value can't be empty"
                                                    : $"قيمة هذا الحقل {DynamicAttributeEntity.ArabicLabel} يجب أن لا تكون فارغة";

                                                return new BaseResponse<Guid>(ResponseMessage, false, 400);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                    // Hard Delete On Dynamic Values..
                    List<DynamicAttributeValue> DynamicValuesToDelete = await _DynamicAttributeValueRepository
                        .Where(x => x.RecordIdAsGuid == User.Id).ToListAsync();

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

                        string? FileName = $"{User.Id}-{DynamicAttributeAsFile.ValueAsBinaryFile!.FileName}";

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
                            RecordIdAsGuid = User.Id,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            Value = x.ValueAsString!
                        }).ToList();

                    await _DynamicAttributeValueRepository.AddRangeAsync(DynamicAttributeValuesEntities);

                    IEnumerable<EduEntitiesCoordinator> NewEducationalEntities = Request.EducationalEntitiesIds
                        .Select(x => new EduEntitiesCoordinator()
                    {
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        isDeleted = false,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        CoordinatorId = User.Id,
                        EducationalEntityId = x,
                        RelatedDate = DateTime.UtcNow
                    });

                    await _EduEntitiesCoordinatorRepository.AddRangeAsync(NewEducationalEntities);

                    IEnumerable<EduInstitutionCoordinator> NewEducationalInstitutions = Request.EducationalInstitutionsIds
                        .Select(x => new EduInstitutionCoordinator()
                        {
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            CoordinatorId = User.Id,
                            EducationalInstitutionId = x
                        });

                    await _EduInstitutionCoordinatorRepository.AddRangeAsync(NewEducationalInstitutions);

                    Transaction.Complete();

                    return new BaseResponse<Guid>("", true, 200, data.Id);
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
