using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.StaticNotificationModel;

namespace SharijhaAward.Application.Features.StaticNotificationFeatures.Commands.UpdateStaticNotificationText
{
    public class UpdateStaticNotificationTextHandler : IRequestHandler<UpdateStaticNotificationTextCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<StaticNotification> _StaticNotificationRepository;

        public UpdateStaticNotificationTextHandler(IAsyncRepository<StaticNotification> StaticNotificationRepository)
        {
            _StaticNotificationRepository = StaticNotificationRepository;
        }

        public async Task<BaseResponse<object>> Handle(UpdateStaticNotificationTextCommand Request, CancellationToken cancellationToken)
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

            StaticNotificationEntityToUpdate.ArabicTitle = Request.ArabicTitle;
            StaticNotificationEntityToUpdate.ArabicBody = Request.ArabicBody;
            StaticNotificationEntityToUpdate.EnglishTitle = Request.EnglishTitle;
            StaticNotificationEntityToUpdate.EnglishBody = Request.EnglishBody;

            await _StaticNotificationRepository.UpdateAsync(StaticNotificationEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Static notification's text has been updated successfully"
                : "تم تعديل نص الإشعار بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
