using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.MeetingModel;

namespace SharijhaAward.Application.Features.MeetingFeatures.Commands.ImplementMeeting
{
    public class ImplementMeetingHandler : IRequestHandler<ImplementMeetingCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Meeting> _MeetingRepository;

        public ImplementMeetingHandler(IAsyncRepository<Meeting> MeetingRepository)
        {
            _MeetingRepository = MeetingRepository;
        }

        public async Task<BaseResponse<object>> Handle(ImplementMeetingCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Meeting? MeetingEntity = await _MeetingRepository
                .FirstOrDefaultAsync(x => x.Id == Request.MeetingId);

            if (MeetingEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Meeting is not Found"
                    : "الاجتماع غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            MeetingEntity.isImplemented = true;
            await _MeetingRepository.UpdateAsync(MeetingEntity);

            ResponseMessage = Request.lang == "en"
                ? "Meeting is implemented successfully"
                : "تم إدخال المعلومات بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
