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
        private IAsyncRepository<Domain.Entities.SubscriberModel.Subscriber> _SubscriberRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;
        private readonly IJwtProvider _JWTProvider;

        public EditProfileHandler(IAsyncRepository<Domain.Entities.SubscriberModel.Subscriber> SubscriberRepository,
            IHttpContextAccessor HttpContextAccessor,
            IJwtProvider JWTProvider)
        {
            _SubscriberRepository = SubscriberRepository;
            _HttpContextAccessor = HttpContextAccessor;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(EditProfileCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Guid UserID = new Guid(_JWTProvider.GetUserIdFromToken(Request.Token!));

            Domain.Entities.SubscriberModel.Subscriber? SubscriberEntity = await _SubscriberRepository
                .FirstOrDefaultAsync(x => x.Id == UserID);

            if (SubscriberEntity == null)
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

                SubscriberEntity.ImageURL = FilePathToSaveIntoDataBase;
                SubscriberEntity.PhoneNumber = Request.PhoneNumber;
            }
            else
                SubscriberEntity.PhoneNumber = Request.PhoneNumber;


            await _SubscriberRepository.UpdateAsync(SubscriberEntity);
            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
