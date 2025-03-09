using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationFeatures.Commands.DeleteUserNoteOnForm
{
    public class DeleteUserNoteOnFormHandler : IRequestHandler<DeleteUserNoteOnFormCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<UserNoteOnFormForArbitration> _UserNoteOnFormForArbitrationRepository;

        public DeleteUserNoteOnFormHandler(IAsyncRepository<UserNoteOnFormForArbitration> _UserNoteOnFormForArbitrationRepository)
        {
            this._UserNoteOnFormForArbitrationRepository = _UserNoteOnFormForArbitrationRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteUserNoteOnFormCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            UserNoteOnFormForArbitration? UserNoteOnFormForArbitrationEntity = await _UserNoteOnFormForArbitrationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.UserNoteOnFormForArbitrationId);

            if (UserNoteOnFormForArbitrationEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Note is not found"
                    : "الملاحظة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, true, 404);
            }

            await _UserNoteOnFormForArbitrationRepository.DeleteAsync(UserNoteOnFormForArbitrationEntity);

            ResponseMessage = Request.lang == "en"
                ? "Note has been deleted successfully"
                : "تم حذف الملاحظة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
