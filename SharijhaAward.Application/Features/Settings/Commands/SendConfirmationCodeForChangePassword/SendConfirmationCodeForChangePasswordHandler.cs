using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Models;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.SendConfirmationCodeForChangePassword
{
    public class SendConfirmationCodeForChangePasswordHandler : IRequestHandler<SendConfirmationCodeForChangePasswordCommand,
        BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.SubscriberModel.Subscriber> _SubscriberRepository;
        private readonly IJwtProvider _JWTProvider;
        private IEmailSender _EmailSender;

        public SendConfirmationCodeForChangePasswordHandler(IAsyncRepository<Domain.Entities.SubscriberModel.Subscriber> SubscriberRepository,
            IJwtProvider JWTProvider,
            IEmailSender EmailSender)
        {
            _SubscriberRepository = SubscriberRepository;
            _JWTProvider = JWTProvider;
            _EmailSender = EmailSender;
        }
        public async Task<BaseResponse<object>> Handle(SendConfirmationCodeForChangePasswordCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Guid UserId = new Guid(_JWTProvider.GetUserIdFromToken(Request.token!));

            Domain.Entities.SubscriberModel.Subscriber? SubscriberEntity = await _SubscriberRepository
                .FirstOrDefaultAsync(x => x.Id == UserId);

            if (SubscriberEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Subscriber is not found"
                    : "المشترك غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            int ConfirmationCode = new Random().Next(10000, 99999);

            SubscriberEntity.ConfirmationCode = ConfirmationCode;
            await _SubscriberRepository.UpdateAsync(SubscriberEntity);

            EmailRequest EmailRequest = new EmailRequest()
            {
                ToEmail = SubscriberEntity.Email,
                Subject = Request.lang == "ar"
                    ? $"رمز تفعيل"
                    : "Confirmation Code",
                Body = Request.lang == "ar"
                    ? $"رمز التفعيل الخاص بحسابك: {ConfirmationCode}"
                    : $"This is your account's confirmation code: {ConfirmationCode}"
            };

            await _EmailSender.SendEmail(EmailRequest);

            ResponseMessage = Request.lang == "en"
                ? "Confirmation code sent successfuly"
                : "تم إرسال كود التفعيل بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
