using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NotificationModel;

namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetCountForNotifications
{
    public class GetCountForNotificationsHandler : IRequestHandler<GetCountForNotificationsQuery, BaseResponse<GetCountForNotificationsDto>>
    {
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetCountForNotificationsHandler(IAsyncRepository<UserNotification> UserNotificationRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IJwtProvider JwtProvider)
        {
            _UserNotificationRepository = UserNotificationRepository;
            _UserTokenRepository = UserTokenRepository;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<GetCountForNotificationsDto>> Handle(GetCountForNotificationsQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            string? Token = Request.Token;
            UserToken? CheckUserTokenIfExist;

            if (!string.IsNullOrEmpty(Request.DeviceToken))
            {
                CheckUserTokenIfExist = await _UserTokenRepository
                    .FirstOrDefaultAsync(x => x.DeviceToken == Request.DeviceToken);

                if (CheckUserTokenIfExist == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "User Token is not Found"
                        : "تعريف المستخدم غير موجود";

                    return new BaseResponse<GetCountForNotificationsDto>(ResponseMessage, false, 404);
                }
            }
            else if (!string.IsNullOrEmpty(Token)
                ? (!string.IsNullOrEmpty(Token) && Token.ToLower() != "bearer null" &&
                Token.ToLower() != "bearer" && Token.ToLower() != "bearer " &&
                Token.ToLower() != "bearer undefined")
                : false)
            {
                CheckUserTokenIfExist = await _UserTokenRepository
                    .FirstOrDefaultAsync(x => x.Token == Request.Token);

                if (CheckUserTokenIfExist == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "User Token is not Found"
                        : "تعريف المستخدم غير موجود";

                    return new BaseResponse<GetCountForNotificationsDto>(ResponseMessage, false, 404);
                }
            }
            else
                return new BaseResponse<GetCountForNotificationsDto>(ResponseMessage, true, 200, new GetCountForNotificationsDto());

            List<IGrouping<bool, UserNotification>> UserNotificationEntitites = await _UserNotificationRepository
                .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                .GroupBy(x => x.isReaded)
                .ToListAsync();

            GetCountForNotificationsDto Response = new GetCountForNotificationsDto()
            {
                UnReadedNotificationsCount = UserNotificationEntitites.Count(x => !x.Key),
                ReadedNotificationsCount = UserNotificationEntitites.Count(x => x.Key)
            };

            return new BaseResponse<GetCountForNotificationsDto>(ResponseMessage, true, 200, Response);
        }
    }
}
