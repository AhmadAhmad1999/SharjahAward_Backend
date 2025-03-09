using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.AddUserNoteOnForm
{
    public class AddUserNoteOnFormHandler : IRequestHandler<AddUserNoteOnFormCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<UserNoteOnFormForArbitration> _UserNoteOnFormForArbitrationRepository;
        private readonly IJwtProvider _JwtProviderRepository;
        private readonly IUserRepository _UserRepository;

        public AddUserNoteOnFormHandler(IAsyncRepository<UserNoteOnFormForArbitration> _UserNoteOnFormForArbitrationRepository,
            IJwtProvider _JwtProviderRepository,
            IUserRepository _UserRepository)
        {
            this._UserNoteOnFormForArbitrationRepository = _UserNoteOnFormForArbitrationRepository;
            this._JwtProviderRepository = _JwtProviderRepository;
            this._UserRepository = _UserRepository;
        }

        public async Task<BaseResponse<object>> Handle(AddUserNoteOnFormCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProviderRepository.GetUserIdFromToken(Request.Token!));

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            if (UserEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, true, 404);
            }

            UserNoteOnFormForArbitration NewUserNoteOnFormForArbitrationEntity = new UserNoteOnFormForArbitration()
            {
                ChairmanId = UserId,
                ProvidedFormId = Request.ProvidedFormId,
                Note = Request.Note,
                ArbitrationStep = Request.ArbitrationStep
            };

            await _UserNoteOnFormForArbitrationRepository.AddAsync(NewUserNoteOnFormForArbitrationEntity);

            ResponseMessage = Request.lang == "en"
                ? "Note has been added successfully"
                : "تم إضافة الملاحظة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
