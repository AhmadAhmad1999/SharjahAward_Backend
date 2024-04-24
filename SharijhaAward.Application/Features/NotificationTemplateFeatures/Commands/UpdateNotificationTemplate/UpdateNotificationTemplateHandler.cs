using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NotificationTemplateModel;

namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Commands.UpdateNotificationTemplate
{
    public class UpdateNotificationTemplateHandler : IRequestHandler<UpdateNotificationTemplateCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<NotificationTemplate> _NotificationTemplateRepository;

        public UpdateNotificationTemplateHandler(IMapper Mapper,
            IAsyncRepository<NotificationTemplate> NotificationTemplateRepository)
        {
            _Mapper = Mapper;
            _NotificationTemplateRepository = NotificationTemplateRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateNotificationTemplateCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            NotificationTemplate? NotificationTemplateEntityToUpdate = await _NotificationTemplateRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (NotificationTemplateEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Notification template is not found"
                    : "نموذج الإشعار غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, NotificationTemplateEntityToUpdate, typeof(UpdateNotificationTemplateCommand), typeof(NotificationTemplate));

            await _NotificationTemplateRepository.UpdateAsync(NotificationTemplateEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Notification template has been updated successfully"
                : "تم تعديل نموذج الإشعار بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
