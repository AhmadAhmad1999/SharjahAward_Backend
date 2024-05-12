using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NotificationModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.NotificationFeatures.Commands.DeleteNotification
{
    public class DeleteNotificationHandler : IRequestHandler<DeleteNotificationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Notification> _NotificationRepository;
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;
        public DeleteNotificationHandler(IAsyncRepository<Notification> NotificationRepository,
            IAsyncRepository<UserNotification> UserNotificationRepository)
        {
            _NotificationRepository = NotificationRepository;
            _UserNotificationRepository = UserNotificationRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteNotificationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
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

                    List<UserNotification> UserNotificationEntitiesToDelete = await _UserNotificationRepository
                        .Where(x => x.NotificationId == Request.Id)
                        .ToListAsync();

                    await _UserNotificationRepository.DeleteListAsync(UserNotificationEntitiesToDelete);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Notification has been deleted successfully"
                        : "تم حذف الإشعار بنجاح";

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
