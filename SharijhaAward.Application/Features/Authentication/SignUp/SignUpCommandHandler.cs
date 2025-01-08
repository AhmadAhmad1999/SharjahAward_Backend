using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AchievementModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Net.Http;
using System.Net.Mail;
using System.Transactions;

namespace SharijhaAward.Application.Features.Authentication.SignUp
{
    public class SignUpCommandHandler
        : IRequestHandler<SignUpCommand, AuthenticationResponse>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IRoleRepository _roleRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _EmailSender;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<Achievement> _achievementRepository;
        private readonly IAsyncRepository<RolePermission> _RolePermissionRepository;

        public SignUpCommandHandler(IAsyncRepository<Achievement> achievementRepository, IUserRepository userRepository,IRoleRepository roleRepository ,IMapper mapper,
            IEmailSender EmailSender,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<RolePermission> RolePermissionRepository)
        {
            _roleRepository = roleRepository;
            _UserRepository = userRepository;
            _mapper = mapper;
            _EmailSender = EmailSender;
            _UserRoleRepository = UserRoleRepository;
            _achievementRepository = achievementRepository;
            _RolePermissionRepository = RolePermissionRepository;
        }

        public async Task<AuthenticationResponse> Handle(SignUpCommand Request, CancellationToken cancellationToken)
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
                    Domain.Entities.IdentityModels.User? CheckEmail = await _UserRepository
                        .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

                    string msg = Request.lang == "en"
                        ? "User has been created"
                        : "تم التسجيل بنجاح";

                    Domain.Entities.IdentityModels.User User = _mapper.Map<Domain.Entities.IdentityModels.User>(Request);

                    byte[] salt = new byte[16] { 52, 123, 55, 148, 64, 30, 175, 37, 25, 240, 115, 57, 13, 255, 41, 74 };

                    User.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: User.Password,
                        salt: salt,
                        prf: KeyDerivationPrf.HMACSHA256,
                        iterationCount: 100000,
                        numBytesRequested: 256 / 8));

                    if (CheckEmail is not null)
                    {
                        if (CheckEmail.isValidAccount)
                        {
                            msg = Request.lang == "en"
                                ? "This email is already used"
                                : "البريد الإلكتروني مستخدم بالفعل";

                            return new AuthenticationResponse()
                            {
                                message = msg,
                                isSucceed = false
                            };
                        }
                        else if (!CheckEmail.isValidAccount && User.Password == CheckEmail.Password)
                        {
                            msg = Request.lang == "en"
                                ? "This account is not authenticated, please verify it using the confirmation code that was sent to your email inbox"
                                : "لم يتم توثيق حسابك، يرجى التحقق منه باستخدام رمز التأكيد الذي تم إرساله إلى صندوق البريد الإلكتروني الخاص بك";

                            List<string> NotAuthenticatedRecipients = new List<string>()
                            {
                                Request.Email
                            };

                            string NotAuthenticatedEmailSubject = "رمز التحقق لتأكيد الحساب الشخصي" + "-" + "Verification code to confirm personal account";

                            string NotAuthenticatedHtmlBody = Request.WWWRootFilePath + "/ConfirmationCode_Template.html";

                            string NotAuthenticatedHTMLContent = await File.ReadAllTextAsync(NotAuthenticatedHtmlBody);

                            // Fetch the image as a byte array
                            byte[] NotAuthenticatedHeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath + "/assets/qr/header.png");

                            string NotAuthenticatedHeaderImagebase64String = Convert.ToBase64String(NotAuthenticatedHeaderImageBytes);

                            string NotAuthenticatedFullEmailBody = NotAuthenticatedHTMLContent
                                .Replace("$PersonalEmail$", Request.Email)
                                .Replace("$ConfirmationCode$", CheckEmail.ConfirmationCodeForSignUp ? .ToString() ?? null);

                            // Create An AlternateView to Specify The HTML Body And Embed The Image..
                            AlternateView NotAuthenticatedAlternateView = AlternateView.CreateAlternateViewFromString(NotAuthenticatedFullEmailBody, null, "text/html");

                            LinkedResource NotAuthenticatedHeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                            NotAuthenticatedAlternateView.LinkedResources.Add(NotAuthenticatedHeaderImage);

                            NotAuthenticatedFullEmailBody = NotAuthenticatedFullEmailBody
                                .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{NotAuthenticatedHeaderImagebase64String}'");

                            await _EmailSender.SendEmailAsync(NotAuthenticatedRecipients, NotAuthenticatedEmailSubject, NotAuthenticatedFullEmailBody, NotAuthenticatedAlternateView);
                            return new AuthenticationResponse()
                            {
                                isSucceed = true,
                                message = msg,
                                user = _mapper.Map<UserDataResponse>(CheckEmail),
                                NeedVerification = true
                            };
                        }
                    }

                    User.isValidAccount = false;

                    Role? CheckRoleId = Request.RoleName != null
                        ? await _roleRepository.GetByName(Request.RoleName)
                        : await _roleRepository.GetByName("User");

                    if (CheckRoleId == null)
                    {
                        msg = Request.lang == "en"
                            ? "The user is not created , Role does not exist"
                            : "لم يتم إنشاء المستخدم خطأ في الدور";

                        return new AuthenticationResponse()
                        {
                            message = msg
                        };
                    }

                    int ConfirmationCode = new Random().Next(10000, 99999);

                    User.ConfirmationCodeForSignUp = ConfirmationCode;

                    var random = new Random();
                    const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                    var numbers = string.Concat(Enumerable.Range(0, 3)
                        .Select(_ => random.Next(0, 10).ToString()));

                    var letters = new string(Enumerable.Range(0, 3)
                        .Select(_ => alphabet[random.Next(0, alphabet.Length)])
                        .ToArray());

                    var combined = numbers + letters;
                    var shuffledString = new string(combined.ToCharArray().OrderBy(_ => random.Next()).ToArray());

                    bool LoopStopper = true;
                    while (LoopStopper)
                    {
                        Domain.Entities.IdentityModels.User? CheckSubscriberId = await _UserRepository
                            .FirstOrDefaultAsync(x => !string.IsNullOrEmpty(x.SubscriberId)
                                ? x.SubscriberId.ToLower() == shuffledString.ToLower()
                                : false);

                        if (CheckSubscriberId is null)
                        {
                            User.SubscriberId = shuffledString;
                            LoopStopper = false;
                        }
                    }

                    Domain.Entities.IdentityModels.User UserEntityAfterAdd = await _UserRepository.AddAsync(User);

                    UserRole NewUserRoleEntity = new UserRole()
                    {
                        UserId = UserEntityAfterAdd.Id,
                        RoleId = CheckRoleId.Id
                    };

                    await _UserRoleRepository.AddAsync(NewUserRoleEntity);

                    Achievement achievement = new Achievement()
                    {
                        AcceptedOnDistinctionField = false,
                        AcceptedOnProjects = false,
                        AcceptedOnSkillsAndExperiences = false,
                        UserId = UserEntityAfterAdd.Id
                    };

                    List<string> Recipients = new List<string>()
                    {
                        Request.Email
                    };

                    string EmailSubject = "معلومات الحساب الشخصي" + "-" + "Personal account information";

                    string NotAuthenticatedHtmlBody3 = Request.WWWRootFilePath + "/ConfirmationCode_Template.html";
                    string HTMLContent = await File.ReadAllTextAsync(NotAuthenticatedHtmlBody3);

                    byte[] HeaderImageBytes = await File.ReadAllBytesAsync(Request.WWWRootFilePath + "/assets/qr/header.png");

                    string HeaderImagebase64String = Convert.ToBase64String(HeaderImageBytes);

                    string FullEmailBody = HTMLContent
                        .Replace("$PersonalEmail$", Request.Email)
                        .Replace("$ConfirmationCode$", ConfirmationCode.ToString());

                    // Create An AlternateView to Specify The HTML Body And Embed The Image..
                    AlternateView AlternateView2 = AlternateView.CreateAlternateViewFromString(FullEmailBody, null, "text/html");

                    LinkedResource HeaderImage = new LinkedResource("wwwroot/assets/qr/header.png") { ContentId = "HeaderImage" }; // Header Code Image..
                    AlternateView2.LinkedResources.Add(HeaderImage);

                    FullEmailBody = FullEmailBody
                        .Replace("\"cid:HeaderImage\"", $"'data:image/png;base64,{HeaderImagebase64String}'");

                    await _EmailSender.SendEmailAsync(Recipients, EmailSubject, FullEmailBody, AlternateView2);

                    List<UserPermissionsDto> ListOfUserPermissionsDto = await _RolePermissionRepository
                        .Where(x => x.RoleId == NewUserRoleEntity.RoleId)
                        .Select(x => new UserPermissionsDto()
                        {
                            Action = x.Permission!.Name,
                            Subject = x.Permission!.PermissionHeader!.EnglishName
                        }).ToListAsync();

                    Transaction.Complete();

                    return new AuthenticationResponse()
                    {
                        isSucceed = true,
                        message = msg,
                        user = _mapper.Map<UserDataResponse>(User),
                        UserPermissions = ListOfUserPermissionsDto
                    };
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
