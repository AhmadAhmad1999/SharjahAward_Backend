﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

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

        public SignUpCommandHandler(IUserRepository userRepository,IRoleRepository roleRepository ,IMapper mapper,
            IEmailSender EmailSender,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _roleRepository = roleRepository;
            _UserRepository = userRepository;
            _mapper = mapper;
            _EmailSender = EmailSender;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<AuthenticationResponse> Handle(SignUpCommand Request, CancellationToken cancellationToken)
        {
            Domain.Entities.IdentityModels.User? CheckEmail = await _UserRepository
                .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

            string msg = Request.lang == "en"
                ? "User has been created"
                : "تم التسجيل بنجاح";

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
                else
                {
                    msg = Request.lang == "en"
                        ? "This account is not authenticated, please verify it using the confirmation code that was sent to your email inbox"
                        : "لم يتم توثيق حسابك، يرجى التحقق منه باستخدام رمز التأكيد الذي تم إرساله إلى صندوق البريد الإلكتروني الخاص بك";

                    EmailRequest EmailRequest2 = new EmailRequest()
                    {
                        ToEmail = CheckEmail.Email,
                        Subject = Request.lang == "ar"
                            ? $"رمز تفعيل"
                            : "Confirmation Code",
                        Body = Request.lang == "ar"
                            ? $"رمز التفعيل الخاص بحسابك: {CheckEmail.ConfirmationCodeForSignUp}"
                            : $"This is your account's confirmation code: {CheckEmail.ConfirmationCodeForSignUp}"
                    };

                    await _EmailSender.SendEmailForConfirmationCode(EmailRequest2);

                    return new AuthenticationResponse()
                    {
                        isSucceed = false,
                        message = msg,
                        user = _mapper.Map<UserDataResponse>(CheckEmail)
                    };
                }
            }

            Domain.Entities.IdentityModels.User User = _mapper.Map<Domain.Entities.IdentityModels.User>(Request);
            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            User.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: User.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

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

            EmailRequest EmailRequest = new EmailRequest()
            {
                ToEmail = User.Email,
                Subject = Request.lang == "ar"
                    ? $"رمز تفعيل"
                    : "Confirmation Code",
                Body = Request.lang == "ar"
                    ? $"رمز التفعيل الخاص بحسابك: {ConfirmationCode}"
                    : $"This is your account's confirmation code: {ConfirmationCode}"
            };

            await _EmailSender.SendEmailForConfirmationCode(EmailRequest);

            return new AuthenticationResponse() 
            {
                isSucceed = true,
                message = msg,
                user = _mapper.Map<UserDataResponse>(User)
            };
        }
    }
}
