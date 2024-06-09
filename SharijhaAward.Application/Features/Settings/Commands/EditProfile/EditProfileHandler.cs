using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.EditProfile
{
    public class EditProfileHandler : IRequestHandler<EditProfileCommand,
        BaseResponse<object>>
    {
        private IUserRepository _UserRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IJwtProvider _JWTProvider;

        public EditProfileHandler(IUserRepository UserRepository,
            IHttpContextAccessor HttpContextAccessor,
            IJwtProvider JWTProvider)
        {
            _UserRepository = UserRepository;
            _HttpContextAccessor = HttpContextAccessor;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(EditProfileCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserID = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserID);

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Subscriber profile is not found"
                    : "حساب المشترك غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (Request.ProfileImage != null)
            {
                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                string FolderPath = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/ProfilePics"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/ProfilePics";

                string? FileName = $"{Request.ProfileImage!.FileName}";
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
                    Request.ProfileImage!.CopyTo(FileStream);
                }

                UserEntity.ImageURL = FilePathToSaveIntoDataBase;
                UserEntity.PhoneNumber = Request.PhoneNumber;
                UserEntity.Gender = Request.Gender;
            }
            else
            {
                UserEntity.PhoneNumber = Request.PhoneNumber;
                UserEntity.Gender = Request.Gender;
            }

            await _UserRepository.UpdateAsync(UserEntity);

            ResponseMessage = Request.lang == "en"
                ? "Profile data has been updated successfully"
                : "تم تعديل معلومات الحساب الشخصي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
