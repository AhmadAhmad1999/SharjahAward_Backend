using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.NotificationTemplateModel;

namespace SharijhaAward.Application.Features.NotificationTemplateFeatures.Commands.CreateNotificationTemplate
{
    public class CreateNotificationTemplateHandler : IRequestHandler<CreateNotificationTemplateCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<NotificationTemplate> _NotificationTemplateRepository;

        public CreateNotificationTemplateHandler(IMapper Mapper,
            IAsyncRepository<NotificationTemplate> NotificationTemplateRepository)
        {
            _Mapper = Mapper;
            _NotificationTemplateRepository = NotificationTemplateRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateNotificationTemplateCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            NotificationTemplate NewNotificationTemplateEntity = _Mapper.Map<NotificationTemplate>(Request);

            await _NotificationTemplateRepository.AddAsync(NewNotificationTemplateEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء نموذج الإشعار بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
