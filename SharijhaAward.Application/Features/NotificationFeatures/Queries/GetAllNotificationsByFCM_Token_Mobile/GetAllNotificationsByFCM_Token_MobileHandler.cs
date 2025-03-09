using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NotificationModel;

namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotificationsByFCM_Token_Mobile
{
    public class GetAllNotificationsByFCM_Token_MobileHandler

        : IRequestHandler<GetAllNotificationsByFCM_Token_MobileQuery, BaseResponse<List<GetAllNotificationsByFCM_Token_MobileListVM>>>
    {
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetAllNotificationsByFCM_Token_MobileHandler(IAsyncRepository<UserNotification> UserNotificationRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IJwtProvider JwtProvider)
        {
            _UserNotificationRepository = UserNotificationRepository;
            _UserTokenRepository = UserTokenRepository;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<List<GetAllNotificationsByFCM_Token_MobileListVM>>>
            Handle(GetAllNotificationsByFCM_Token_MobileQuery Request, CancellationToken cancellationToken)
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

                    return new BaseResponse<List<GetAllNotificationsByFCM_Token_MobileListVM>>(ResponseMessage, false, 404);
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

                    return new BaseResponse<List<GetAllNotificationsByFCM_Token_MobileListVM>>(ResponseMessage, false, 404);
                }
            }
            else
                return new BaseResponse<List<GetAllNotificationsByFCM_Token_MobileListVM>>(ResponseMessage, true, 200, new List<GetAllNotificationsByFCM_Token_MobileListVM>());

            List<GetAllNotificationsByFCM_Token_MobileListVM> Response = new List<GetAllNotificationsByFCM_Token_MobileListVM>();

            int TotalCount = 0;

            if (Request.page != 0 && Request.perPage != -1)
            {
                Response = _UserNotificationRepository
                    .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                    .OrderByDescending(x => x.CreatedAt)
                    .AsEnumerable()
                    .Skip((Request.page - 1) * Request.perPage)
                    .Take(Request.perPage)
                    .AsEnumerable()
                    .Select(x => CheckUserTokenIfExist.AppLanguage == "en"
                        ? new GetAllNotificationsByFCM_Token_MobileListVM()
                        {
                            Id = x.NotificationId,
                            isReaded = x.isReaded,
                            Title = x.Notification!.EnglishTitle,
                            Body = x.Notification!.EnglishBody.Replace("$Email$", x.User!.Email),
                            CreatedAt = x.CreatedAt,
                            Action = x.Action
                        } : new GetAllNotificationsByFCM_Token_MobileListVM()
                        {
                            Id = x.NotificationId,
                            isReaded = x.isReaded,
                            Title = x.Notification!.ArabicTitle,
                            Body = x.Notification!.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email),
                            CreatedAt = x.CreatedAt,
                            Action = x.Action
                        })
                    .ToList();

                TotalCount = await _UserNotificationRepository
                    .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                    .CountAsync();
            }
            else
            {
                Response = await _UserNotificationRepository
                    .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                    .Select(x => CheckUserTokenIfExist.AppLanguage == "en"
                        ? new GetAllNotificationsByFCM_Token_MobileListVM()
                        {
                            Id = x.NotificationId,
                            isReaded = x.isReaded,
                            Title = x.Notification!.EnglishTitle,
                            Body = x.Notification!.EnglishBody.Replace("$Email$", x.User!.Email),
                            CreatedAt = x.CreatedAt,
                            Action = x.Action
                        } : new GetAllNotificationsByFCM_Token_MobileListVM()
                        {
                            Id = x.NotificationId,
                            isReaded = x.isReaded,
                            Title = x.Notification!.ArabicTitle,
                            Body = x.Notification!.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email),
                            CreatedAt = x.CreatedAt,
                            Action = x.Action
                        })
                    .OrderByDescending(x => x.CreatedAt)
                    .ToListAsync();

                TotalCount = Response.Count();
            }

            Pagination PaginationParameter = new Pagination(Request.page,
                Request.perPage, TotalCount);

            return new BaseResponse<List<GetAllNotificationsByFCM_Token_MobileListVM>>(ResponseMessage, true, 200, Response, PaginationParameter);
        }
    }
}
