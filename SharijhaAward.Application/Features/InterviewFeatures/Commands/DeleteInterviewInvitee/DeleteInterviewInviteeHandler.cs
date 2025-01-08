using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.DeleteInterviewInvitee
{
    public class DeleteInterviewInviteeHandler : IRequestHandler<DeleteInterviewInviteeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository;
        public DeleteInterviewInviteeHandler(IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository)
        {
            this._InterviewInviteeRepository = _InterviewInviteeRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteInterviewInviteeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            InterviewInvitee? InterviewInviteeEntityToDelete = await _InterviewInviteeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (InterviewInviteeEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview invitee is not found"
                    : "الدعوة للمقابلة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _InterviewInviteeRepository.DeleteAsync(InterviewInviteeEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Interview invitee has been deleted successfully"
                : "تم حذف الدعوة للمقابلة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
