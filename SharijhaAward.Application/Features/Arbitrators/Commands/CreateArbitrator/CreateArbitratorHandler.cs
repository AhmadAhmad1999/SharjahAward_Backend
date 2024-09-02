using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.ArbitratorClassModel;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.CategoryArbitratorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitrator
{
    public class CreateArbitratorHandler
         : IRequestHandler<CreateArbitratorCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;
        private readonly IAsyncRepository<CategoryArbitrator> _CategoryArbitratorRepository;
        private readonly IRoleRepository _RoleRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IMapper _Mapper;
        private readonly IEmailSender _EmailSender;
        private readonly IAsyncRepository<ArbitratorClass> _ArbitratorClassRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<ResponsibilityUser> _responsibilityUserRepository;    
        private readonly IAsyncRepository<Responsibility> _responsibilityRepository;

        public CreateArbitratorHandler(IAsyncRepository<Arbitrator> ArbitratorRepository,
            IAsyncRepository<CategoryArbitrator> CategoryArbitratorRepository,
            IRoleRepository RoleRepository, 
            IUserRepository UserRepository, 
            IMapper Mapper,
            IEmailSender EmailSender,
            IAsyncRepository<ArbitratorClass> ArbitratorClassRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<ResponsibilityUser> responsibilityUserRepository,
            IAsyncRepository<Responsibility> responsibilityRepository)
        {
            _ArbitratorRepository = ArbitratorRepository;
            _CategoryArbitratorRepository = CategoryArbitratorRepository;
            _RoleRepository = RoleRepository;
            _UserRepository = UserRepository;
            _Mapper = Mapper;
            _EmailSender = EmailSender;
            _ArbitratorClassRepository = ArbitratorClassRepository;
            _UserRoleRepository = UserRoleRepository;
            _responsibilityUserRepository = responsibilityUserRepository;
            _responsibilityRepository = responsibilityRepository;
        }

        public async Task<BaseResponse<int>> Handle(CreateArbitratorCommand Request, CancellationToken cancellationToken)
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

                    Domain.Entities.IdentityModels.User? CheckEmailIfAlreadyUsedInUser = await _UserRepository
                        .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower() && x.isValidAccount);

                    if (CheckEmailIfAlreadyUsedInUser is not null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Invalid email or password"
                            : "خطأ في البريد الإلكتروني او كلمة المرور";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    Arbitrator? CheckEmailIfAlreadyUsedInArbitrator = await _ArbitratorRepository
                        .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

                    if (CheckEmailIfAlreadyUsedInArbitrator is not null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Invalid email or password"
                            : "خطأ في البريد الإلكتروني او كلمة المرور";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    Role? Role = await _RoleRepository.GetByName("Arbitrator");

                    if (Role is null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Arbitrator role is not found"
                            : "دور المحكم غير موجود";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    Domain.Entities.IdentityModels.User NewUserEntity = new Domain.Entities.IdentityModels.User()
                    {
                        isDeleted = false,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = null,
                        DeletedAt = null,
                        LastModifiedAt = null,
                        LastModifiedBy = null,
                        ArabicName = Request.ArabicName,
                        EnglishName = Request.EnglishName,
                        ConfirmationCodeForResetPassword = null,
                        ConfirmationCodeForSignUp = null,
                        Email = Request.Email,
                        Gender = 0,
                        ImageURL = null,
                        isValidAccount = true,
                        // Password = "123456",
                        PhoneNumber = Request.PhoneNumber
                    };

                    byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

                    NewUserEntity.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: Request.Password,
                        salt: salt,
                        prf: KeyDerivationPrf.HMACSHA256,
                        iterationCount: 100000,
                        numBytesRequested: 256 / 8));

                    await _UserRepository.AddAsync(NewUserEntity);

                    UserRole NewUserRoleEntity = new UserRole()
                    {
                        UserId = NewUserEntity.Id,
                        RoleId = Role.Id
                    };

                    await _UserRoleRepository.AddAsync(NewUserRoleEntity);

                    Arbitrator NewArbitratorEntity = _Mapper.Map<Arbitrator>(Request);
                    NewArbitratorEntity.Id = NewUserEntity.Id;

                    await _ArbitratorRepository.AddAsync(NewArbitratorEntity);

                    if (Request.SendEmail)
                    {
                        var EmailRequest = new EmailRequest()
                        {
                            ToEmail = Request.Email,
                            Subject = Request.lang == "ar"
                                    ? $"معلومات حساب المحكم"
                                    : "Arbitrator Account Informations",
                            Body = Request.lang == "ar"
                                    ? $"البريد الإلكترني الخاص بك : {Request.Email} /n كلمة المرور : {Request.Password}"
                                    : $"Your Email : {Request.Email} /n Password : {Request.Password}"
                        };

                        await _EmailSender.SendEmailForConfirmationCode(EmailRequest);
                    }

                    var Responsibilities = await _responsibilityRepository
                         .Where(r => r.RoleId == Role.Id)
                         .ToListAsync();


                    var userResponsibilities = await _responsibilityUserRepository
                        .Where(r => r.UserId == NewUserEntity.Id)
                        .Select(r => r.ResponsibilityId)
                        .ToListAsync();

                    foreach(var Responsibility in Responsibilities)
                    {
                        if (!userResponsibilities.Contains(Responsibility.Id))
                        {
                            var ResponsibilityUser = new ResponsibilityUser()
                            {
                                IsAccept = false,
                                UserId = NewUserEntity.Id,
                                ResponsibilityId = Responsibility.Id
                            };

                            await _responsibilityUserRepository.AddAsync(ResponsibilityUser);
                        }
                    }

                    List<CategoryArbitrator> ListOfCategoriesArbitrators = Request.Categories
                        .Select(x => new CategoryArbitrator()
                        {
                            CategoryId = x,
                            ArbitratorId = NewUserEntity.Id,
                            isDeleted = false,
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            LastModifiedAt = null,
                            LastModifiedBy = null
                        }).ToList();

                    await _CategoryArbitratorRepository.AddRangeAsync(ListOfCategoriesArbitrators);

                    IEnumerable<ArbitratorClass> ArbitratorClassesEntities = Request.ArbitratorClasses
                        .Select(x => new ArbitratorClass()
                        {
                            CreatedAt = DateTime.UtcNow,
                            CreatedBy = null,
                            DeletedAt = null,
                            isDeleted = false,
                            LastModifiedAt = null,
                            LastModifiedBy = null,
                            EducationalClassId = x,
                            ArbitratorId = NewArbitratorEntity.Id
                        });

                    await _ArbitratorClassRepository.AddRangeAsync(ArbitratorClassesEntities);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المحكم بنجاح";

                    return new BaseResponse<int>(ResponseMessage, true, 200, NewUserEntity.Id);
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
