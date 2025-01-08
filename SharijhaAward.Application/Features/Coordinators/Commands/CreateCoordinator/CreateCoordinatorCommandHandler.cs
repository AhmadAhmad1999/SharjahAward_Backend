using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using SharijhaAward.Domain.Entities.EducationCoordinatorModel;
using SharijhaAward.Domain.Entities.EduInstitutionCoordinatorModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.ResponsibilityModel;
using System.Net.Http;
using System.Net.Mail;
using System.Transactions;

namespace SharijhaAward.Application.Features.Coordinators.Commands.CreateCoordinator
{
    public class CreateCoordinatorCommandHandler
         : IRequestHandler<CreateCoordinatorCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Coordinator> _coordinatorRepository;
        private readonly IAsyncRepository<EduEntitiesCoordinator> _EduEntitiesCoordinatorRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IFileService _fileService;
        private readonly IEmailSender _EmailSender;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<ResponsibilityUser> _responsibilityUserRepository;
        private readonly IAsyncRepository<Responsibility> _responsibilityRepository;

        public CreateCoordinatorCommandHandler(IRoleRepository roleRepository,
            IAsyncRepository<EduEntitiesCoordinator> EduEntitiesCoordinatorRepository,
            IAsyncRepository<Coordinator> coordinatorRepository, 
            IFileService fileService, 
            IUserRepository userRepository,
            IEmailSender EmailSender,
            IMapper Mapper,
            IAsyncRepository<ResponsibilityUser> responsibilityUserRepository,
            IAsyncRepository<Responsibility> responsibilityRepository,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _roleRepository = roleRepository;
            _EduEntitiesCoordinatorRepository = EduEntitiesCoordinatorRepository;
            _coordinatorRepository = coordinatorRepository;
            _userRepository = userRepository;
            _fileService = fileService;
            _EmailSender = EmailSender;
            _mapper = Mapper;
            _UserRoleRepository = UserRoleRepository;
            _responsibilityRepository = responsibilityRepository;
            _responsibilityUserRepository = responsibilityUserRepository;
        }

        public async Task<BaseResponse<int>> Handle(CreateCoordinatorCommand Request, CancellationToken cancellationToken)
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
                            ? "This email is already used"
                            : "البريد الإلكتروني مستخدم بالفعل";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    Coordinator? CheckEmailIfAlreadyUsedInCoordinator = await _coordinatorRepository
                        .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

                    if (CheckEmailIfAlreadyUsedInCoordinator is not null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "This email is already used"
                            : "البريد الإلكتروني مستخدم بالفعل";

                        return new BaseResponse<int>(ResponseMessage, false, 400);
                    }

                    var User = new Domain.Entities.IdentityModels.User()
                    {
                        ArabicName = Request.ArabicName,
                        EnglishName = Request.EnglishName,
                        Email = Request.Email,
                        PhoneNumber = Request.PhoneNumber,
                        // ConfirmationCode = 0000,
                        // Password = "123456",
                        Gender = 0,
                        isValidAccount = true
                    };

                    byte[] salt = new byte[16] { 52, 123, 55, 148, 64, 30, 175, 37, 25, 240, 115, 57, 13, 255, 41, 74 };

                    User.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: Request.Password,
                        salt: salt,
                        prf: KeyDerivationPrf.HMACSHA256,
                        iterationCount: 100000,
                        numBytesRequested: 256 / 8));

                    await _userRepository.AddAsync(User);

                    int UserId = User.Id;

                    var Coordinator = _mapper.Map<Coordinator>(Request);
                    Coordinator.Id = UserId;
                    

                    var data =  await _coordinatorRepository.AddAsync(Coordinator);
                    
                    if (Request.SendEmail)
                    {
                        List<string> Recipients = new List<string>()
                        {
                            Request.Email
                        };

                        string EmailSubject = "معلومات الحساب الشخصي" + "-" + "Personal account information";

                        string HTMLContent = await File.ReadAllTextAsync(Request.WWWRootFilePath + "/AccountInfo_Template.html");

                        byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath + "/assets/qr/header.png");
                        string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                        string FullEmailBody = HTMLContent
                            .Replace("$PersonalEmail$", Request.Email)
                            .Replace("$Password$", Request.Password);

                        // Create An AlternateView to Specify The HTML Body And Embed The Image..
                        AlternateView AlternateView = AlternateView.CreateAlternateViewFromString(FullEmailBody, null, "text/html");

                        LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                        AlternateView.LinkedResources.Add(HeaderImage);

                        FullEmailBody = FullEmailBody
                            .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                        await _EmailSender.SendEmailAsync(Recipients, EmailSubject, FullEmailBody, AlternateView);
                    }

                    var role = await _roleRepository.GetByName("Coordinator");
                    if (role != null)
                    {
                        UserRole NewUserRoleEntity = new UserRole()
                        {
                            UserId = User.Id,
                            RoleId = role.Id
                        };

                        await _UserRoleRepository.AddAsync(NewUserRoleEntity);
                    }

                    var Responsibilities = await _responsibilityRepository
                         .Where(r => r.RoleId == role!.Id)
                         .ToListAsync();


                    var userResponsibilities = await _responsibilityUserRepository
                        .Where(r => r.UserId == User.Id)
                        .Select(r => r.ResponsibilityId)
                        .ToListAsync();

                    foreach (var Responsibility in Responsibilities)
                    {
                        if (!userResponsibilities.Contains(Responsibility.Id))
                        {
                            var ResponsibilityUser = new ResponsibilityUser()
                            {
                                IsAccept = false,
                                UserId = User.Id,
                                ResponsibilityId = Responsibility.Id
                            };

                            await _responsibilityUserRepository.AddAsync(ResponsibilityUser);
                        }
                    }

                    if (Request.EducationalEntitiesIds != null)
                    {
                        foreach (var EntityId in Request.EducationalEntitiesIds)
                        {
                            var EduEntitiesCoordinator = new EduEntitiesCoordinator()
                            {
                                EducationalEntityId = EntityId,
                                CoordinatorId = data.Id
                            };

                            await _EduEntitiesCoordinatorRepository.AddAsync(EduEntitiesCoordinator);
                        }
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المنسق بنجاح";

                    return new BaseResponse<int>(ResponseMessage, true, 200, UserId);
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
