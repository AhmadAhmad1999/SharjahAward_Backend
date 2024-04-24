using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NotificationTemplateModel;

namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Commands.DeleteNotificationTemplate
{
    public class DeleteNotificationTemplateHandler : IRequestHandler<DeleteNotificationTemplateCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<NotificationTemplate> _NotificationTemplateRepository;
        public DeleteNotificationTemplateHandler(IAsyncRepository<NotificationTemplate> NotificationTemplateRepository)
        {
            _NotificationTemplateRepository = NotificationTemplateRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteNotificationTemplateCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            NotificationTemplate? NotificationTemplateEntityToDelete = await _NotificationTemplateRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (NotificationTemplateEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Notification template is not found"
                    : "قالب الإشعار غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _NotificationTemplateRepository.DeleteAsync(NotificationTemplateEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Notification template has been deleted successfully"
                : "تم حذف نموذج الإشعار بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
