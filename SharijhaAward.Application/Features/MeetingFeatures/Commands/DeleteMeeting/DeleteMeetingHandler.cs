using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingModel;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.DeleteMeeting
{
    public class DeleteMeetingHandler : IRequestHandler<DeleteMeetingCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;
        public DeleteMeetingHandler(IAsyncRepository<Meeting> MeetingRepository)
        {
            _MeetingRepository = MeetingRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteMeetingCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Meeting? MeetingEntityToDelete = await _MeetingRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (MeetingEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Meeting is not found"
                    : "الاجتماع غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _MeetingRepository.DeleteAsync(MeetingEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Meeting has been deleted successfully"
                : "تم حذف الاجتماع بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
