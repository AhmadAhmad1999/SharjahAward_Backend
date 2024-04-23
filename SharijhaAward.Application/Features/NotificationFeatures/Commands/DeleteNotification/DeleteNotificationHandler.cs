using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NotificationModel;

namespace SharijhaAward.Application.Features.NotificationFeatures.Commands.DeleteNotification
{
    public class DeleteNotificationHandler : IRequestHandler<DeleteNotificationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Notification> _NotificationRepository;
        public DeleteNotificationHandler(IAsyncRepository<Notification> NotificationRepository)
        {
            _NotificationRepository = NotificationRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteNotificationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Notification? NotificationEntityToDelete = await _NotificationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (NotificationEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Notification is not found"
                    : "الإشعار غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _NotificationRepository.DeleteAsync(NotificationEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Notification has been deleted successfully"
                : "تم حذف الإشعار بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
