using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using SharijhaAward.Domain.Entities.NotificationModel;

namespace SharijhaAward.Application.Features.NotificationFeatures.Queries.GetAllNotificationsByFCM_Token
{
    public class GetAllNotificationsByFCM_TokenHandler 
        : IRequestHandler<GetAllNotificationsByFCM_TokenQuery, BaseResponse<List<GetAllNotificationsByFCM_TokenListVM>>>
    {
        private readonly IAsyncRepository<UserNotification> _UserNotificationRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IJwtProvider _JwtProvider;

        public GetAllNotificationsByFCM_TokenHandler(IAsyncRepository<UserNotification> UserNotificationRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IJwtProvider JwtProvider)
        {
            _UserNotificationRepository = UserNotificationRepository;
            _UserTokenRepository = UserTokenRepository;
            _JwtProvider = JwtProvider;
        }

        public async Task<BaseResponse<List<GetAllNotificationsByFCM_TokenListVM>>>
            Handle(GetAllNotificationsByFCM_TokenQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            if (!string.IsNullOrEmpty(Request.DeviceToken))
            {
                UserToken? CheckUserTokenIfExist = await _UserTokenRepository
                    .FirstOrDefaultAsync(x => x.DeviceToken == Request.DeviceToken);

                if (CheckUserTokenIfExist == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "User Token is not Found"
                        : "تعريف المستخدم غير موجود";

                    return new BaseResponse<List<GetAllNotificationsByFCM_TokenListVM>>(ResponseMessage, false, 404);
                }

                List<GetAllNotificationsByFCM_TokenListVM> UserNotifications = new List<GetAllNotificationsByFCM_TokenListVM>();

                if (Request.page != 0 && Request.pageSize != -1)
                {
                    UserNotifications = await _UserNotificationRepository
                        .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                        .Include(x => x.User!)
                        .Include(x => x.Notification!)
                        .Select(x => CheckUserTokenIfExist.AppLanguage == "en"
                            ? new GetAllNotificationsByFCM_TokenListVM()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.EnglishTitle,
                                Body = x.Notification!.EnglishBody.Replace("$Email$", x.User!.Email)
                            } : new GetAllNotificationsByFCM_TokenListVM()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.ArabicTitle,
                                Body = x.Notification!.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                            })
                        .OrderByDescending(x => x.Id)
                        .Skip((Request.page - 1) * Request.pageSize)
                        .Take(Request.pageSize)
                        .ToListAsync();
                }
                else
                {
                    UserNotifications = await _UserNotificationRepository
                        .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                        .Include(x => x.User!)
                        .Include(x => x.Notification!)
                        .Select(x => CheckUserTokenIfExist.AppLanguage == "en"
                            ? new GetAllNotificationsByFCM_TokenListVM()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.EnglishTitle,
                                Body = x.Notification!.EnglishBody.Replace("$Email$", x.User!.Email)
                            } : new GetAllNotificationsByFCM_TokenListVM()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.ArabicTitle,
                                Body = x.Notification!.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                            })
                        .OrderByDescending(x => x.Id)
                        .ToListAsync();
                }

                int TotalCount = await _UserNotificationRepository.GetCountAsync(x => x.UserId == CheckUserTokenIfExist.UserId);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllNotificationsByFCM_TokenListVM>>(ResponseMessage, true, 200, UserNotifications, PaginationParameter);
            }
            else if (!string.IsNullOrEmpty(Request.Token))
            {
                int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

                UserToken? CheckUserTokenIfExist = await _UserTokenRepository
                    .FirstOrDefaultAsync(x => x.Token == Request.Token &&
                        x.UserId == UserId);

                if (CheckUserTokenIfExist == null)
                {
                    ResponseMessage = Request.lang == "en"
                        ? "User Token is not Found"
                        : "تعريف المستخدم غير موجود";

                    return new BaseResponse<List<GetAllNotificationsByFCM_TokenListVM>>(ResponseMessage, false, 404);
                }

                List<GetAllNotificationsByFCM_TokenListVM> UserNotifications = new List<GetAllNotificationsByFCM_TokenListVM>();

                if (Request.page != 0 && Request.pageSize != -1)
                {
                    UserNotifications = await _UserNotificationRepository
                        .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                        .Include(x => x.User!)
                        .Include(x => x.Notification!)
                        .Select(x => CheckUserTokenIfExist.AppLanguage == "en"
                            ? new GetAllNotificationsByFCM_TokenListVM()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.EnglishTitle,
                                Body = x.Notification!.EnglishBody.Replace("$Email$", x.User!.Email)
                            } : new GetAllNotificationsByFCM_TokenListVM()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.ArabicTitle,
                                Body = x.Notification!.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                            })
                        .OrderByDescending(x => x.Id)
                        .Skip((Request.page - 1) * Request.pageSize)
                        .Take(Request.pageSize)
                        .ToListAsync();
                }
                else
                {
                    UserNotifications = await _UserNotificationRepository
                        .Where(x => x.UserId == CheckUserTokenIfExist.UserId)
                        .Include(x => x.User!)
                        .Include(x => x.Notification!)
                        .Select(x => CheckUserTokenIfExist.AppLanguage == "en"
                            ? new GetAllNotificationsByFCM_TokenListVM()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.EnglishTitle,
                                Body = x.Notification!.EnglishBody.Replace("$Email$", x.User!.Email)
                            } : new GetAllNotificationsByFCM_TokenListVM()
                            {
                                Id = x.NotificationId,
                                isReaded = x.isReaded,
                                Title = x.Notification!.ArabicTitle,
                                Body = x.Notification!.ArabicBody.Replace("$البريد الإلكتروني$", x.User!.Email)
                            })
                        .OrderByDescending(x => x.Id)
                        .ToListAsync();
                }

                int TotalCount = await _UserNotificationRepository.GetCountAsync(x => x.UserId == CheckUserTokenIfExist.UserId);

                Pagination PaginationParameter = new Pagination(Request.page,
                    Request.pageSize, TotalCount);

                return new BaseResponse<List<GetAllNotificationsByFCM_TokenListVM>>(ResponseMessage, true, 200, UserNotifications, PaginationParameter);
            }

            return new BaseResponse<List<GetAllNotificationsByFCM_TokenListVM>>(ResponseMessage, true, 200);
        }
    }
}
