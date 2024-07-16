using AutoMapper;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;

namespace SharijhaAward.Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _Mapper;
        private readonly IEmailSender _EmailSender;
        public UserRepository(SharijhaAwardDbContext dbContext , IJwtProvider jwtProvider,
            IMapper Mapper,
            IEmailSender EmailSender) : base(dbContext)
        {
            _jwtProvider = jwtProvider;
            _Mapper = Mapper;
            _EmailSender = EmailSender;
        }

        //public async Task AsignRole(int userId, int roleId)
        //{
        //    var role = await _dbContext.Roles.FirstOrDefaultAsync(r => r.Id == roleId);
        //    var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
           
        //    if (user != null && role != null)
        //    {
        //        user.RoleId = roleId;
        //        user.Role = role;
        //        role.Users.Add(user);
        //    }
        //    await _dbContext.SaveChangesAsync();
        //}

        public async Task ChangePassword(int Id, string password)
        {
            var user =await _dbContext.Users.FirstOrDefaultAsync(u => u.Id == Id);
            user!.Password= password;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<User> GetByEmailAsync(string email, bool intoAdminDashboard)
        {
            UserRole? UserRole = await _dbContext.UsersRoles
                .Include(x => x.Role!)
                .Include(x => x.User!)
                .FirstOrDefaultAsync(u => u.User!.Email.ToLower() == email.ToLower() &&
                    (intoAdminDashboard
                        ? u.Role!.EnglishName.ToLower() != "Subscriber".ToLower()
                        : u.Role!.EnglishName.ToLower() == "Subscriber".ToLower()));

            if (UserRole is not null)
                return UserRole.User;

            return null;
        }

        public async Task<AuthenticationResponse> LogInAsync(User user, string? lang, bool intoAdminDashboard)
        {
            User? userToLogin = await GetByEmailAsync(user.Email, intoAdminDashboard);
            if (userToLogin == null)
            {
                return new AuthenticationResponse()
                {
                    message = lang == "en"
                        ? "Invalid email or password"
                        : "خطأ في الإيميل أو كلمة المرور"
                };
            }
            else if (!userToLogin.isValidAccount)
            {
                EmailRequest EmailRequest2 = new EmailRequest()
                {
                    ToEmail = userToLogin.Email,
                    Subject = lang == "ar"
                            ? $"رمز تفعيل"
                            : "Confirmation Code",
                    Body = lang == "ar"
                            ? $"رمز التفعيل الخاص بحسابك: {userToLogin.ConfirmationCodeForSignUp}"
                            : $"This is your account's confirmation code: {userToLogin.ConfirmationCodeForSignUp}"
                };

                await _EmailSender.SendEmailForConfirmationCode(EmailRequest2);
                return new AuthenticationResponse()
                {
                    message = lang == "en"
                        ? "This account is not authenticated, please verify it using the confirmation code that was sent to your email inbox"
                        : "لم يتم توثيق حسابك، يرجى التحقق منه باستخدام رمز التأكيد الذي تم إرساله إلى صندوق البريد الإلكتروني الخاص بك",
                    NeedVerification = true
                };
            }

            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            string CheckPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: user.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            if (CheckPassword == userToLogin.Password)
            {
                var token = _jwtProvider.Generate(userToLogin);
                // userToLogin.Role = await _dbContext.Roles.FindAsync(userToLogin.RoleId);
                // var permissions = await _dbContext.RolePermissions.FindAsync(userToLogin.Role.RolePermissionId);

                var response = new AuthenticationResponse()
                {
                    token = token,
                    user = _Mapper.Map<UserDataResponse>(userToLogin),
                    //permissions = permissions.Permission
                    message = lang == "en"
                        ? "Login Sucsses"
                        : "تمت عملية تسجيل الدخول بنجاح"
                };
                return response;
            }
            return new AuthenticationResponse()
            {
                message = lang == "en"
                    ? "Invalid email or password"
                    : "خطأ في الإيميل أو كلمة المرور"
            };
           
        }

        public async Task<string> RegisterAsync(User user)
        {
            if (user != null)
            {
                string token =  _jwtProvider.Generate(user);
                return token;
            }
            throw new Exception("The Account is not created");
        }
    }
}
