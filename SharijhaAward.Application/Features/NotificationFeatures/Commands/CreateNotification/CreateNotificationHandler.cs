using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NotificationModel;

namespace SharijhaAward.Application.Features.NotificationFeatures.Commands.CreateNotification
{
    public class CreateNotificationHandler : IRequestHandler<CreateNotificationCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Notification> _NotificationRepository;

        public CreateNotificationHandler(IMapper Mapper,
            IAsyncRepository<Notification> NotificationRepository)
        {
            _Mapper = Mapper;
            _NotificationRepository = NotificationRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateNotificationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Notification NewNotificationEntity = _Mapper.Map<Notification>(Request);

            await _NotificationRepository.AddAsync(NewNotificationEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء الإشعار بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
