using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NotificationTemplateModel;

namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Queries.GetNotificationTemplateById
{
    public class GetNotificationTemplateByIdHandler 
        : IRequestHandler<GetNotificationTemplateByIdQuery, BaseResponse<GetNotificationTemplateByIdDto>>
    {
        private readonly IAsyncRepository<NotificationTemplate> _NotificationTemplateRepository;
        private readonly IMapper _Mapper;
        public GetNotificationTemplateByIdHandler(IAsyncRepository<NotificationTemplate> NotificationTemplateRepository,
            IMapper Mapper)
        {
            _NotificationTemplateRepository = NotificationTemplateRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<GetNotificationTemplateByIdDto>> 
            Handle(GetNotificationTemplateByIdQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            NotificationTemplate? NotificationTemplateEntity = await _NotificationTemplateRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (NotificationTemplateEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Notification template is not Found"
                    : "نموذج الإشعار غير موجود";

                return new BaseResponse<GetNotificationTemplateByIdDto>(ResponseMessage, false, 404);
            }

            GetNotificationTemplateByIdDto GetNotificationTemplateByIdDto =
                _Mapper.Map<GetNotificationTemplateByIdDto>(NotificationTemplateEntity);

            return new BaseResponse<GetNotificationTemplateByIdDto>(ResponseMessage, true, 200, GetNotificationTemplateByIdDto);
        }
    }
}
