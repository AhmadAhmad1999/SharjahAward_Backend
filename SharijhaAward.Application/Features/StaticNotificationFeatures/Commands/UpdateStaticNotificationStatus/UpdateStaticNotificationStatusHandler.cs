using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.StaticNotificationModel;

namespace SharijhaAward.Application.Features.StaticNotificationFeatures.Commands.UpdateStaticNotificationStatus
{
    public class UpdateStaticNotificationStatusHandler : IRequestHandler<UpdateStaticNotificationStatusCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<StaticNotification> _StaticNotificationRepository;

        public UpdateStaticNotificationStatusHandler(IAsyncRepository<StaticNotification> StaticNotificationRepository)
        {
            _StaticNotificationRepository = StaticNotificationRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateStaticNotificationStatusCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            StaticNotification? StaticNotificationEntityToUpdate = await _StaticNotificationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (StaticNotificationEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Static notification is not found"
                    : "الإشعار غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            StaticNotificationEntityToUpdate.isActive = Request.isActive;
            await _StaticNotificationRepository.UpdateAsync(StaticNotificationEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Static notification's status has been updated successfully"
                : "تم تعديل حالة الإشعار بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
