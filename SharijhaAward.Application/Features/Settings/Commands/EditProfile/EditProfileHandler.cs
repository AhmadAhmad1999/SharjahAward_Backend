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
        private readonly IFileService _FileService;

        public EditProfileHandler(IUserRepository _UserRepository,
            IHttpContextAccessor _HttpContextAccessor,
            IJwtProvider _JWTProvider,
            IFileService _FileService)
        {
            this._UserRepository = _UserRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
            this._JWTProvider = _JWTProvider;
            this._FileService = _FileService;
        }

        public async Task<BaseResponse<object>> Handle(EditProfileCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserID = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserID);

            if (UserEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Subscriber profile is not found"
                    : "حساب المشترك غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (Request.ProfileImage is not null)
            {
                string? FileName = $"{Request.ProfileImage!.FileName}";
                string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"/ProfilePics/{FileName}";

                using (FileStream FileStream = new FileStream(FilePathToSaveIntoDataBase, FileMode.Create))
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
